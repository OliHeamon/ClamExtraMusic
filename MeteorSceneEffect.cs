using Terraria;
using Terraria.ModLoader;

namespace ClamExtraMusic
{
    public class MeteorSceneEffect : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/ViolenceOfSpace");

        public override bool IsSceneEffectActive(Player player) => player.ZoneMeteor;

        public override SceneEffectPriority Priority => ModContent.GetInstance<PriorityConfig>().BiomeScenePriority;
    }
}
