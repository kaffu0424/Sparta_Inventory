using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private GameObject equipImage;

    public void SlotUpdate(Item item)
    {
        // 아이템 이미지
        itemImage.sprite = item.data.itemSprite;

        // 아이템 착용 표시
        equipImage.SetActive(item.isEquip);
    }
}
