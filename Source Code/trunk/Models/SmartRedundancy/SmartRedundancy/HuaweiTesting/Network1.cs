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

namespace Simulation.HuaweiTestingContext
{

    public class Network1 : DP_Dependency, DP_IDependency
    {
        public HuaweiTesting HuaweiTesting;

        private HuaweiTestingContext.TestScheduler TestSchedulerInstance;

        public HuaweiTestingContext.TestScheduler TestScheduler
        {
          get
          {
            return TestSchedulerInstance;
          }
          set
          {
            TestSchedulerInstance = (HuaweiTestingContext.TestScheduler)value;
            if (Object != value)
            {
              Object = value;
            }
          }
        }

        private HuaweiTestingContext.Resource1 Resource1Instance;

        public HuaweiTestingContext.Resource1 Resource1
        {
          get
          {
            return Resource1Instance;
          }
          set
          {
            Resource1Instance = (HuaweiTestingContext.Resource1)value;
            if (Resource != value)
            {
              Resource = value;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
