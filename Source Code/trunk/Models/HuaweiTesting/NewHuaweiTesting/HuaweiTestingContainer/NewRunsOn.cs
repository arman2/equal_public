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

namespace Simulation.HuaweiTestingContainerContext
{

    public class NewRunsOn : DP_Dependency, DP_IDependency
    {
        public HuaweiTestingContainer HuaweiTestingContainer;

        private HuaweiTestingContainerContext.NewTestScheduler NewTestSchedulerInstance;

        public HuaweiTestingContainerContext.NewTestScheduler NewTestScheduler
        {
          get
          {
            return NewTestSchedulerInstance;
          }
          set
          {
            NewTestSchedulerInstance = (HuaweiTestingContainerContext.NewTestScheduler)value;
            if (Object != value)
            {
              Object = value;
            }
          }
        }

        private HuaweiTestingContainerContext.NewResourcePool NewResourcePoolInstance;

        public HuaweiTestingContainerContext.NewResourcePool NewResourcePool
        {
          get
          {
            return NewResourcePoolInstance;
          }
          set
          {
            NewResourcePoolInstance = (HuaweiTestingContainerContext.NewResourcePool)value;
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
