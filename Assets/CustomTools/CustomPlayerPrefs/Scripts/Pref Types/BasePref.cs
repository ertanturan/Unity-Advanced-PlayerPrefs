namespace CustomTools.CustomPlayerPrefs.Scripts.Pref_Types
{
    using System;

    [Serializable]
    public class BasePref
    {
        public string Key;

        public BasePref(string key)
        {
            Key = key;
        }
    }
}