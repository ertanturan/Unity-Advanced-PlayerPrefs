using System;

[Serializable]
public class StringPref : BasePref
{
    public string Value;

    public StringPref(string key, string value) : base(key)
    {
        Key = key;
        Value = value;
    }
}