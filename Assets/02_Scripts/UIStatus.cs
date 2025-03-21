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
    [Header("Data")]
    [SerializeField] private TextMeshProUGUI[] dataText;

    public override void InitUI(UIManager manaer)
    {
        base.InitUI(manaer);
        backButton.onClick.AddListener(UIManager.Instance.MainUI.OpenMainMenu);
    }

    public void OnStatus()
    {
        rootTransform.SetActive(true);
        // 대충 스탯 출력해주기
    }
}
