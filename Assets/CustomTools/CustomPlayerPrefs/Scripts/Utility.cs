namespace CustomTools.CustomPlayerPrefs.Scripts
{
    using System;
    using System.Collections.Generic;

    public static class Utility
    {
        public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            int index = 0;
            foreach (T value in collection)
            {
                if (predicate(value))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }
    }
}