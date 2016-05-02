using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {

        private static List<Item> Inventar;

        private static Item LongSword = new Item() { AttackDamage = 10 };
        private static Item BFSword = new Item() { AttackDamage = 50 };
        private static Item Dagger = new Item() { AttackSpeed = .15f };
        private static Item Rabadon = new Item() { AbilityPower = 120 };
        private static Item VoidStaff = new Item() { AbilityPower = 80 };
        private static Item BootsOfMobility = new Item() { MovementSpeed = 25 };
        private static Item Zeal = new Item() { MovementSpeed = 5, AttackSpeed = .20f, CriticalChance = .15f };
        private static Item SunfireCape = new Item() { Armor = 50, HealthPoints = 500};

        static void Main(string[] args)
        {
            VyplnInventar();

            SpocitajAVypisTotal();
        }

        private static void VytvorItemy()
        {
            Item dagger = new Item();
            dagger.AttackSpeed = 0.15f;

            Item rabadon = new Item();
            rabadon.AbilityPower = 120;

            Item voidstaf = new Item();
            voidstaf.AbilityPower = 80;

            Item mobility = new Item();
            mobility.MovementSpeed = 25;
        }

        private static void VyplnInventar()
        {
            Inventar = new List<Item>();
            Inventar.Add(LongSword);
            Inventar.Add(LongSword);
            Inventar.Add(LongSword);
            Inventar.Add(Dagger);
            Inventar.Add(Zeal);
            Inventar.Add(Zeal);
            Inventar.Add(BFSword);
            Inventar.Add(SunfireCape);
            Inventar.Add(SunfireCape);
            Inventar.Add(SunfireCape);
            Inventar.Add(SunfireCape);
            Inventar.Add(SunfireCape);
        }

        private static void SpocitajAVypisTotal()
        {
            int totalAD = 50;
            int totalHP = 516;
            int totalARM = 24;
            int totalAP = 0;
            int totalMS = 325;
            float totalAS = 0.69f;
            float totalCC = 0;

            foreach (var item in Inventar)
            {
                totalAP = totalAP + item.AbilityPower;
                totalAD = totalAD + item.AttackDamage;
                totalAS = totalAS + item.AttackSpeed;
                totalMS = totalMS + item.MovementSpeed;
                totalCC = totalCC + item.CriticalChance;

                totalHP = totalHP + item.HealthPoints;
                totalARM = totalARM + item.Armor;
            }

            float AA_DPS = totalAD * totalAS * (1.0f + totalCC);
            float TimeToKillMyself = (totalHP * (1.0f + (float)totalARM/100f)) / AA_DPS;

            Console.WriteLine("Total hp v inventari je : " + totalHP);
            Console.WriteLine("Total arm v inventari je : " + totalARM);
            Console.WriteLine("Total ap v inventari je : " + totalAP);
            Console.WriteLine("Total ad v inventari je : " + totalAD);
            Console.WriteLine("Total as v inventari je : " + totalAS);
            Console.WriteLine("Total ms v inventari je : " + totalMS);
            Console.WriteLine("Total cc v inventari je : " + totalCC);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Autoattack DPS : " + AA_DPS);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("na zabite sameho seba len AA : " + TimeToKillMyself +"sec.");

            Console.ReadKey();
        }
    }
}
