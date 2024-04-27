using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Homework
{
    public class ComparablePair <T, U> : Pair<T, U>, IComparable<ComparablePair<T ,U>> 
        where T : IComparable<T> 
        where U : IComparable<U>
    {
        public T t {  get; set; }

        public U u { get; set; }

        public ComparablePair(T t, U u) : base(t, u)
        {
            this.t = t;
            this.u = u;
        }

        public int CompareTo(ComparablePair<T, U> otherPair)
        {
            if (t.CompareTo(otherPair.t) == 0)
            {
                return u.CompareTo(otherPair.u);
            }
            else
            {
                return t.CompareTo(otherPair.t);
            }
        }

    }
}
