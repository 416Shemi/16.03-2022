using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    class Veapon
    {



        public int BulledCapacity;
        public int NumberBulletsin;
        public int SecondsCombing;
        public string AtisMode;
        public Veapon(int BulledCapacity, int NumberBulletsin, int SecondsCombing, string AtisMode)
        {
            this.BulledCapacity = BulledCapacity;
            this.NumberBulletsin = NumberBulletsin;
            this.SecondsCombing = SecondsCombing;
            this.AtisMode = AtisMode;
        }
        public void Shoot(int numberBulletsin)
        {
            if (numberBulletsin > 0)
            {
                numberBulletsin--;
                Console.WriteLine("A projectile was fired");
            }
            else
            {
                Console.WriteLine("There are no shells");
            }
        }
        public int Fire(int numberBulletsin)
        {
            while (NumberBulletsin <= 0)
            {
                int cont;
                if (numberBulletsin == 0)
                {
                    cont = SecondsCombing;
                }

            }
            return 0;

        }
        public void GetRemainBulletCount()
        {

            if (NumberBulletsin < BulledCapacity)
            {
                Console.WriteLine(BulledCapacity - NumberBulletsin);

            }
            else
            {
                Console.WriteLine("The comb is full");
            }

        }
        public void Reload()
        {
            if (NumberBulletsin < BulledCapacity)
            {

                NumberBulletsin = BulledCapacity;
                Console.WriteLine("The comb is filled");
            }

            else
            {
                Console.WriteLine("The comb is filled");
            }

        }
        public void ChangeFireMode()
        {
            if (AtisMode == "true")
            {
                Console.WriteLine("Shooting mode is single");
            }
            else if (AtisMode == "false")
            {
                Console.WriteLine("Shooting mode is automatic");
            }
        }
    }
}
