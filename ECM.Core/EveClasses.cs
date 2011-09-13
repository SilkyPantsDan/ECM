using System;

namespace ECM.Core
{
	public class EveBase
	{
		public long ID { get; set; }
		public string Name { get; set; }
		public string IconString { get; set; }
		public object Tag { get; set; }
	}

    public class EveMarketGroup : EveBase
    {
        public long ParentID { get; set; }
    }

    public class EveItem : EveBase
    {
        public long MarketGroupID { get; set; }
    }
}

