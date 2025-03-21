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

    }
}
