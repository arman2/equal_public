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

    public class Network2 : DP_Dependency, DP_IDependency
    {
        public HuaweiTesting HuaweiTesting;

        private HuaweiTestingContext.Resource2 Resource2Instance;

        public HuaweiTestingContext.Resource2 Resource2
        {
          get
          {
            return Resource2Instance;
          }
          set
          {
            Resource2Instance = (HuaweiTestingContext.Resource2)value;
            if (Object != value)
            {
              Object = value;
            }
          }
        }

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
