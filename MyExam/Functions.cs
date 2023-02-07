using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public static class Functions
    {
        public static Collection<TransportMean> FillCollection()
        {
            string query = "select Type, Year, Color, Price " +
                "from TransportMean , TypeOfTransportMean" +
                " WHERE [Id Type] = TypeOfTransportMean.Id";
            Collection<TransportMean> collection = DBFunctions.LoadTransportMeans(query);

            return collection;
        }
    }
}
