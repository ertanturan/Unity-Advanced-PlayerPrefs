namespace CustomTools.CustomPlayerPrefs
{
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Pref_Types;
    using UnityEngine;

    public static class PrefsManager
    {
        #region Fields

        private const string _EXTENSION = ".json";
        private const string _FILE_NAME = "Preferences";
        private static readonly string _SavePath = Application.persistentDataPath;
        private static readonly string _FullPath = Path.Combine(_SavePath, string.Concat(_FILE_NAME, _EXTENSION));
        private static SerializedPrefs _Prefs;

        #endregion

        #region Operate

        [RuntimeInitializeOnLoadMethod]
        private static async void Start()
        {
            CheckIfFileExistCreateIfNot();
            _Prefs = await LoadPrefsIfExists();
        }

        private static void CheckIfFileExistCreateIfNot()
        {
            if (!File.Exists(_FullPath))
            {
                File.WriteAllText(_FullPath, "");
            }
        }

        private static async Task<SerializedPrefs> LoadPrefsIfExists()
        {
            SerializedPrefs prefs = await Utility.ReadFromJsonAsync<SerializedPrefs>(_FullPath);
            if (prefs == null)
            {
                return new SerializedPrefs();
            }

            return prefs;
        }


        private static async void Save()
        {
            await Utility.SaveToJsonAsync(_Prefs, _FullPath);
        }

        #endregion

        #region Integer

        public static void SetIntPrefs(this int value, string key)
        {
            if (_Prefs.IntegerPrefs.All(a => a.Key != key))
            {
                //no such key added before
                _Prefs.IntegerPrefs.Add(new IntegerPref(key, value));
            }
            else
            {
                //the key exists.. overwrite
                int index = _Prefs.StringPrefs.IndexOf(a => a.Key == key);

                _Prefs.IntegerPrefs[index] = new IntegerPref(key, value);
            }

            Save();
        }

        public static int GetIntPrefs(string key)
        {
            if (_Prefs.IntegerPrefs.Any(a => a.Key == key))
            {
                IntegerPref intPref = _Prefs.IntegerPrefs.Where(a => a.Key == key).ToList()[0];
                if (intPref != null)
                {
                    return intPref.Value;
                }
            }

            Debug.LogWarning("No such value found !");
            return -1;
        }

        #endregion

        #region Float

        public static void SetFloatPrefs(this float value, string key)
        {
            if (_Prefs.FloatPrefs.All(a => a.Key != key))
            {
                //no such key added before
                _Prefs.FloatPrefs.Add(new FloatPref(key, value));
            }
            else
            {
                //the key exists.. overwrite
                int index = _Prefs.FloatPrefs.IndexOf(a => a.Key == key);

                _Prefs.FloatPrefs[index] = new FloatPref(key, value);
            }

            Save();
        }

        public static float GetFloatPrefs(string key)
        {
            if (_Prefs.FloatPrefs.Any(a => a.Key == key))
            {
                FloatPref floatPref = _Prefs.FloatPrefs.Where(a => a.Key == key).ToList()[0];
                if (floatPref != null)
                {
                    return floatPref.Value;
                }
            }

            Debug.LogWarning("No such value found !");
            return -1f;
        }

        #endregion

        #region String

        public static void SetStringPrefs(this string value, string key)
        {
            if (_Prefs.StringPrefs.All(a => a.Key != key))
            {
                //no such key added before
                _Prefs.StringPrefs.Add(new StringPref(key, value));
            }
            else
            {
                //the key exists.. overwrite
                int index = _Prefs.StringPrefs.IndexOf(a => a.Key == key);

                _Prefs.StringPrefs[index] = new StringPref(key, value);
            }

            Save();
        }

        public static string GetStringPrefs(string key)
        {
            if (_Prefs.StringPrefs.Any(a => a.Key == key))
            {
                StringPref stringPref = _Prefs.StringPrefs.Where(a => a.Key == key).ToList()[0];
                if (stringPref != null)
                {
                    return stringPref.Value;
                }
            }

            Debug.LogWarning("No such value found !");
            return "";
        }

        #endregion

        #region Vector3

        public static void SetVector3Prefs(this Vector3 value, string key)
        {
            if (_Prefs.Vector3Prefs.All(a => a.Key != key))
            {
                //no such key added before
                _Prefs.Vector3Prefs.Add(new Vector3Pref(key, value));
            }
            else
            {
                //the key exists.. overwrite
                int index = _Prefs.Vector3Prefs.IndexOf(a => a.Key == key);

                _Prefs.Vector3Prefs[index] = new Vector3Pref(key, value);
            }

            Save();
        }

        public static Vector3 GetVector3Prefs(string key)
        {
            if (_Prefs.Vector3Prefs.Any(a => a.Key == key))
            {
                Vector3Pref vector3Pref = _Prefs.Vector3Prefs.Where(a => a.Key == key).ToList()[0];
                if (vector3Pref != null)
                {
                    return new Vector3(vector3Pref.X, vector3Pref.Y, vector3Pref.Z);
                }
            }

            Debug.LogWarning("No such value found !");
            return default;
        }

        #endregion

        #region Quaternion

        public static void SetQuaternionPrefs(this Quaternion value, string key)
        {
            if (_Prefs.QuaternionPrefs.All(a => a.Key != key))
            {
                //no such key added before
                _Prefs.QuaternionPrefs.Add(new QuaternionPref(key, value));
            }
            else
            {
                //the key exists.. overwrite
                int index = _Prefs.QuaternionPrefs.IndexOf(a => a.Key == key);

                _Prefs.QuaternionPrefs[index] = new QuaternionPref(key, value);
            }

            Save();
        }

        public static Quaternion GetQuaternionPrefs(string key)
        {
            if (_Prefs.QuaternionPrefs.Any(a => a.Key == key))
            {
                QuaternionPref quaternionPref = _Prefs.QuaternionPrefs.Where(a => a.Key == key).ToList()[0];
                if (quaternionPref != null)
                {
                    return new Quaternion(quaternionPref.X, quaternionPref.Y, quaternionPref.Z, quaternionPref.W);
                }
            }

            Debug.LogWarning("No such value found !");
            return default;
        }

        #endregion
    }
}