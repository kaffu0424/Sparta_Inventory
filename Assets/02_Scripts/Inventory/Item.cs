using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public bool isEquip;
    public ItemData data;

    public Item(ItemData data)
    {
        isEquip = false;
        this.data = data;
    }
}
