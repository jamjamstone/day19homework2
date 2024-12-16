using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19homework2
{
    internal class Gun
    {
        public List<Projectile> _bullets;
        public List<Projectile> _grenades;
        public Dictionary<string, List<Projectile>> _container;
        public Gun()
        {
            _container=new Dictionary<string, List<Projectile>>();


            _bullets=new List<Projectile>();
            _grenades = new List<Projectile>();
            _container.Add("Bullet", _bullets);
            _container.Add("Grenade", _grenades);
        }

        public List<Projectile> ShowProjectile(string type)
        {
            return _container[type];
        }


       


    }//end
}
