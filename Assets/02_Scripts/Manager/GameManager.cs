using System;
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
        SetData();
    }

    private void SetData()
    {
        // 플레이어 데이터
        data = ResourcesLoader.DataLoad<StatusData>(dataFile, DataType.Scriptable);
        character = new Character(data);

        // 인벤토리 데이터
        for (int i = 0; i < 8; i++)
        {
            ItemData data = ItemManager.Instance[i];
            character.AddItem(new Item(data));
        }
    }
}
