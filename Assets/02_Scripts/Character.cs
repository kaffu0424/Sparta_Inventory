using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string job { get; private set; }
    public string name { get; private set; }
    public int gold { get; private set; }
    public int level { get; private set; }
    public int exp { get; private set; }
    public int maxExp { get; private set; }
}
