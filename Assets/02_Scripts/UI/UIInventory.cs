using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : BaseUI
{
    private Character character;

    [Header("Button")]
    [SerializeField] private Button backButton;

    [Header("Inventory UI")]
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform inventoryView;
    [SerializeField] private List<ItemSlot> slots;

    public override void InitUI(UIManager manaer)
    {
        base.InitUI(manaer);
        backButton.onClick.AddListener(UIManager.Instance.MainUI.OpenMainMenu);

        character = GameManager.Instance.character;
        character.inventoryUpdate = RefreshInventory;

        slots = new List<ItemSlot>();
        for(int i = 0; i < 20; i++)
        {
            ItemSlot slot = Instantiate(slotPrefab, inventoryView).GetComponent<ItemSlot>();
            slots.Add(slot);
        }
    }

    public void OnInventory(bool active)
    {
        rootTransform.SetActive(active);
        if (!active)
            return;

        RefreshInventory();
    }

    public void RefreshInventory()
    {
        for (int i = 0; i < character.inventory.Count; i++)
        {
            slots[i].SlotUpdate(character.inventory[i]);
        }
    }
}
