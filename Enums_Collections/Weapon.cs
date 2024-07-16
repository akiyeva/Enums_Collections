using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Collections
{
    internal class Weapon
    {
        private static int _id = 1;
        public int Id { get; private set; }
        public List<Bullet> Bullets { get; set; }
        public BulletType BulletType { get; set; }
        public int Capacity { get; set; }
        public Weapon(BulletType bulletType, int capacity)
        {
            Bullets = new List<Bullet>();
            BulletType = bulletType;
            Capacity = capacity;
            Id = _id++;
        }
        public void Fire()
        {
            if (Bullets.Count > 0)
            {
                Bullet firedBullet = Bullets[0];
                Bullets.RemoveAt(0);

                Console.WriteLine($"Fired bullet type: {firedBullet.Type.ToString()}, {Bullets.Count} left.");
            }
            else
            {
                Console.WriteLine("Out of bullets!");
            }
        }
        public void FillAll()
        {
            if (Bullets.Count < Capacity)
            {
                for (int i = Bullets.Count; i < Capacity; i++)
                {
                    Bullets.Add(new Bullet(BulletType));
                }
                Console.WriteLine($"Weapon filled with {Capacity} {BulletType.ToString()} bullets.");
            }
            else
                Console.WriteLine("Weapon already filled to maximum capacity.");
        }
        public void FillSingleBullet(BulletType bulletType)
        {
            if (Bullets.Count < Capacity)
            {
                Bullets.Add(new Bullet(bulletType));
                Console.WriteLine($"Added 1 {bulletType.ToString()} bullet. Total: {Bullets.Count}");
            }

            else
                Console.WriteLine("Weapon already filled to maximum capacity.");
        }
            public void PullTrigger()
            {
                if (Bullets.Count > 0)
                {
                    Console.WriteLine($"Next bullet type: {Bullets[0].Type.ToString()}");
                }
                else
                {
                    Console.WriteLine("No bullets left to fire.");
                }
            }
        }
    }
