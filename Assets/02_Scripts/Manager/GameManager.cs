using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private const string dataFile = "DefaultData";

    public Character character { get; private set; }
    private StatusData data;
    protected override void InitManager()
    {
        data = ResourcesLoader.DataLoad<StatusData>(dataFile, DataType.Scriptable);
        character = new Character(data);

        SetData();
    }

    private void SetData()
    {
        
    }
}
