namespace CustomTools.CustomPlayerPrefs
{
    using System;
    using System.Collections.Generic;
    using Pref_Types;

    [Serializable]
    public class SerializedPrefs
    {
        public List<StringPref> StringPrefs = new List<StringPref>();

        public List<IntegerPref> IntegerPrefs = new List<IntegerPref>();

        public List<FloatPref> FloatPrefs = new List<FloatPref>();

        public List<Vector3Pref> Vector3Prefs = new List<Vector3Pref>();

        public List<QuaternionPref> QuaternionPrefs = new List<QuaternionPref>();
    }
}