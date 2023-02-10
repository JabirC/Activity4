using System;

namespace RPG
{

    interface ICharacter {

        int HitPoints { get; set; }
        int Damage { get; set; }
        string CharName { get; }
        bool IsAlive { get; set; }

        string this[int index] { get; set; }
        void PrintCharInfo();
    }

    class Mage : ICharacter
    {
        private string charname;
        private int damage;
        private int hitpoints;
        private bool alive = true;
        private string[] storage = new string[8];

        public Mage(string name, int dmg, int hp)
        {
            charname = name;
            damage = dmg;
            hitpoints = hp;
        }

        public string CharName
        {
            get { return charname; }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int HitPoints
        {
            get { return hitpoints; }
            set { hitpoints = value; }
        }

        public bool IsAlive
        {
            get { return alive; }
            set { alive = value; }
        }

        public void PrintCharInfo()
        {
            Console.WriteLine("Character Name: " + charname);
            Console.WriteLine("HP: " + hitpoints);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Status: " + (alive ? "alive":"dead"));
            Console.WriteLine("Inventory:");
            foreach(string item in storage){
                Console.WriteLine(" -- " + item);
            }
        }

        public string this[int index]
        {
            get { return storage[index]; }
            set { storage[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mage mycharacter = new Mage("Dumbledore", 1000, 10000);
            mycharacter[0] = "health potion";
            mycharacter[1] = "mana potion";
            mycharacter[2] = "revival stone";
            mycharacter.PrintCharInfo();
        }
    }
}

