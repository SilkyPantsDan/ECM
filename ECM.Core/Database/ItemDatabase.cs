using System;
using System.Collections.Generic;
using System.Data.SQLite;

using SqlConn = System.Data.SQLite.SQLiteConnection;
using SqlCmd = System.Data.SQLite.SQLiteCommand;
using SqlReader = System.Data.SQLite.SQLiteDataReader;
using System.Reflection;
using System.IO;

namespace ECM.Core
{
	public static class ItemDatabase
	{		
		static SqlConn sqlConnection = null;
    
	    static string itemDatabasePath = "Resources/Database/eveItems.db";
	    static string skillsDatabasePath = "Resources/Database/eveSkills.db";
		
		static Dictionary<long, EveMarketGroup> m_MarketGroups = new Dictionary<long, EveMarketGroup>();
        static Dictionary<long, EveItem> m_Items = new Dictionary<long, EveItem>();
		
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
		#endregion
	    
	    private static bool OpenDatabase()
	    {
	        Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
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
	    
	    public static void LoadMarket()
	    {
	        OpenDatabase();
	        
	        LoadMarketGroups();
            LoadItems();
	        
	        CloseDatabase();
	    }
	    
	    private static void LoadMarketGroups()
	    {
	     	string selectCmd = "SELECT marketGroupID, marketGroupName, parentGroupID FROM invMarketGroups ORDER BY hasTypes, parentGroupID, marketGroupID";
	     
	        SqlCmd cmd = sqlConnection.CreateCommand();
	        cmd.CommandText = selectCmd;
	        SqlReader row = cmd.ExecuteReader();
	        
	        while(row.Read())
	        {
	            string groupName = row[1].ToString();
	            long groupID = Convert.ToInt64(row[0]);
	            long parentID = row[2] is DBNull ? -1 : Convert.ToInt64(row[2]);
				
				EveMarketGroup newGroup = new EveMarketGroup();
				newGroup.Name = groupName;
				newGroup.ID = groupID;
				newGroup.ParentID = parentID;
				newGroup.IconString = "ECM.Core.Icons.MarketGroupPNG";
				
				m_MarketGroups.Add(groupID, newGroup);
	        }
	    }
	    
	    private static void LoadItems()
	    {
	        SqlCmd cmd = sqlConnection.CreateCommand();
            cmd.CommandText = string.Format("SELECT typeID, typeName, marketGroupID FROM invTypes UNION SELECT typeID, typeName, marketGroupID FROM invSkills");
	        SqlReader row = cmd.ExecuteReader();
	        
	        while(row.Read())
	        {
                string itemName = row[1].ToString();
                long typeID = Convert.ToInt64(row[0]);
                long mgID = row[2] is DBNull ? -1 : Convert.ToInt64(row[2]);

                EveItem newGroup = new EveItem();
				newGroup.Name = itemName;
				newGroup.ID = typeID;
                newGroup.MarketGroupID = mgID;
				newGroup.IconString = "TYPEID";
				
				m_Items.Add(typeID, newGroup);
	        }
	    }

		public static void LoadMarket (Gtk.TreeStore marketStore)
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

				marketStore.SetValues(groupIter, new Gdk.Pixbuf(MarketGroupPNG), group.Name, group.ID);
				group.Tag = groupIter;
			}

            foreach (EveItem item in m_Items.Values)
            {
                if (item.MarketGroupID > -1)
                {
                    Gtk.TreeIter parentIter = (Gtk.TreeIter)m_MarketGroups[item.MarketGroupID].Tag;
                    marketStore.AppendValues(parentIter, null, item.Name, item.ID);
                }
            }
		}
	}
}

