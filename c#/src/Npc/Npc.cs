namespace Lncodes.DesignPattern.Adapter
{
    public sealed class Npc
    {
        public uint TurnPoint { get; set; } = 10;

        /// <summary>
        /// Method to npc attack
        /// </summary>
        public void Attack() =>
            TurnPoint -= 10;

        /// <summary>
        /// Method to npc follow player
        /// </summary>
        public void FollowPlayer() =>
            TurnPoint--;
    }
}