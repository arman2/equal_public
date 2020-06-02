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
    using GetNextJobContext;

    public class GetNextJob : DP_Method, DP_IMethod
    {
        public TestScheduler TestScheduler;

        private NextJob NextJobInstance;

        public NextJob NextJobData
        {
          get
          {
            return NextJobInstance;
          }
          set
          {
            NextJobInstance = value;
          }
        }

        public UniformJob NextJob
        {
          get
          {
            return NextJobInstance.Value;
          }
          set
          {
            NextJobInstance.Value = value;
          }
        }

        private FrontOfQueue FrontOfQueueInstance;

        public FrontOfQueue FrontOfQueueLink
        {
          get
          {
            return FrontOfQueueInstance;
          }
          set
          {
            if (FrontOfQueueInstance == value)
            {
              return;
            }
            FrontOfQueueInstance = value;
            if (FrontOfQueueInstance != null && FrontOfQueueInstance.Role2 != this)
            {
              FrontOfQueueInstance.Role2 = this;
            }
          }
        }

        public HuaweiTestingContext.TestSchedulerContext.UniformTestQueue FrontOfQueue
        {
          get
          {
            return FrontOfQueueInstance.UniformTestQueue;
          }
          set
          {
            FrontOfQueueInstance.UniformTestQueue = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          NextJobInstance = (NextJob)Create("NextJob");

        }

        public override void Run()
        {
if (SimpleJobServer.UniformJobQueue.Count > 0)
	NextJob = SimpleJobServer.UniformJobQueue.Dequeue();
else
	NextJob = null;
        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
