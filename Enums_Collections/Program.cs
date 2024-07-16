namespace Enums_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Weapon pistol = new Weapon(BulletType.FullMetalJacket, 10);

                pistol.FillAll();

                pistol.PullTrigger();

                pistol.Fire();

                pistol.FillSingleBullet(BulletType.SoftPoint);

                pistol.PullTrigger();

                pistol.Fire();
                pistol.Fire();
                pistol.Fire();
                pistol.Fire();
                pistol.Fire();
                pistol.Fire();
                pistol.Fire();
                pistol.Fire();
                pistol.Fire();

                pistol.PullTrigger();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
