using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image itemImage;
    [SerializeField] private GameObject equipImage;

    private Item item;

    public void SlotUpdate(Item item)
    {
        this.item = item;

        // 아이템 이미지
        itemImage.sprite = item.data.itemSprite;

        // 아이템 착용 표시
        equipImage.SetActive(item.isEquip);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // 착용 상태
        item.isEquip = !item.isEquip;

        // 아이템 착용 표시
        equipImage.SetActive(item.isEquip);
    }
}
