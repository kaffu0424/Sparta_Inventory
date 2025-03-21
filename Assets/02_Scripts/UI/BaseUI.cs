using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUI : MonoBehaviour
{
    protected UIManager manager;
    [SerializeField] protected Transform rootTransform;

    public virtual void InitUI(UIManager manaer)
    {
        this.manager = manaer;
    }
}
