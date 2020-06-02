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

    public class FinishedCreatingJobs : DP_Flow, DP_IFlow
    {
        public SimpleJobServer SimpleJobServer;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          TraditionalRedundancySystemContext.SimpleJobServerContext.CreateJobs CreateJobs = source as TraditionalRedundancySystemContext.SimpleJobServerContext.CreateJobs;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          TraditionalRedundancySystemContext.SimpleJobServerContext.CreateJobs CreateJobs = source as TraditionalRedundancySystemContext.SimpleJobServerContext.CreateJobs;
          TraditionalRedundancySystemContext.SimpleJobServerContext.GetNextJob GetNextJob = target as TraditionalRedundancySystemContext.SimpleJobServerContext.GetNextJob;
        }

    }
}
