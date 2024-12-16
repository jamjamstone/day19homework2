namespace day19homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            Bullet bullet1 = new Bullet();
            Bullet bullet2 = new Bullet();
            Grenade grenade1 = new Grenade();
            Grenade grenade2 = new Grenade();
            bullet1._damage = 1;
            bullet2._damage = 2;
            grenade1._damage = 3;
            grenade2._damage = 4;
            gun._grenades.Add(grenade1);
            gun._grenades.Add(grenade2);
            gun._bullets.Add(bullet1);
            gun._bullets.Add(bullet2);
            for (int i = 0; i < gun._container.Count; i++)
            {
                Console.WriteLine((gun.ShowProjectile("Bullet")[i] as Bullet)._damage);
                Console.WriteLine((gun.ShowProjectile("Grenade")[i]as Grenade)._damage);
            }


        }
    }
}
