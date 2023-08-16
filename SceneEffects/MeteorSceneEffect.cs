using ClamExtraMusic.Configs;
using Terraria;
using Terraria.ModLoader;

namespace ClamExtraMusic.SceneEffects
{
    public class MeteorSceneEffect : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/ViolenceOfSpace");

        public override bool IsSceneEffectActive(Player player) => ModContent.GetInstance<PriorityConfig>().OverrideMeteor && player.ZoneMeteor;

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    }
}
