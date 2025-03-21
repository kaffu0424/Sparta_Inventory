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
        // DataType�� �Ҵ������ʾ����� : ������ typeof(T).Name
        // DataType�� �Ҵ������� : ������ DataType.ToString();
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