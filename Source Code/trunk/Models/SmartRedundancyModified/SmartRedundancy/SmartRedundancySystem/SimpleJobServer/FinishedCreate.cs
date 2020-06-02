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

    public class FinishedCreate : DP_Flow, DP_IFlow
    {
        public SimpleJobServer SimpleJobServer;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          SmartRedundancySystemContext.SimpleJobServerContext.CreateJobs CreateJobs = source as SmartRedundancySystemContext.SimpleJobServerContext.CreateJobs;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          SmartRedundancySystemContext.SimpleJobServerContext.CreateJobs CreateJobs = source as SmartRedundancySystemContext.SimpleJobServerContext.CreateJobs;
          SmartRedundancySystemContext.SimpleJobServerContext.GetNextJob GetNextJob = target as SmartRedundancySystemContext.SimpleJobServerContext.GetNextJob;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          SmartRedundancySystemContext.SimpleJobServerContext.CreateJobs CreateJobs = source as SmartRedundancySystemContext.SimpleJobServerContext.CreateJobs;
return Context;
        }

    }
}
