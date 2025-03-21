using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : BaseUI
{
    private const string slotPrefabFile = "InventorySlot";

    [SerializeField] private Button backButton;
    private GameObject slotPrefab;
    public override void InitUI(UIManager manaer)
    {
        base.InitUI(manaer);
        backButton.onClick.AddListener(UIManager.Instance.MainUI.OpenMainMenu);
        slotPrefab = ResourcesLoader.DataLoad<GameObject>(slotPrefabFile, DataType.Prefab);

    }

    public void OnInventory(bool active)
    {
        if (!active)
        {
            rootTransform.SetActive(active);
            return;
        }

        // 스탯 출력
    }
}
