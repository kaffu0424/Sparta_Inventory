using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    private UIMainMenu     mainUI;
    private UIStatus       statusUI;
    private UIInventory    inventoryUI;

    // get / set
    public UIMainMenu MainUI => mainUI;
    public UIStatus StatusUI => statusUI;
    public UIInventory InventoryUI => inventoryUI;
    protected override void InitManager()
    {
        // 캐싱
        mainUI = FindFirstObjectByType<UIMainMenu>();
        statusUI = FindFirstObjectByType<UIStatus>();
        inventoryUI = FindFirstObjectByType<UIInventory>();

        // 초기화
        mainUI?.InitUI(this);
        statusUI?.InitUI(this);
        inventoryUI?.InitUI(this);

        // 초기설정?
        mainUI?.OpenMainMenu();
    }
}
