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
    [SerializeField] private ItemSlot[] slots;

    public override void InitUI(UIManager manaer)
    {
        base.InitUI(manaer);
        backButton.onClick.AddListener(UIManager.Instance.MainUI.OpenMainMenu);

        character = GameManager.Instance.character;
        character.inventoryUpdate = RefreshInventory;

        slots = new ItemSlot[20];
        for(int i = 0; i < slots.Length; i++)
        {
            Instantiate(slotPrefab, inventoryView);
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
        for (int i = 0; i < slots.Length; i++)
        {

        }
    }
}
