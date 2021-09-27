using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static int health;
        
        static void ShowHud()
        {
            Console.WriteLine("Health: " + health);

        }

        static void TakeDamage(int damage)
        {
            health = health - damage;

        }
        static void Main(string[] args)
        {
            health = 100;
            ShowHud();
            TakeDamage(25);
            ShowHud();
            TakeDamage(15);
            ShowHud();

            //methods 2
            Console.ReadKey(true);        
        }
    }
}
