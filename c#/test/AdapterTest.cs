using Xunit;

namespace Lncodes.DesignPattern.Adapter.Test
{
    public sealed class AdapterTest
    {
        [Fact]
        public void Attack_NpcSkillPoint_ShouldZero()
        {
            var originalNpc = new Npc();
            
            var npcAdapter = new NpcAdapterEnemy(originalNpc);
            npcAdapter.Attack();
            
            var actual = npcAdapter.TurnPoint;
            Assert.Equal(default, actual);
        }
    }
}
