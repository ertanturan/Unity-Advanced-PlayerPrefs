namespace CustomTools.CustomPlayerPrefs.Scripts
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using UnityEngine;

    public static class Utility
    {
        public static async Task SaveToJsonAsync<T>(T objectToSerialize, string fullPath)
        {
            await Task.Run(delegate
            {
                string jsonString = JsonUtility.ToJson(objectToSerialize, true);
                File.WriteAllText(fullPath, jsonString);
            });
        }

        public static async Task<T> ReadFromJsonAsync<T>(string fullPath)
        {
            T returnedValue = default;

            await Task.Run(delegate
            {
                string jsonString = File.ReadAllText(fullPath);
                returnedValue = JsonUtility.FromJson<T>(jsonString);
            });
            return returnedValue;
        }

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