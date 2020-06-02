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
    using NewInputGeneratorContext;

    public class NewInputGenerator : DP_Component, DP_IComponent
    {
        public void NewFunction(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("NewFunction");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private NewRunsOn NewRunsOnInstance;
        public NewRunsOn NewRunsOn
        {
          get
          {
            return NewRunsOnInstance;
          }
          set
          {
            NewRunsOnInstance = value;
            if (NewRunsOnInstance != null && NewRunsOnInstance.Object != this)
            {
              NewRunsOnInstance.Object = this;
            }
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
