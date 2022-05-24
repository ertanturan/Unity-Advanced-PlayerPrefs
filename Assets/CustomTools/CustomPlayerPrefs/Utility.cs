using System.IO;
using UnityEngine;

public static class Utility
{
    public static void SaveToJson<T>(T objectToSerialize, string fullPath)
    {
        string jsonString = JsonUtility.ToJson(objectToSerialize);
        File.WriteAllText(fullPath, jsonString);
    }

    public static T ReadFromJson<T>(string fullPath)
    {
        string jsonString = File.ReadAllText(fullPath);
        return JsonUtility.FromJson<T>(jsonString);
    }
}