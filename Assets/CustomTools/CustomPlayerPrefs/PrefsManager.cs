namespace CustomTools.CustomPlayerPrefs
{
    using System.IO;
    using System.Linq;
    using UnityEngine;

    public static class PrefsManager
    {
        private const string _EXTENSION = ".json";
        private const string _FILE_NAME = "Preferences";
        private static readonly string _SavePath = Application.persistentDataPath;
        private static readonly string _FullPath = Path.Combine(_SavePath, string.Concat(_FILE_NAME, _EXTENSION));
        private static SerializedPrefs _Prefs;

        [RuntimeInitializeOnLoadMethod]
        private static void Start()
        {
            CheckIfFileExistCreateIfNot();
            _Prefs = LoadPrefsIfExists();
        }

        private static void CheckIfFileExistCreateIfNot()
        {
            if (!File.Exists(_FullPath))
            {
                File.WriteAllText(_FullPath, "");
            }
        }

        private static SerializedPrefs LoadPrefsIfExists()
        {
            SerializedPrefs prefs = Utility.ReadFromJson<SerializedPrefs>(_FullPath);
            if (prefs == null)
            {
                return new SerializedPrefs();
            }

            return prefs;
        }

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
                int index = _Prefs.StringPrefs.IndexOf()

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

        private static void Save()
        {
            Utility.SaveToJson(_Prefs, _FullPath);
        }
    }
}