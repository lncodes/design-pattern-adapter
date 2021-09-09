namespace Lncodes.DesignPattern.Adapter
{
    public abstract class Enemy
    {
        public abstract uint TurnPoint { get; protected set; }
        
        /// <summary>
        /// Method to do an attack
        /// </summary>
        public abstract void Attack();
    }
}