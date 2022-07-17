using Newtonsoft.Json;
using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace ClamExtraMusic
{
    [Label("Music Priority Config")]
    public class PriorityConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("Boss Music Priority")]
        [Tooltip("This determines the priority of this mod's boss music overrides.\nThe lowest values prevent the music override from being applied, while high values will make the overrides take full priority.")]
        [DefaultValue(MusicPriority.OverrideBosses)]
        public MusicPriority BossPriority { get; set; }

        [Label("Event Music Priority")]
        [Tooltip("This determines the priority of this mod's blizzard music override.\nThe lowest values prevent the music override from being applied, while high values will make the overrides take full priority.")]
        [DefaultValue(MusicPriority.OverrideEvents)]
        public MusicPriority EventPriority { get; set; }

        [Label("Biome Music Priority")]
        [Tooltip("This determines the priority of this mod's meteor biome music override.\nThe lowest values prevent the music override from being applied, while high values will make the overrides take full priority.")]
        [DefaultValue(MusicPriority.OverrideBiomes)]
        public MusicPriority BiomePriority { get; set; }

        [JsonIgnore]
        public SceneEffectPriority BossScenePriority => FromMusicPriority(BossPriority);

        [JsonIgnore]
        public SceneEffectPriority EventScenePriority => FromMusicPriority(EventPriority);

        [JsonIgnore]
        public SceneEffectPriority BiomeScenePriority => FromMusicPriority(BiomePriority);

        private static SceneEffectPriority FromMusicPriority(MusicPriority priority) => priority switch
        {
            MusicPriority.DoNotPlay => SceneEffectPriority.None,
            MusicPriority.OverrideBiomes => SceneEffectPriority.BiomeMedium,
            MusicPriority.OverrideEvents => SceneEffectPriority.Event,
            MusicPriority.OverrideBosses => SceneEffectPriority.BossHigh,
            _ => SceneEffectPriority.None
        };
    }
}
