namespace Weapon
{
    public class Player
    {
        private int _health;

        public int Health => _health;

        public int TakeDamage(int damage)
        {
            return _health -= damage;
        }
    }
}
