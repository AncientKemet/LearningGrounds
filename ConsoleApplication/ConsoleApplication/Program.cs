using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Item longSword = new Item();
            longSword.AttackDamage = 10;

            Item dagger = new Item();
            dagger.AttackSpeed = 0.15f;

            Item rabadon = new Item(); 
       
            rabadon.AbilityPower = 120;

            Item voidstaf = new Item();
            voidstaf.AbilityPower = 80;
            Item mobility = new Item();
            mobility.MovementSpeed= 25;

            List<Item> Inventar = new List<Item>();
            Inventar.Add(longSword);
            Inventar.Add(longSword);
            Inventar.Add(longSword);
            Inventar.Add(dagger);
            Inventar.Add(rabadon);
            Inventar.Add(voidstaf);
            Inventar.Add(mobility);
            int totalAd = 0;
            int totalap = 0;
            int totalms = 0;
            float totalAttackSpeed = 0;
            foreach (var item in Inventar)
            {
                totalap = totalap + item.AbilityPower;
                totalAd = totalAd + item.AttackDamage;
                totalAttackSpeed = totalAttackSpeed + item.AttackSpeed;
                totalms = totalms + item.MovementSpeed;

            }
            Console.WriteLine("Total ap v inventari je : " + totalap);
            Console.WriteLine("Total ad v inventari je : " + totalAd);
            Console.WriteLine("Total as v inventari je : " + totalAttackSpeed);
            Console.WriteLine("Total ms v inventari je : " + totalms);
            Console.ReadKey();
        }

    }
}
