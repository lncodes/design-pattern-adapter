namespace Lncodes.DesignPattern.Adapter
{
    public sealed class OrcEnemy : Enemy
    {
        public override uint TurnPoint { get; protected set; } = 50;

        /// <inheritdoc cref="Enemy.Attack"/>
        public override void Attack() =>
            TurnPoint -= 2;
    }
}
