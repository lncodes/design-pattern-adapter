namespace Lncodes.DesignPattern.Adapter
{
    public sealed class NpcAdapterEnemy : Enemy
    {
        private readonly Npc _npc = default;

        public override uint TurnPoint { get => _npc.TurnPoint; protected set => _npc.TurnPoint = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="npc"></param>
        public NpcAdapterEnemy(Npc npc) =>
            _npc = npc;

        /// <inheritdoc cref="Enemy.Attack"/>
        public override void Attack() =>
            _npc.Attack();
    }
}