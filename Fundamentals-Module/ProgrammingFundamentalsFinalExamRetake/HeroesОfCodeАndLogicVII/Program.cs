using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesОfCodeАndLogicVII
{
    public class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public Hero(string name,int hitPoints,int manaPoints)
        {
            Name = name;
            HP = hitPoints;
                MP = manaPoints;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroesList = new List<Hero>(); 
            int n =int.Parse( Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] heroData=Console.ReadLine().Split(' ');
                string name=heroData[0];
                int hp=int.Parse(heroData[1]);
                int mp=int.Parse(heroData[2]);
                Hero hero = new Hero(name, hp, mp);
                heroesList.Add(hero);
            }
            
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] actionData=command.Split(" - ");
                string actionPerformed=actionData[0];
                
                if(actionPerformed== "CastSpell")
                {
                    string heroName=actionData[1];
                    int mpNeeded=int.Parse(actionData[2]);
                    string spellName=actionData[3];
                    foreach (var hero in heroesList)
                    {
                        if (heroName == hero.Name)
                        {
                            if (mpNeeded > hero.MP)
                            {
                                Console.WriteLine($"{hero.Name} does not have enough MP to cast {spellName}!");
                            }
                            else
                            {
                                hero.MP -= mpNeeded;
                                Console.WriteLine($"{hero.Name} has successfully cast {spellName} and now has {hero.MP} MP!");
                            }
                            break;
                        }
                        
                    }
                }
                else if(actionPerformed== "TakeDamage")
                {
                    string heroName= actionData[1];
                    int damage=int.Parse(actionData[2]);
                    string attacker=actionData[3];
                    foreach (var hero in heroesList)
                    {
                        if (heroName == hero.Name)
                        {
                            hero.HP -= damage;
                            if(hero.HP > 0)
                            {
                                Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.HP} HP left!");
                            }
                            else
                            {
                                Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
                                heroesList.Remove(hero);
                            }
                            break;
                        }
                    }
                }
                else if(actionPerformed== "Recharge")
                {
                    string heroName=actionData[1];
                    int amount=int.Parse(actionData[2]);
                    foreach (var hero in heroesList)
                    {
                        if (heroName == hero.Name)
                        {
                            hero.MP += amount;
                            if(hero.MP > 200)
                            {
                                int excessiveAmount = hero.MP - 200;
                                amount-=excessiveAmount;
                                hero.MP = 200;
                            }
                            //tuk moje da ima greshka zashtoto ne znam dali ako nadvishi 200 se broi mp-to otgore
                            Console.WriteLine($"{hero.Name} recharged for {amount} MP!");
                            break;
                        }
                    }
                }
                else if(actionPerformed== "Heal")
                {
                    string heroName = actionData[1];
                    int amount=int.Parse(actionData[2]);
                    foreach (var hero in heroesList)
                    {
                        if (heroName == hero.Name)
                        {
                            hero.HP += amount;
                            if(hero.HP > 100)
                            {
                                int excessiveAmount=hero.HP - 100; 
                                amount-=excessiveAmount;
                                hero.HP = 100;
                            }
                            //tuk pak moje da izleze greshka
                            Console.WriteLine($"{hero.Name} healed for {amount} HP!");
                            break;
                        }
                    }
                }
            }
            List<Hero> sortedHeroesHpDesc = heroesList.OrderByDescending(hero => hero.HP).ToList();
            foreach (var hero in sortedHeroesHpDesc)
            {
                Console.WriteLine(@$"{hero.Name}
  HP: {hero.HP}
  MP: {hero.MP}");
            }
        }
    }
}
