namespace Weapon
{
    public class Weapon
    {
        public int Damage { get; private set; }
        public int Bullets { get; private set; }

        public int Fire()
        {
            Bullets--;
            return Damage;
        }
    }
}