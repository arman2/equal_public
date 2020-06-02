using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class ActorPool : DP_ResourceType
    {

        private int PoolSizeValue = 10;

        [DisplayNameAttribute("PoolSize"),
        CategoryAttribute("PoolProperties"),
        DefaultValueAttribute(10),
        DescriptionAttribute("")]
        public int PoolSize
        {
            get { return PoolSizeValue; }
            set { PoolSizeValue = value; }
        }

        private double PoolSizeDynamicsValue = 0;

        [DisplayNameAttribute("PoolSizeDynamics"),
        CategoryAttribute("PoolProperties"),
        DefaultValueAttribute(0),
        DescriptionAttribute("")]
        public double PoolSizeDynamics
        {
            get { return PoolSizeDynamicsValue; }
            set { PoolSizeDynamicsValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Resource;
            base.Initialize(parentStructure);
        }

    }
}
