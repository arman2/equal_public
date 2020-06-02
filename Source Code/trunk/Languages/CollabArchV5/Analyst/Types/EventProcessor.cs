using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class EventProcessor : Component
    {

        private double CapacityValue = 1;

        [DisplayNameAttribute("Capacity"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(1),
        DescriptionAttribute("")]
        public double Capacity
        {
            get { return CapacityValue; }
            set { CapacityValue = value; }
        }

        private double ExeDurationValue = 1;

        [DisplayNameAttribute("ExeDuration"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(1),
        DescriptionAttribute("")]
        public double ExeDuration
        {
            get { return ExeDurationValue; }
            set { ExeDurationValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
