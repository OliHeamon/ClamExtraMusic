using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClamExtraMusic
{
    public class WallOfFleshSceneEffect : ModSceneEffect
    {
        private const int musicDistance = 4800; // 300 tiles.

        public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/PurgatorysAssault");

        public override bool IsSceneEffectActive(Player player)
        {
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
