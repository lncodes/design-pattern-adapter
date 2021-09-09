namespace Lncodes.DesignPattern.Adapter
{
    public sealed class GoblinEnemy : Enemy
    {
        public override uint TurnPoint { get; protected set; } = 100;

        /// <inheritdoc cref="Enemy.Attack"/>
        public override void Attack() =>
            TurnPoint--;
    }
}
