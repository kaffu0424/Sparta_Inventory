using System;
using System.Collections.Generic;

public class Character
{
    // 캐릭터 정보
    public string job { get; private set; }
    public string name { get; private set; }
    public int gold { get; private set; }
    public int level { get; private set; }
    public int exp { get; private set; }
    public int maxExp { get; private set; }

    // 캐릭터 스탯
    public int damage { get; private set; }
    public int defense { get; private set; }
    public int hp { get; private set; }
    public int critical { get; private set; }

    public List<Item> inventory { get; private set; }
    public Action inventoryUpdate;

    public Character(StatusData data)
    {
        // information
        job = "코딩노예";
        name = "Coding Slave";
        gold = 50000;
        level = 1;
        exp = 0;
        maxExp = 10;

        // status
        damage = data.damage;
        defense = data.defense;
        hp = data.hp;
        critical = data.critical;

        // inventory
        inventory = new List<Item>();
    }

    public void AddItem()
    {

    }

    public void Equip()
    {

    }

    public void UnEquip()
    {

    }
}
