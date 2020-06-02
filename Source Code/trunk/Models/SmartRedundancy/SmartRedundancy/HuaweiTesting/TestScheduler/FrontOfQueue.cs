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

    public class FrontOfQueue : DP_Link, DP_ILink
    {
        public TestScheduler TestScheduler;

        private HuaweiTestingContext.TestSchedulerContext.UniformTestQueue UniformTestQueueInstance;

        public HuaweiTestingContext.TestSchedulerContext.UniformTestQueue UniformTestQueue
        {
          get
          {
            return UniformTestQueueInstance;
          }
          set
          {
            UniformTestQueueInstance = (HuaweiTestingContext.TestSchedulerContext.UniformTestQueue)value;
            if (Role1 != value)
            {
              Role1 = value;
            }
          }
        }

        private HuaweiTestingContext.TestSchedulerContext.GetNextJob GetNextJobInstance;

        public HuaweiTestingContext.TestSchedulerContext.GetNextJob GetNextJob
        {
          get
          {
            return GetNextJobInstance;
          }
          set
          {
            GetNextJobInstance = (HuaweiTestingContext.TestSchedulerContext.GetNextJob)value;
            if (Role2 != value)
            {
              Role2 = value;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
