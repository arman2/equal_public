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
using Simulation.HuaweiTestingContext;

namespace Simulation.HuaweiTestingContext.TestSchedulerContext
{

    public class NewTestDefinition2 : DP_Component, DP_IComponent
    {
        public TestScheduler TestScheduler;

        public override void Initialize()
        {
          base.Initialize();


            Startup();
        }

        public void Startup()
        {
        }

    }
}
