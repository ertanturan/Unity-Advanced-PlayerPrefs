namespace CustomTools.CustomPlayerPrefs.Pref_Types
{
    using System;

    [Serializable]
    public class FloatPref : BasePref
    {
        public float Value;

        public FloatPref(string key, float value) : base(key)
        {
            Key = key;
            Value = value;
        }
    }
}