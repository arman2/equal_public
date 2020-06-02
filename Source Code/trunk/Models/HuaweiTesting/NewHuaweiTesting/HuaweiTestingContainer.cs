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

namespace Simulation
{
    using HuaweiTestingContainerContext;

    public class HuaweiTestingContainer : DP_Component, DP_IComponent
    {
        private List<NewResourcePool> NewResourcePoolInstances = new List<NewResourcePool>();

        public List<NewResourcePool> NewResourcePoolList
        {
          get
          {
            return NewResourcePoolInstances;
          }
          set
          {
            NewResourcePoolInstances = value;
          }
        }

        private List<NewTestScheduler> NewTestSchedulerInstances = new List<NewTestScheduler>();

        public List<NewTestScheduler> NewTestSchedulerList
        {
          get
          {
            return NewTestSchedulerInstances;
          }
          set
          {
            NewTestSchedulerInstances = value;
          }
        }

        private List<NewRunsOn> NewRunsOnInstances = new List<NewRunsOn>();

        public List<NewRunsOn> NewRunsOnList
        {
          get
          {
            return NewRunsOnInstances;
          }
          set
          {
            NewRunsOnInstances = value;
          }
        }

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
