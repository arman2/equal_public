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

    public class NewTestScheduler : DP_Component, DP_IComponent
    {
        public HuaweiTestingContainer HuaweiTestingContainer;

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
DomainProAnalyst.Instance.Report("started up");        }

    }
}
