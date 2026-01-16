using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Roman
{
    internal class Program
    {
        static bool _isPlaying = true;
        static Random _rand = new Random();
        static Character duelist1 = DuelistsSelection(_rand.Next(0, 3));
        static Character duelist2 = DuelistsSelection(_rand.Next(0, 3));

        static void Main(string[] args)
        {
            while(duelist2 == duelist1)
            {
                duelist2 = DuelistsSelection(_rand.Next(0, 3));
            }

            while (_isPlaying)
            {
                duelist1.turnsToAct++;
                duelist2.turnsToAct++;

                if (duelist1.Health <= 0 || duelist2.Health <= 0)
                {
                    _isPlaying = false;
                    Endgame();
                    break;
                }

                

                Draw();

                

                if (duelist1.turnsToAct >= duelist1.Speed)
                {
                    duelist1.Attack(duelist2);
                }

                if (duelist2.turnsToAct >= duelist2.Speed)
                {
                    duelist2.Attack(duelist1);
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue to the next turn...");
                Console.ReadKey(true);
            }
        }

        static void Draw()
        {
            Console.Clear();
            Console.WriteLine("*--------------------Fantasy Duel--------------------*");
            Console.WriteLine();
            Console.WriteLine($"{duelist1.Name}                     {duelist2.Name}");
            Console.WriteLine($"Health: {duelist1.Health}                              Health: {duelist2.Health}");
            Console.WriteLine($"Attack Range: {duelist1.AttackPowerMin}-{duelist1.AttackPowerMax}                     Attack Range: {duelist2.AttackPowerMin}-{duelist2.AttackPowerMax}");
            Console.WriteLine($"Speed: {duelist1.Speed} (Turns: {duelist1.turnsToAct})                   Speed: {duelist2.Speed} (Turns: {duelist2.turnsToAct})");
            Console.WriteLine();
        }

        static Character DuelistsSelection(int rand)
        {
            if (rand == 0)
            {
                Archer archer = new Archer(health: 75, name: "Legolas the Archer", atkMin: 20, atkMax: 26, speed: 4);
                return archer;
            }
            else if (rand == 1)
            {
                Orc orc = new Orc(health: 100, name: "Thrall the Orc", atkMin: 30, atkMax: 51, speed: 5);
                return orc;
            }
            else if (rand == 2)
            {
                Wizard wizard = new Wizard(health: 80, name: "Kael'thas the Wizard", atkMin: 15, atkMax: 61, speed: 3);
                return wizard;
            }
            else
            {
                return null;
            }
        }

        static void Endgame()
        {
            Console.Clear();
            Console.WriteLine("*--------------------Game Over--------------------*");
            Console.WriteLine();
            if (duelist1.Health <= 0 && duelist2.Health <= 0)
            {
                Console.WriteLine("It's a draw! Both duelists have fallen.");
            }
            else if (duelist1.Health <= 0)
            {
                Console.WriteLine($"{duelist2.Name} is victorious!");
            }
            else if (duelist2.Health <= 0)
            {
                Console.WriteLine($"{duelist1.Name} is victorious!");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);


        }
    }
}

