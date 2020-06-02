using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class CollabPattern : DP_ComponentType
    {

        private double SensorRatioValue = 0.899;

        [DisplayNameAttribute("SensorRatio"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.899),
        DescriptionAttribute("")]
        public double SensorRatio
        {
            get { return SensorRatioValue; }
            set { SensorRatioValue = value; }
        }

        private double FieldAgentRatioValue = 0.09;

        [DisplayNameAttribute("FieldAgentRatio"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.09),
        DescriptionAttribute("")]
        public double FieldAgentRatio
        {
            get { return FieldAgentRatioValue; }
            set { FieldAgentRatioValue = value; }
        }

        private double BackOfficeRatioValue = 0.009;

        [DisplayNameAttribute("BackOfficeRatio"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.009),
        DescriptionAttribute("")]
        public double BackOfficeRatio
        {
            get { return BackOfficeRatioValue; }
            set { BackOfficeRatioValue = value; }
        }

        private double TeamLeaderRatioValue = 0.0009;

        [DisplayNameAttribute("TeamLeaderRatio"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.0009),
        DescriptionAttribute("")]
        public double TeamLeaderRatio
        {
            get { return TeamLeaderRatioValue; }
            set { TeamLeaderRatioValue = value; }
        }

        private uint SeedUValue = 0;

        [DisplayNameAttribute("SeedU"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0),
        DescriptionAttribute("")]
        public uint SeedU
        {
            get { return SeedUValue; }
            set { SeedUValue = value; }
        }

        private uint SeedVValue = 0;

        [DisplayNameAttribute("SeedV"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0),
        DescriptionAttribute("")]
        public uint SeedV
        {
            get { return SeedVValue; }
            set { SeedVValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
