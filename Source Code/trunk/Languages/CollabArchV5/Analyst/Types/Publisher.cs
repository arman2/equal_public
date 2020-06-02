using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class Publisher : Component
    {

        private double InverseTopicRatioValue = 1;

        [DisplayNameAttribute("InverseTopicRatio"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(1),
        DescriptionAttribute("")]
        public double InverseTopicRatio
        {
            get { return InverseTopicRatioValue; }
            set { InverseTopicRatioValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
