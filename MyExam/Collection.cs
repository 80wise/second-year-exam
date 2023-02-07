using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public class Collection<T> : IEnumerable
        where T : TransportMean, IComparable<T>
    {
        public List<T> list = new List<T>();

        public Collection() { }
        public IEnumerator GetEnumerator()
        {
            foreach (T element in list)
            {
                yield return element;
            }
        }

        public List<T> Find(Func<T, bool> condition)
        {
            return list.Where(condition).ToList();
        }
    }
}
