using ClamExtraMusic.Configs;
using Terraria;
using Terraria.ModLoader;

namespace ClamExtraMusic.SceneEffects
{
    public class BlizzardSceneEffect : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/ColdFront");

        public override bool IsSceneEffectActive(Player player) => ModContent.GetInstance<PriorityConfig>().OverrideBlizzard &&
            Main.raining && player.ZoneSnow && !player.ZoneRockLayerHeight;

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    }
}
