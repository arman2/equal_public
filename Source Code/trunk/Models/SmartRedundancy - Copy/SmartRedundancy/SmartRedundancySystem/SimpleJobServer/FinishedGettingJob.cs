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

    public class FinishedGettingJob : DP_Flow, DP_IFlow
    {
        public SimpleJobServer SimpleJobServer;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          SmartRedundancySystemContext.SimpleJobServerContext.GetNextJob GetNextJob = source as SmartRedundancySystemContext.SimpleJobServerContext.GetNextJob;
return GetNextJob.NextJob != null;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          SmartRedundancySystemContext.SimpleJobServerContext.GetNextJob GetNextJob = source as SmartRedundancySystemContext.SimpleJobServerContext.GetNextJob;
          SmartRedundancySystemContext.SimpleJobServerContext.AssignJob AssignJob = target as SmartRedundancySystemContext.SimpleJobServerContext.AssignJob;
AssignJob.AssignedJob = GetNextJob.NextJob;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          SmartRedundancySystemContext.SimpleJobServerContext.GetNextJob GetNextJob = source as SmartRedundancySystemContext.SimpleJobServerContext.GetNextJob;
return Context;
        }

    }
}
