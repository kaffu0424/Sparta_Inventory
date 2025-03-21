
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Scriptable/ItemData")]
public class ItemData : ScriptableObject
{
    public Sprite itemSprite;
    public StatusType statusType;
    public int value;
}