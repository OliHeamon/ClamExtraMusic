using System;
using Terraria;
using Terraria.ModLoader;

namespace ClamExtraMusic.SceneEffects
{
    [Autoload(false)]
    public class BossMusicSceneEffect : ModSceneEffect
    {
        private readonly string musicName;

        private readonly int[] activeNpcIds;

        private readonly Func<bool> overrideMusic;

        public BossMusicSceneEffect(string musicName, Func<bool> overrideMusic, params int[] activeNpcIds)
        {
            this.musicName = musicName;
            this.overrideMusic = overrideMusic;
            this.activeNpcIds = activeNpcIds;
        }

        public override string Name => base.Name + $"/{musicName}";

        public override int Music => MusicLoader.GetMusicSlot(Mod, $"Assets/Music/{musicName}");

        public override bool IsSceneEffectActive(Player player)
        {
            if (!overrideMusic.Invoke())
            {
                return false;
            }

            for (int i = 0; i < activeNpcIds.Length; i++)
            {
                if (NPC.AnyNPCs(activeNpcIds[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    }
}
