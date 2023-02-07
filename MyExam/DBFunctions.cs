using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MyExam
{
    public static class DBFunctions
    {
        public static Collection<TransportMean> LoadTransportMeans(string query)
        {
            Collection<TransportMean> collection = new Collection<TransportMean>();
            using(OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDB.12.0;Data Source=Database31.accdb"))
            {
                OleDbCommand cmd = new OleDbCommand(query);
                cmd.Connection = cnn;
                cnn.Open();
                using(OleDbDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        collection.list.Add(new TransportMean(dr["Type"].ToString(), dr["Color"].ToString(),
                            Convert.ToInt32(dr["Year"]), Convert.ToInt32(dr["Price"])));
                    }
                }
            }
            return collection;
        }
    }
}
