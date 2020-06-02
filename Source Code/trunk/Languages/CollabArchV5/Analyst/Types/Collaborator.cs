using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class Collaborator : DP_ComponentType
    {

        private double WorkExeDurationValue = 5;

        [DisplayNameAttribute("WorkExeDuration"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(5),
        DescriptionAttribute("")]
        public double WorkExeDuration
        {
            get { return WorkExeDurationValue; }
            set { WorkExeDurationValue = value; }
        }

        private double EWMAalphaValue = 0.5;

        [DisplayNameAttribute("EWMAalpha"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(0.5),
        DescriptionAttribute("")]
        public double EWMAalpha
        {
            get { return EWMAalphaValue; }
            set { EWMAalphaValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
