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
    using HuaweiTestingContext;

    public class HuaweiTesting : DP_Component, DP_IComponent
    {
        private List<Resource1> Resource1Instances = new List<Resource1>();

        public List<Resource1> Resource1List
        {
          get
          {
            return Resource1Instances;
          }
          set
          {
            Resource1Instances = value;
          }
        }

        private List<TestScheduler> TestSchedulerInstances = new List<TestScheduler>();

        public List<TestScheduler> TestSchedulerList
        {
          get
          {
            return TestSchedulerInstances;
          }
          set
          {
            TestSchedulerInstances = value;
          }
        }

        private List<Network1> Network1Instances = new List<Network1>();

        public List<Network1> Network1List
        {
          get
          {
            return Network1Instances;
          }
          set
          {
            Network1Instances = value;
          }
        }

        private List<Resource2> Resource2Instances = new List<Resource2>();

        public List<Resource2> Resource2List
        {
          get
          {
            return Resource2Instances;
          }
          set
          {
            Resource2Instances = value;
          }
        }

        private List<Network2> Network2Instances = new List<Network2>();

        public List<Network2> Network2List
        {
          get
          {
            return Network2Instances;
          }
          set
          {
            Network2Instances = value;
          }
        }

        private List<NewVolunteerPool> NewVolunteerPoolInstances = new List<NewVolunteerPool>();

        public List<NewVolunteerPool> NewVolunteerPoolList
        {
          get
          {
            return NewVolunteerPoolInstances;
          }
          set
          {
            NewVolunteerPoolInstances = value;
          }
        }

        private List<NewNetwork> NewNetworkInstances = new List<NewNetwork>();

        public List<NewNetwork> NewNetworkList
        {
          get
          {
            return NewNetworkInstances;
          }
          set
          {
            NewNetworkInstances = value;
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
