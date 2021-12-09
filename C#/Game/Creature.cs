namespace Creature
{
    public abstract class Creature
    {
        public string name;
        private protected int health;
        private protected int mana;
        private protected int damage;
        private byte level;
        private int gold;

        public Creature(string name, int basehealth, int basemana, int damage, byte level, int gold)
        {
            this.name = name;
            this.level = level;
            this.health = basehealth * level;
            this.mana = basemana * level;
            this.damage = damage;
            this.gold = gold;
        }

        public byte Level
        {
            get { return level; }
            set { level = value; }
        }
        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }
        public abstract int Health { get; set; }
        public abstract int Mana { get; set; }
        public abstract void Talk(string words);
    }

    class Player : Creature
    {
        private int exp;
        public string special;
        public Player(string name, int basehealth, int basemana, int damage, byte level, int gold, string special, int exp)
            : base(name, basehealth, basemana, damage, level, gold)
        {
            this.special = special;
            this.exp = exp;
        }

        // Планируется своя логика получения/уменьшения здоровья и маны за счет уровня сложности (не реализовано)
        public override int Health
        {
            get { return health; }
            set { health = value; }
        }
        public override int Mana
        {
            get { return mana; }
            set { mana = value; }
        }
        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        public override void Talk(string words)
        {
            Console.WriteLine($"{this.name} say: {words}");
        }
    }

    class Enemy : Creature
    {
        public string type;
        public Enemy (string name, int basehealth, int basemana, int damage, byte level, int gold, string type)
            : base(name, basehealth, basemana, damage, level, gold)
        {
            this.type = type;
        }

        // Планируется своя логика получения/уменьшения здоровья и маны за счет уровня сложности (не реализовано)
        public override int Health 
        { 
            get { return health; }
            set { health = value; }
        }
        public override int Mana 
        {
            get { return health; }
            set { health = value; }
        }

        public override void Talk(string words)
        {
            Console.WriteLine($"{this.name} say: {words}");
        }
    }
}