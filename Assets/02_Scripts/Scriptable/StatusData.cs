
using UnityEngine;

[CreateAssetMenu(fileName = "StatusData", menuName = "Scriptable/StatusData")]
public class StatusData : ScriptableObject
{
    public int damage;
    public int defense;
    public int hp;
    public int critical;
}