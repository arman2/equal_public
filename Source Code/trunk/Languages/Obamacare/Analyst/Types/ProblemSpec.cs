using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class ProblemSpec : DP_ComponentType
    {

        private int ComputationSizeValue = 1;

        [DisplayNameAttribute("ComputationSize"),
        CategoryAttribute("Parameters"),
        DefaultValueAttribute(1),
        DescriptionAttribute("")]
        public int ComputationSize
        {
            get { return ComputationSizeValue; }
            set { ComputationSizeValue = value; }
        }

        private int RequiredConfidenceValue = 3;

        [DisplayNameAttribute("RequiredConfidence"),
        CategoryAttribute("Parameters"),
        DefaultValueAttribute(3),
        DescriptionAttribute("")]
        public int RequiredConfidence
        {
            get { return RequiredConfidenceValue; }
            set { RequiredConfidenceValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
