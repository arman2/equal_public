using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class MyDestination : DP_MethodType
    {


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Method;
            base.Initialize(parentStructure);
        }

    }
}
