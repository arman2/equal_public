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
using Simulation.SmartRedundancySystemContext;

namespace Simulation.SmartRedundancySystemContext.SimpleJobServerContext
{
    using UniformJobContext;

    public class UniformJob : DP_Component, DP_IComponent
    {
        public SimpleJobServer SimpleJobServer;

        private JobId JobIdInstance;

        public JobId JobIdData
        {
          get
          {
            return JobIdInstance;
          }
          set
          {
            JobIdInstance = value;
          }
        }

        public int JobId
        {
          get
          {
            return JobIdInstance.Value;
          }
          set
          {
            JobIdInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          JobIdInstance = (JobId)Create("JobId");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
