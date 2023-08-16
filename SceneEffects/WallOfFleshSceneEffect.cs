using ClamExtraMusic.Configs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClamExtraMusic.SceneEffects
{
    public class WallOfFleshSceneEffect : ModSceneEffect
    {
        private const int musicDistance = 5000; // Distance vanilla uses for this boss.

        public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/PurgatorysAssault");

        public override bool IsSceneEffectActive(Player player)
        {
            if (!ModContent.GetInstance<PriorityConfig>().OverrideWallOfFlesh)
            {
                return false;
            }

            if (!NPC.AnyNPCs(NPCID.WallofFlesh))
            {
                return false;
            }

            NPC wallOfFlesh = Main.npc[NPC.FindFirstNPC(NPCID.WallofFlesh)];

            return wallOfFlesh.DistanceSQ(player.Center) < musicDistance * musicDistance;
        }

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    }
}
