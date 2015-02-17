using System;
using System.Collections;

namespace _02.String_Disperser
{
    class StringDisperser:IComparable<StringDisperser>, ICloneable,IEnumerable
    {
        public StringDisperser(params string[] args)
        {
            this.Strings = args;
        }

        public string[] Strings { get; set; }


        public override string ToString()
        {
            return string.Join("", this.Strings);
        }

        protected bool Equals(StringDisperser other)
        {
            return Equals(Strings, other.Strings);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((StringDisperser) obj);
        }

        public override int GetHashCode()
        {
            return (Strings != null ? Strings.GetHashCode() : 0);
        }

        public static bool operator ==(StringDisperser left, StringDisperser right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StringDisperser left, StringDisperser right)
        {
            return !Equals(left, right);
        }

        public int CompareTo(StringDisperser other)
        {
            return this.ToString().CompareTo(other.ToString());
        }

        public object Clone()
        {
            var cloned = new StringDisperser(this.Strings);
            return cloned;
        }

        public IEnumerator GetEnumerator()
        {
            var str = this.ToString();
            for (var i = 0; i < str.Length; i++)
            {
                yield return str[i];
            }
        }
    }
}
