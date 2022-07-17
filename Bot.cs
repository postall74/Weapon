namespace Weapon
{
    public class Bot
    {
        private readonly Weapon Weapon;

        public void OnSeePlayer(Player player)
        {
             player.TakeDamage(Weapon.Fire());
        }
    }
}
