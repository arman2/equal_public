using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class ResourcePool : DP_ResourceType
    {

        private int PoolSizeValue;

        [DisplayNameAttribute("PoolSize"),
        CategoryAttribute("Parameters"),
        DescriptionAttribute("")]
        public int PoolSize
        {
            get { return PoolSizeValue; }
            set { PoolSizeValue = value; }
        }

        private double CostValue;

        [DisplayNameAttribute("Cost"),
        CategoryAttribute("Parameters"),
        DescriptionAttribute("")]
        public double Cost
        {
            get { return CostValue; }
            set { CostValue = value; }
        }

        private String ExecutionTimeValue;

        [DisplayNameAttribute("ExecutionTime"),
        CategoryAttribute("Parameters"),
        DescriptionAttribute("")]
        public String ExecutionTime
        {
            get { return ExecutionTimeValue; }
            set { ExecutionTimeValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Resource;
            base.Initialize(parentStructure);
        }

    }
}
