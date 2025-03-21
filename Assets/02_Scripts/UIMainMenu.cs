using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : BaseUI
{
    [Header("Button")]
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    [Header("Data UI")]
    [SerializeField] private TextMeshProUGUI[] dataText;
    [SerializeField] private Image expFill;
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

        SetData();
    }
    public void OpenStatus()
    {
        UIManager.Instance.StatusUI.OnStatus(true);
    }
    public void OpenInventory()
    {
        UIManager.Instance.InventoryUI.OnInventory(true);
    }

    private void SetData()
    {
        Character data = GameManager.Instance.character;

        dataText[(int)PlayerInfoType.Job].text = data.job;
        dataText[(int)PlayerInfoType.Name].text = data.name;
        dataText[(int)PlayerInfoType.Gold].text = data.gold.ToString();
        dataText[(int)PlayerInfoType.Level].text = $"Lv. {data.level}";
        dataText[(int)PlayerInfoType.Exp].text = $"{data.exp} / {data.maxExp}";

        expFill.fillAmount = (float)data.exp / (float)data.maxExp;
    }
}