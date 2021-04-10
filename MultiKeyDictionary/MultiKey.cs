using System;
using System.Collections.Generic;
using System.Text;

namespace MultiKeyDictionary
{
    [Serializable]
    public struct MultiKey<TKey1, TKey2>
    {
        public TKey1 Key1 { get; }

        public TKey2 Key2 { get; }

        public MultiKey(TKey1 key1, TKey2 key2)
        {
            Key1 = key1;
            Key2 = key2;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append('[');
            if (Key1 != null)
            {
                s.Append(Key1.ToString());
            }
            s.Append(", ");
            if (Key2 != null)
            {
                s.Append(Key2.ToString());
            }
            s.Append(']');
            return s.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is MultiKey<TKey1, TKey2> multiKey)
            {
                return EqualityComparer<TKey1>.Default.Equals(Key1, multiKey.Key1) &&
                       EqualityComparer<TKey2>.Default.Equals(Key2, multiKey.Key2);
            }

            return false;
        }

        //https://www.loganfranken.com/blog/687/overriding-equals-in-c-part-1/
        public override int GetHashCode()
        {
            unchecked
            {
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, Key1) ? Key1.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, Key2) ? Key2.GetHashCode() : 0);
                return hash;
            }
        }

        public static bool operator ==(MultiKey<TKey1, TKey2> obj1, MultiKey<TKey1, TKey2> obj2)
        {
            if (Object.ReferenceEquals(obj1, obj2))
            {
                return true;
            }

            // Ensure that "obj1" isn't null
            if (Object.ReferenceEquals(null, obj1))
            {
                return false;
            }

            return obj1.Equals(obj2);
        }

        public static bool operator !=(MultiKey<TKey1, TKey2> obj1, MultiKey<TKey1, TKey2> obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
