namespace CustomTools.CustomPlayerPrefs.Pref_Types
{
    using System;
    using UnityEngine;

    [Serializable]
    public class Vector3Pref : BasePref
    {
        public float X, Y, Z;

        public Vector3Pref(string key, Vector3 vector3) : base(key)
        {
            X = vector3.x;
            Y = vector3.y;
            Z = vector3.z;
        }
    }
}