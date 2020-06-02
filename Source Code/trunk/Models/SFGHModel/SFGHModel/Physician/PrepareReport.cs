using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using DomainPro.Core.Types;
using DomainPro.Analyst;
using DomainPro.Analyst.Interfaces;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;
using DomainPro.Analyst.Engine;
using Analyst.Types;
using Simulation;

namespace Simulation.PhysicianContext
{

    public class PrepareReport : DP_Method, DP_IMethod
    {
        public Physician Physician;

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
