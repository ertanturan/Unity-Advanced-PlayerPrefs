namespace CustomTools.CustomPlayerPrefs.Scripts.Pref_Types
{
    using System;

    [Serializable]
    public class IntegerPref : BasePref
    {
        public int Value;

        public IntegerPref(string key, int value) : base(key)
        {
            Key = key;
            Value = value;
        }
    }
}