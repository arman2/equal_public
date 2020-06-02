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
using Simulation.TraditionalRedundancySystemContext;

namespace Simulation.TraditionalRedundancySystemContext.SimpleJobServerContext
{
    using AssignJobContext;

    public class AssignJob : DP_Method, DP_IMethod
    {
        public SimpleJobServer SimpleJobServer;

        private AssignedJob AssignedJobInstance;

        public AssignedJob AssignedJobData
        {
          get
          {
            return AssignedJobInstance;
          }
          set
          {
            AssignedJobInstance = value;
          }
        }

        public UniformJob AssignedJob
        {
          get
          {
            return AssignedJobInstance.Value;
          }
          set
          {
            AssignedJobInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          AssignedJobInstance = (AssignedJob)Create("AssignedJob");

        }

        public override void Run()
        {
SimpleJobServer.GetNextJob();        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
