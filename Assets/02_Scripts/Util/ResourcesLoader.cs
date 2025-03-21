using UnityEngine;

public enum DataType
{
    NULL,
    Scriptable,

    /* enum 값 필요하면 추가해주세요.
     * ex )
     * Prefab을 저장해둔 폴더명이 "Prefab" 일때
     * DataType에 "Prefab" 추가해주세요.
     * Prefab의 타입은 GameObject입니다.
     * 추가하지않고 호출하면 GameObject/[파일명] 의 파일을 찾아옵니다.
     */
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