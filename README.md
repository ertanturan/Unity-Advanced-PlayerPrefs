# Unity-Advanced-PlayerPrefs
This system is an alternative to Unity's Playerprefs which limits save files up to 1MB and only works in admin users. Also can only support float,string and integer.

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
