# Unity-Advanced-PlayerPrefs
This system is an alternative to Unity's Playerprefs which limits save files up to 1MB.And limited to only float,string and integer types.
<br> But this system not only supports float,string and int also supports vector3 and quaternion, not limited to 1MB and works on all user privileges.


# Why JSON-based playerprefs over Unity's Built-in Prefs ?

1. Size: JSON supports larger data sizes, up to 1GB compared to Unity's PlayerPrefs limit of 1MB. You can further increase the limit by disabling pretty print in JSON.
2. Versatility: JSON's universality means it can be used anywhere that supports it. Plus, you can encrypt JSON data for security.
3. Backwards Compatibility: Initializing your data in JSON can help maintain backwards compatibility, preventing disruptions to your development plans and ensuring a comfortable user experience.
4. Data Structure: JSON supports complex data types, unlike PlayerPrefs which only supports integers, floats, and strings.
5. Readability: JSON's human-readable format aids in debugging and inspecting data.
6. Portability: JSON files can be easily moved and loaded, making data sharing simpler.
7. Scalability: JSON can be more efficient than PlayerPrefs when dealing with large data sets.
8. Error Handling: JSON provides detailed error information, offering superior debugging over PlayerPrefs.
9. Versioning: JSON supports version information, making it easier to manage changes in data structure.

## Features
Save and Load types by a key value ; float, string, int, Vector3 and Quaternion by key.

### 1. `string` Save and Load
```csharp
        string someString = "Hey there I want to be saved !";
        string key = "KeyValueForString";

        someString.SetStringPrefs(key);//saved

        string loadedString = key.GetStringPrefs(); // this line will load => "Hey there I want to be saved !"
```

### 2. `float` Save and Load

```csharp
        float someFloat = 0.254789f;
        string key = "KeyValueForFloat";
        
        someFloat.SetFloatPrefs(key);//saved

        float loadedFloat = key.GetFloatPrefs(); // this line will load =>  0.254789f

```

### 3. `int` Save and Load

```csharp
        int someInt =564894;
        string key = "KeyValueForInt";
        
        someInt.SetIntPrefs(key);//saved

        int loadedInt = key.GetIntPrefs(); // this line will load => 564894

```
### 4. `Vector3` Save and Load

```csharp
        string key = "KeyValueForVector3";
        
        transform.position.SetVector3Prefs(key);//saved

        Vector3 loadedVector = key.GetVector3Prefs(); // this line will load => position vector
```

### 5. `Quaternion` Save and Load
```csharp
        string key = "KeyValueForQuaternion";
        
        transform.rotation.SetQuaternionPrefs(key);//saved

        Quaternion loadedQuaternion = key.GetQuaternionPrefs(); // this line will load => rotation quaternion
```
### Get all Current Prefs

![All Prefs](https://user-images.githubusercontent.com/23081722/170513409-5f64bada-4c32-4dfb-b402-c9a5bc46c9e5.png)

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.


# ENJOY !
