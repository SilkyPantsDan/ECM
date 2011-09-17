using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Reflection;
using System.IO;

using SqlConn = System.Data.SQLite.SQLiteConnection;
using SqlCmd = System.Data.SQLite.SQLiteCommand;
using SqlReader = System.Data.SQLite.SQLiteDataReader;

namespace ECM.Core
{
	public class ItemDatabase
	{		
		static SqlConn sqlConnection = null;
    
	    static string itemDatabasePath = "Resources/Database/eveItems.db";
	    static string skillsDatabasePath = "Resources/Database/eveSkills.db";
		
		static Dictionary<long, EveMarketGroup> m_MarketGroups = new Dictionary<long, EveMarketGroup>();
        static Dictionary<long, EveItem> m_Items = new Dictionary<long, EveItem>();

        public static Dictionary<long, EveItem> Items
        {
            get
            {
                return m_Items;
            }
        }
		
		#region Resources
		public static Stream MarketGroupPNG
		{
			get
			{
				Assembly ass = Assembly.GetExecutingAssembly();
				
				if(ass != null)
				{
					return ass.GetManifestResourceStream("ECM.Core.Icons.MarketGroupPNG");
				}
				
				return null;
			}
		}

        public static Stream ItemUnknownPNG
        {
            get
            {
                Assembly ass = Assembly.GetExecutingAssembly();

                if(ass != null)
                {
                    return ass.GetManifestResourceStream("ECM.Core.Icons.ItemUnknownPNG");
                }
                
                return null;
            }
        }

        public static Stream Skillbook22PNG
        {
            get
            {
                Assembly ass = Assembly.GetExecutingAssembly();

                if(ass != null)
                {
                    return ass.GetManifestResourceStream("ECM.Core.Icons.Skillbook22PNG");
                }
                
                return null;
            }
        }

        public static Stream Info16PNG
        {
            get
            {
                Assembly ass = Assembly.GetExecutingAssembly();

                if(ass != null)
                {
                    return ass.GetManifestResourceStream("ECM.Core.Icons.Info16PNG");
                }
                
                return null;
            }
        }
		#endregion
	    
	    private static bool OpenDatabase()
	    {
	        sqlConnection = new SqlConn(string.Format("Data Source={0};version=3", itemDatabasePath));
	        sqlConnection.Open();
	    
	        SqlCmd cmd = sqlConnection.CreateCommand();
	        cmd.CommandText = "PRAGMA cache_size=5000";
	        cmd.ExecuteNonQuery();

	        cmd = sqlConnection.CreateCommand();
	        cmd.CommandText = "PRAGMA count_changes=OFF";
	        cmd.ExecuteNonQuery();
	    
	        cmd = sqlConnection.CreateCommand();
	        cmd.CommandText = "PRAGMA temp_store=MEMORY";
	        cmd.ExecuteNonQuery();
	    
	        cmd = sqlConnection.CreateCommand();
	        cmd.CommandText = string.Format("ATTACH DATABASE \'{0}\' AS {1}", skillsDatabasePath, 
	                                     System.IO.Path.GetFileNameWithoutExtension(skillsDatabasePath));
	        cmd.ExecuteNonQuery();
	    
	        cmd.Dispose();
	     
	        return true;
	    }

	    private static void CloseDatabase()
	    {
	        if(sqlConnection.State != System.Data.ConnectionState.Open) return;
	        
	        sqlConnection.Close();
	    }
	    
	    private static void LoadMarket()
	    {
	        OpenDatabase();
	        
	        LoadMarketGroups();
            LoadItems();
	        
	        CloseDatabase();
	    }
	    
	    private static void LoadMarketGroups()
	    {
	     	string selectCmd = "SELECT marketGroupID, marketGroupName, parentGroupID, hasTypes FROM invMarketGroups ORDER BY hasTypes, parentGroupID, marketGroupID";
	     
	        SqlCmd cmd = sqlConnection.CreateCommand();
	        cmd.CommandText = selectCmd;
	        SqlReader row = cmd.ExecuteReader();

	        while(row.Read())
	        {
	            string groupName = row[1].ToString();
	            long groupID = Convert.ToInt64(row[0]);
	            long parentID = row[2] is DBNull ? -1 : Convert.ToInt64(row[2]);
                bool hasItems = row[3] is DBNull ? false : Convert.ToInt32(row[3]) == 1;
				
				EveMarketGroup newGroup = new EveMarketGroup();
				newGroup.Name = groupName;
				newGroup.ID = groupID;
				newGroup.ParentID = parentID;
                newGroup.HasItems = hasItems;
				newGroup.IconString = "ECM.Core.Icons.MarketGroupPNG";
				
				m_MarketGroups.Add(groupID, newGroup);
	        }
	    }
	    
	    private static void LoadItems()
	    {
	        SqlCmd cmd = sqlConnection.CreateCommand();
            cmd.CommandText = string.Format("SELECT typeID, typeName, marketGroupID, description FROM invTypes UNION SELECT typeID, typeName, marketGroupID, description FROM invSkills");
	        SqlReader row = cmd.ExecuteReader();
	        
	        while(row.Read())
	        {
                string itemName = row[1].ToString();
                long typeID = Convert.ToInt64(row[0]);
                long mgID = row[2] is DBNull ? -1 : Convert.ToInt64(row[2]);
                string itemDesc = row[3].ToString();

                EveItem newItem = new EveItem();
				newItem.Name = itemName;
                newItem.Description = itemDesc;
				newItem.ID = typeID;
                newItem.MarketGroupID = mgID;
				newItem.IconString = "TYPEID";
				
				m_Items.Add(typeID, newItem);
	        }
	    }

		public static void LoadMarket (Gtk.TreeStore marketStore, Gtk.ListStore itemStore)
		{
			LoadMarket();

			foreach(EveMarketGroup group in m_MarketGroups.Values)
			{
                Gtk.TreeIter groupIter;

                if (group.ParentID > -1)
                {
                    Gtk.TreeIter parentIter = (Gtk.TreeIter)m_MarketGroups[group.ParentID].Tag;
                    groupIter = marketStore.AppendNode(parentIter);
                }
                else
                {
                    groupIter = marketStore.AppendNode();
                }

				marketStore.SetValues(groupIter, new Gdk.Pixbuf(MarketGroupPNG), group.Name, group.ID, group.HasItems);
				group.Tag = groupIter;
			}

            foreach (EveItem item in m_Items.Values)
            {
                if (item.MarketGroupID > -1)
                {
                    Gtk.TreeIter parentIter = (Gtk.TreeIter)m_MarketGroups[item.MarketGroupID].Tag;
                    marketStore.AppendValues(parentIter, null, item.Name, item.ID);
                    itemStore.AppendValues(item.Name, item.ID);
                }
            }
		}
	}
}

