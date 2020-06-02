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

    public class NewNetwork : DP_Dependency, DP_IDependency
    {
        public HuaweiTesting HuaweiTesting;

        private HuaweiTestingContext.NewVolunteerPool NewVolunteerPoolInstance;

        public HuaweiTestingContext.NewVolunteerPool NewVolunteerPool
        {
          get
          {
            return NewVolunteerPoolInstance;
          }
          set
          {
            NewVolunteerPoolInstance = (HuaweiTestingContext.NewVolunteerPool)value;
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
