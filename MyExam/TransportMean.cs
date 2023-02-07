using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public class TransportMean: IComparable<TransportMean>
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public TransportMean(string type, string color, int year, int price)
        {
            Type = type;
            Color = color;
            Year = year;
            Price = price;
        }

        public int CompareTo(TransportMean t)
        {
            return t.Year.CompareTo(this.Year);
        }
    }
}
