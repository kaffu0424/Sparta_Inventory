using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : BaseUI
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    public override void InitUI(UIManager manaer)
    {
        base.InitUI(manaer);

        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.StatusUI.OnStatus(false);
        UIManager.Instance.InventoryUI.OnInventory(false);
    }
    public void OpenStatus()
    {
        UIManager.Instance.StatusUI.OnStatus(true);
    }
    public void OpenInventory()
    {
        UIManager.Instance.InventoryUI.OnInventory(true);
    }
}