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

    public class FinishedHandleResult : DP_Flow, DP_IFlow
    {
        public TestScheduler TestScheduler;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          HuaweiTestingContext.TestSchedulerContext.HandleResult HandleResult = source as HuaweiTestingContext.TestSchedulerContext.HandleResult;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          HuaweiTestingContext.TestSchedulerContext.HandleResult HandleResult = source as HuaweiTestingContext.TestSchedulerContext.HandleResult;
          HuaweiTestingContext.TestSchedulerContext.GetNextJob GetNextJob = target as HuaweiTestingContext.TestSchedulerContext.GetNextJob;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          HuaweiTestingContext.TestSchedulerContext.HandleResult HandleResult = source as HuaweiTestingContext.TestSchedulerContext.HandleResult;
return Context;
        }

    }
}
