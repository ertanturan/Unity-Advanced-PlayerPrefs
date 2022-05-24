namespace CustomTools.CustomPlayerPrefs.Scripts.Pref_Types
{
    using System;
    using UnityEngine;

    [Serializable]
    public class QuaternionPref : BasePref
    {
        public float X, Y, Z, W;

        public QuaternionPref(string key, Quaternion quaternion) : base(key)
        {
            X = quaternion.x;
            Y = quaternion.y;
            Z = quaternion.z;
            W = quaternion.w;
        }
    }
}