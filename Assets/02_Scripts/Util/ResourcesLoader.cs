using UnityEngine;

public enum DataType
{
    NULL,
    Scriptable,
    GameObject,     // prefab
}

public static class ResourcesLoader
{
    public static T DataLoad<T>(string fileName, DataType type = DataType.NULL) where T : UnityEngine.Object
    {
        // DataType을 할당하지않았을때 : 폴더명 typeof(T).Name
        // DataType을 할당했을때 : 폴더명 DataType.ToString();
        string folderName = type == DataType.NULL 
            ? $"{typeof(T).Name}" : type.ToString();

        string path = $"{folderName}/{fileName}";
        T data = Resources.Load<T>(path);

        if(data == null)
        {
            Debug.LogWarning($"[ResourcesLoader] {path} Error");
        }

        return data;
    }
}