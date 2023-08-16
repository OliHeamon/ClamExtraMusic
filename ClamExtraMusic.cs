using Terraria.ModLoader;
using ClamExtraMusic.SceneEffects;
using Terraria.ID;
using ClamExtraMusic.Configs;

namespace ClamExtraMusic
{
    public class ClamExtraMusic : Mod
    {
        public override void Load()
        {
            PriorityConfig config = ModContent.GetInstance<PriorityConfig>();

            AddContent(new BossMusicSceneEffect("BreakingTheSeal", () => config.OverrideCultist, NPCID.CultistBoss));
            AddContent(new BossMusicSceneEffect("CrimsonCortex", () => config.OverrideBrainOfCthulhu, NPCID.BrainofCthulhu));
            AddContent(new BossMusicSceneEffect("CurseOfTheDungeon", () => config.OverrideSkeletron, NPCID.SkeletronHead));
            AddContent(new BossMusicSceneEffect("EvilEarthquake", () => config.OverrideEaterOfWorlds, NPCID.EaterofWorldsHead));
            AddContent(new BossMusicSceneEffect("FieryFistsOfStone", () => config.OverrideGolem, NPCID.Golem));
            AddContent(new BossMusicSceneEffect("Gardenmetal", () => config.OverridePlantera, NPCID.Plantera));
            AddContent(new BossMusicSceneEffect("GelatineThrone", () => config.OverrideKingSlime, NPCID.KingSlime));
            AddContent(new BossMusicSceneEffect("HellOrHighWaters", () => config.OverrideDukeFishon, NPCID.DukeFishron));
            AddContent(new BossMusicSceneEffect("ItSeesEverything", () => config.OverrideEyeOfCthulhu, NPCID.EyeofCthulhu));
            AddContent(new BossMusicSceneEffect("Omnipotence", () => config.OverrideMoonLord, NPCID.MoonLordCore));
            AddContent(new BossMusicSceneEffect("PlayingWithFirepower", () => config.OverrideMechs, NPCID.Spazmatism, NPCID.Retinazer, NPCID.SkeletronPrime, NPCID.TheDestroyer));
            AddContent(new BossMusicSceneEffect("StingingOnslaught", () => config.OverrideQueenBee, NPCID.QueenBee));
        }
    }
}