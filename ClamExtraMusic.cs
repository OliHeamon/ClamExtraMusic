using Terraria.ID;
using Terraria.ModLoader;

namespace ClamExtraMusic
{
	public class ClamExtraMusic : Mod
	{
        public override void Load()
        {
            AddContent(new BossMusicSceneEffect("BreakingTheSeal", NPCID.CultistBoss));
            AddContent(new BossMusicSceneEffect("CrimsonCortex", NPCID.BrainofCthulhu));
            AddContent(new BossMusicSceneEffect("CurseOfTheDungeon", NPCID.SkeletronHead));
            AddContent(new BossMusicSceneEffect("EvilEarthquake", NPCID.EaterofWorldsHead));
            AddContent(new BossMusicSceneEffect("GelatineThrone", NPCID.KingSlime));
            AddContent(new BossMusicSceneEffect("HellOrHighWaters", NPCID.DukeFishron));
            AddContent(new BossMusicSceneEffect("ItSeesEverything", NPCID.EyeofCthulhu, NPCID.Deerclops));
            AddContent(new BossMusicSceneEffect("PlayingWithFirepower", NPCID.TheDestroyer, NPCID.SkeletronPrime, NPCID.Retinazer, NPCID.Spazmatism));
            AddContent(new BossMusicSceneEffect("PurgatorysAssault", NPCID.BloodNautilus));
            AddContent(new BossMusicSceneEffect("StingingOnslaught", NPCID.QueenBee));
        }
    }
}