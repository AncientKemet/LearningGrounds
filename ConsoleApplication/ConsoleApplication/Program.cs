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


            List<Item> Inventar = new List<Item>();
            Inventar.Add(longSword);
            Inventar.Add(longSword);
            Inventar.Add(longSword);
            Inventar.Add(dagger);


            int totalAd = 0;
            float totalAttackSpeed = 0;
            foreach (var item in Inventar)
            {
                totalAd = totalAd + item.AttackDamage;
                totalAttackSpeed = totalAttackSpeed + item.AttackSpeed;
            }

            Console.WriteLine("Total ad v inventari je : " + totalAd);
            Console.WriteLine("Total as v inventari je : " + totalAttackSpeed);
            Console.ReadKey();
        }

    }
}
