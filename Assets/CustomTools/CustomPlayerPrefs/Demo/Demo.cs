using CustomTools.CustomPlayerPrefs.Scripts;
using UnityEngine;

public class Demo : MonoBehaviour
{
    [Header("String")]
    public string StringKey = "SomeName";

    public string StringValue;

    [Header("Integer")]
    public string IntegerKey = "SomeIndex";

    public int IntegerValue;

    [Header("Float")]
    public string FloatKey = "SomeFloat";

    public float FloatValue;

    [Header("Vector3")]
    public string Vector3Key = "SomeVector";

    public Vector3 Vector3Value;

    [Header("Quaternion")]
    public string QuaternionKey = "SomeQuaternion";

    public Quaternion QuaternionValue;

    public void SaveAll()
    {
        StringValue.SetStringPrefs(StringKey);
        IntegerValue.SetIntPrefs(IntegerKey);
        FloatValue.SetFloatPrefs(FloatKey);
        Vector3Value.SetVector3Prefs(Vector3Key);
        QuaternionValue.SetQuaternionPrefs(QuaternionKey);
    }

    public void LoadAll()
    {
        StringValue = StringKey.GetStringPrefs();
        IntegerValue = IntegerKey.GetIntPrefs();
        FloatValue = FloatKey.GetFloatPrefs();
        Vector3Value = Vector3Key.GetVector3Prefs();
        QuaternionValue = QuaternionKey.GetQuaternionPrefs();
    }
}