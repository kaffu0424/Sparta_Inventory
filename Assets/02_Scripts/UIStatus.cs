using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIStatus : BaseUI
{
    [Header("Button")]
    [SerializeField] private Button backButton;

    [Header("Data UI")]
    [SerializeField] private TextMeshProUGUI[] dataText;
    public override void InitUI(UIManager manaer)
    {
        base.InitUI(manaer);
        backButton.onClick.AddListener(UIManager.Instance.MainUI.OpenMainMenu);
    }

    public void OnStatus(bool active)
    {
        rootTransform.SetActive(active);

        // Status UI OFF
        if (!active)
            return;

        SetData();
    }

    private void SetData()
    {
        // status set
        Character data = GameManager.Instance.character;

        dataText[(int)StatusType.Damage].text = data.damage.ToString();
        dataText[(int)StatusType.Defense].text = data.defense.ToString();
        dataText[(int)StatusType.Hp].text = data.hp.ToString();
        dataText[(int)StatusType.Critical].text = data.critical.ToString();
    }
}
