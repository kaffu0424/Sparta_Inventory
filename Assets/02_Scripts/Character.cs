public class Character
{
    // ĳ���� ����
    public string job { get; private set; }
    public string name { get; private set; }
    public int gold { get; private set; }
    public int level { get; private set; }
    public int exp { get; private set; }
    public int maxExp { get; private set; }
    
    // ĳ���� ����
    public int damage { get; private set; }
    public int defense { get; private set; }
    public int hp { get; private set; }
    public int critical { get; private set; }

    public Character(StatusData data)
    {
        damage = data.damage;
        defense = data.defense;
        hp = data.hp;
        critical = data.critical;
    }
}
