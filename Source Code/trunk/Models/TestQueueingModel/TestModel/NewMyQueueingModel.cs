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
    using NewMyQueueingModelContext;

    public class NewMyQueueingModel : DP_Component, DP_IComponent
    {
        private List<NewMySource> NewMySourceInstances = new List<NewMySource>();

        public List<NewMySource> NewMySourceList
        {
          get
          {
            return NewMySourceInstances;
          }
          set
          {
            NewMySourceInstances = value;
          }
        }

        private List<NewMyDestination> NewMyDestinationInstances = new List<NewMyDestination>();

        public List<NewMyDestination> NewMyDestinationList
        {
          get
          {
            return NewMyDestinationInstances;
          }
          set
          {
            NewMyDestinationInstances = value;
          }
        }

        public void NewMyStep()
        {
          DP_IMethod method = (DP_IMethod)Create("NewMyStep");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
          method.Completed.WaitOne();
        }

        public void NewMyStep1()
        {
          DP_IMethod method = (DP_IMethod)Create("NewMyStep1");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
          method.Completed.WaitOne();
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
