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

    public class FinishedAssignment : DP_Flow, DP_IFlow
    {
        public SimpleJobServer SimpleJobServer;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          SmartRedundancySystemContext.SimpleJobServerContext.AssignJob AssignJob = source as SmartRedundancySystemContext.SimpleJobServerContext.AssignJob;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          SmartRedundancySystemContext.SimpleJobServerContext.AssignJob AssignJob = source as SmartRedundancySystemContext.SimpleJobServerContext.AssignJob;
          SmartRedundancySystemContext.SimpleJobServerContext.HandleResult HandleResult = target as SmartRedundancySystemContext.SimpleJobServerContext.HandleResult;
HandleResult.JobAssignment = AssignJob.AssignedJob;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          SmartRedundancySystemContext.SimpleJobServerContext.AssignJob AssignJob = source as SmartRedundancySystemContext.SimpleJobServerContext.AssignJob;
return Context;
        }

    }
}
