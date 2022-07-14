using Terraria;
using Terraria.ModLoader;

namespace ClamExtraMusic
{
    [Autoload(false)]
    public class BossMusicSceneEffect : ModSceneEffect
    {
        private readonly string musicName;

        private readonly int[] activeNpcIds;

        public BossMusicSceneEffect(string musicName, params int[] activeNpcIds)
        {
            this.musicName = musicName;
            this.activeNpcIds = activeNpcIds;
        }

        public override string Name => base.Name + $"/{musicName}";

        public override int Music => MusicLoader.GetMusicSlot(Mod, $"Assets/Music/{musicName}");

        public override bool IsSceneEffectActive(Player player)
        {
            for (int i = 0; i < activeNpcIds.Length; i++)
            {
                return NPC.AnyNPCs(activeNpcIds[i]);
            }

            return false;
        }

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    }
}
