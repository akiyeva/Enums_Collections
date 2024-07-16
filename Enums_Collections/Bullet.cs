using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Collections
{
    internal class Bullet
    {
        private static int _id = 1;
        public int Id { get; private set; }
        public BulletType Type { get; set; }
        public Bullet(BulletType type)
        {
            Id = _id++;
            Type = type;
        }
    }
}
