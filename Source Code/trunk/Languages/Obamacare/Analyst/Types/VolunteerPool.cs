using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class VolunteerPool : DP_ResourceType
    {

        private int PoolSizeValue = 1;

        [DisplayNameAttribute("PoolSize"),
        CategoryAttribute("Parameters"),
        DefaultValueAttribute(1),
        DescriptionAttribute("")]
        public int PoolSize
        {
            get { return PoolSizeValue; }
            set { PoolSizeValue = value; }
        }

        private double VolunteerReliabilityValue = 1;

        [DisplayNameAttribute("VolunteerReliability"),
        CategoryAttribute("Parameters"),
        DefaultValueAttribute(1),
        DescriptionAttribute("")]
        public double VolunteerReliability
        {
            get { return VolunteerReliabilityValue; }
            set { VolunteerReliabilityValue = value; }
        }

        private double ProcessingPowerValue = 1;

        [DisplayNameAttribute("ProcessingPower"),
        CategoryAttribute("Parameters"),
        DefaultValueAttribute(1),
        DescriptionAttribute("")]
        public double ProcessingPower
        {
            get { return ProcessingPowerValue; }
            set { ProcessingPowerValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Resource;
            base.Initialize(parentStructure);
        }

    }
}
