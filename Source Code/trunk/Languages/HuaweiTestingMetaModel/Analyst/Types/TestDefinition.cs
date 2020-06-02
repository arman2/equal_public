using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class TestDefinition : DP_ComponentType
    {

        private double ExecutionTimeValue;

        [DisplayNameAttribute("ExecutionTime"),
        CategoryAttribute("Parameters"),
        DescriptionAttribute("")]
        public double ExecutionTime
        {
            get { return ExecutionTimeValue; }
            set { ExecutionTimeValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
