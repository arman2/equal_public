using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class PubSubDistributor : Connector
    {

        private double FwdDelayValue = 1;

        [DisplayNameAttribute("FwdDelay"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(1),
        DescriptionAttribute("")]
        public double FwdDelay
        {
            get { return FwdDelayValue; }
            set { FwdDelayValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
