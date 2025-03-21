using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private UIMainMenu     mainUI;
    [SerializeField] private UIStatus       statusUI;
    [SerializeField] private UIInventory    inventoryUI;

    // get / set
    public UIMainMenu MainUI => mainUI;
    public UIStatus StatusUI => statusUI;
    public UIInventory InventoryUI => inventoryUI;
    protected override void InitManager()
    {
        // Ä³½Ì
        mainUI = FindFirstObjectByType<UIMainMenu>();
        statusUI = FindFirstObjectByType<UIStatus>();
        inventoryUI = FindFirstObjectByType<UIInventory>();

        mainUI?.InitUI(this);
        statusUI?.InitUI(this);
        inventoryUI?.InitUI(this);
    }
}
