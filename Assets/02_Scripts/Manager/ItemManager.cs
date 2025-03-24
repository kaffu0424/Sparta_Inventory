using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : Singleton<ItemManager>
{
    [SerializeField] private List<ItemData> data;

    public ItemData this[int index]
    {
        get 
        {
            if (data == null)
                return null;

            if(index < 0 || index >= data.Count)
                return null;

            return data[index]; 
        }
    }
    protected override void InitManager()
    {
        // --
    }
}
