namespace CustomTools.CustomPlayerPrefs.Scripts
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using UnityEngine;

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
        
        public static async Task SaveToJsonAsync<T>(T objectToSerialize, string fullPath)
        {
            
           
            string jsonString = JsonUtility.ToJson(objectToSerialize, true);

            using (StreamWriter streamWriter = new StreamWriter(fullPath))
            {
                await streamWriter.WriteAsync(jsonString);
            }
        }

        public static async Task<T> ReadFromJsonAsync<T>(string fullPath)
        {
            T returnedValue;

            using (StreamReader streamReader = new StreamReader(fullPath))
            {
                string jsonString = await streamReader.ReadToEndAsync();
                returnedValue = JsonUtility.FromJson<T>(jsonString);
            }


            return returnedValue;
        }
    }
}