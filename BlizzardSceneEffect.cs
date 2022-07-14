using Terraria;
using Terraria.ModLoader;

namespace ClamExtraMusic
{
    public class BlizzardSceneEffect : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/ColdFront");

        public override bool IsSceneEffectActive(Player player) => Main.raining && player.ZoneSnow && !player.ZoneRockLayerHeight;

        public override SceneEffectPriority Priority => SceneEffectPriority.Event;
    }
}
