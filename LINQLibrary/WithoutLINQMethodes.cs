using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLibrary
{
    public static class WithoutLINQMethodes
    {
        public static T First<T>(List<T> source)
        {
            if (source.Count == 0)
            {
                throw new Exception("The source list is eeeempty.");
            }

            return source[0];
        }

        public static T Last<T>(List<T> source)
        {
            if (source.Count == 0)
            {
                throw new Exception("The source list is eeeempty.");
            }

            return source[source.Count - 1];
        }

        public static List<T> Where<T>(List<T> source, Func<T, bool> predicate)
        {
            List<T> filteredList = new List<T>();

            foreach (T element in source)
            {
                if (predicate(element))
                {
                    filteredList.Add(element);
                }
            }

            return filteredList;
        }

        public static List<T> Take<T>(List<T> source, int count)
        {
            List<T> takenList = new List<T>();

            for (int i = 0; i < count && i < source.Count; i++)
            {
                takenList.Add(source[i]);
            }

            return takenList;
        }

        //public class Key : IComparable<Key>
        //{
        //    public int Value { get; set; }

        //    public int CompareTo(Key other)
        //    {
        //        return this.Value.CompareTo(other.Value);
        //    }
        //}


        public static List<TResult> Select<T, TResult>(List<T> source, Func<T, TResult> selector)
        {
            List<TResult> selectedList = new List<TResult>();

            foreach (T element in source)
            {
                selectedList.Add(selector(element));
            }

            return selectedList;
        }
    }
}
