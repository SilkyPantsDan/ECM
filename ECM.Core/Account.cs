using System;
using ECM.API.EVE;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ECM
{
    public class Account : DatabaseBase, IAccountStatus
    {
        AuthorisedApiRequest<ApiKeyInfo> m_accountKeyInfo;
        AuthorisedApiRequest<AccountStatus> m_accountStatus;
        ApiKeyMask m_KeyAccess;
        Dictionary<long, Character> m_Characters = new Dictionary<long, Character>();

        public ApiKeyMask KeyAccess
        {
            get { return m_KeyAccess; }
            private set
            {
                SetProperty<ApiKeyMask>("KeyAccess", ref m_KeyAccess, value);
                m_accountStatus.Enabled = m_KeyAccess.HasFlag(ApiKeyMask.AccountStatus);
            }
        }

        DateTime m_Expires;
        public DateTime Expires
        {
            get { return m_Expires; }
            private set
            {
                SetProperty<DateTime>("Expires", ref m_Expires, value);
            }
        }

        #region IAccountStatus implementation
        public int LogonCount
        {
            get;
            set;
        }

        public int LogonMinutes
        {
            get;
            set;
        }

        public DateTime PaidUntil
        {
            get;
            set;
        }

        public DateTime CreateDate
        {
            get;
            set;
        }
        #endregion

        public bool PaidUntilExpired
        {
            get { return PaidUntil.CompareTo(DateTime.UtcNow) <= 0; }
        }

        public string KeyID
        {
            get;
            private set;
        }

        public string VCode
        {
            get;
            private set;
        }

        public ReadOnlyCollection<Character> Characters
        {
            get { return new ReadOnlyCollection<Character>(new List<Character>(m_Characters.Values)); }
        }

        public delegate void AccountUpdatedHandler(Account account, IApiResult result);
        public event AccountUpdatedHandler AccountUpdated;

        private void OnAccountUpdated(IApiResult result)
        {
            if (AccountUpdated != null)
            {
                AccountUpdated(this, result);
            }
        }

        public Account(string keyID, string vCode)
        {
            KeyID = keyID;
            VCode = vCode;

            m_accountKeyInfo = new AuthorisedApiRequest<ApiKeyInfo>(keyID, vCode);
            m_accountKeyInfo.OnRequestUpdate += AccountKeyInfoUpdate;
            m_accountKeyInfo.Enabled = true;

            m_accountStatus = new AuthorisedApiRequest<AccountStatus>(keyID, vCode);
            m_accountStatus.OnRequestUpdate += AccountStatusUpdate;

            API.EveApi.AddRequest(m_accountKeyInfo);
            API.EveApi.AddRequest(m_accountStatus);
        }

        public Account(string keyID, string vCode, ApiKeyMask access, DateTime expiry) : this(keyID, vCode)
        {
            KeyAccess = access;
            Expires = expiry;
        }

        void AccountKeyInfoUpdate (IApiRequest request)
        {
            if (request.LastResult != null && request.LastResult.Error == null && request == m_accountKeyInfo)
            {
                ApiResult<ApiKeyInfo> keyInfo = request.LastResult as ApiResult<ApiKeyInfo>;

                KeyAccess = keyInfo.Result.Key.AccessMask;
                Expires = keyInfo.Result.Key.Expires;

                foreach (CharacterListItem character in keyInfo.Result.Key.Characters)
                {
                    AddCharacter(character.CharacterID, character.Name);
                }

                OnAccountUpdated(request.LastResult);
            }
        }

        void AccountStatusUpdate (IApiRequest request)
        {
            if (request.LastResult != null && request.LastResult.Error == null && request == m_accountStatus)
            {
                ApiResult<AccountStatus> accStatus = request.LastResult as ApiResult<AccountStatus>;

                LogonCount = accStatus.Result.LogonCount;
                LogonMinutes = accStatus.Result.LogonMinutes;
                CreateDate = accStatus.Result.CreateDate;
                PaidUntil = accStatus.Result.PaidUntil;

                OnAccountUpdated(request.LastResult);
            }
        }

        public void UpdateOnHeartbeat()
        {
            m_accountKeyInfo.UpdateOnSecTick();
            m_accountStatus.UpdateOnSecTick();

            foreach(Character character in Characters)
            {
                character.UpdateOnHeartbeat();
            }
        }

        internal void AddCharacter(long charID, string charName)
        {
            if (m_Characters.ContainsKey(charID) == false)
                m_Characters.Add(charID, new Character(this, charID, charName));
        }

        public Character GetCharacter (long charID)
        {
            return m_Characters[charID];
        }

        #region implemented abstract members of ECM.DatabaseBase

        public override void SaveToDatabase ()
        {
            foreach(Character c in Characters)
                c.SaveToDatabase();

            base.SaveToDatabase ();
        }

        protected override void WriteToDatabase ()
        {
            AccountDatabase.AddAccount(this);
        }
        #endregion
    }
}

