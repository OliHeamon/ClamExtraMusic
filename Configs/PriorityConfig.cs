using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ClamExtraMusic.Configs
{
    [Label("Music Priority Config")]
    public class PriorityConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("Replace Cultist Theme?")]
        [DefaultValue(true)]
        public bool OverrideCultist { get; set; }

        [Label("Replace BoC Theme?")]
        [DefaultValue(true)]
        public bool OverrideBrainOfCthulhu { get; set; }

        [Label("Replace Skeletron Theme?")]
        [DefaultValue(true)]
        public bool OverrideSkeletron { get; set; }

        [Label("Replace EoW Theme?")]
        [DefaultValue(true)]
        public bool OverrideEaterOfWorlds { get; set; }

        [Label("Replace Golem Theme?")]
        [DefaultValue(true)]
        public bool OverrideGolem { get; set; }

        [Label("Replace Plantera Theme?")]
        [DefaultValue(true)]
        public bool OverridePlantera { get; set; }

        [Label("Replace King Slime Theme?")]
        [DefaultValue(true)]
        public bool OverrideKingSlime { get; set; }

        [Label("Replace Duke Fishron Theme?")]
        [DefaultValue(true)]
        public bool OverrideDukeFishon { get; set; }

        [Label("Replace EoC Theme?")]
        [DefaultValue(true)]
        public bool OverrideEyeOfCthulhu { get; set; }

        [Label("Replace Moon Lord Theme?")]
        [DefaultValue(true)]
        public bool OverrideMoonLord { get; set; }

        [Label("Replace Mechanical Bosses Theme?")]
        [DefaultValue(true)]
        public bool OverrideMechs { get; set; }

        [Label("Replace Queen Bee Theme?")]
        [DefaultValue(true)]
        public bool OverrideQueenBee { get; set; }

        [Label("Replace WoF Theme?")]
        [DefaultValue(true)]
        public bool OverrideWallOfFlesh { get; set; }

        [Label("Replace Blizzard Theme?")]
        [DefaultValue(true)]
        public bool OverrideBlizzard { get; set; }

        [Label("Replace Meteor Theme?")]
        [DefaultValue(true)]
        public bool OverrideMeteor { get; set; }
    }
}
