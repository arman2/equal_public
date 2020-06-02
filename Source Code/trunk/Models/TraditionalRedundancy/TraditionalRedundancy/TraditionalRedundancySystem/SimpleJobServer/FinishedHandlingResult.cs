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

    public class FinishedHandlingResult : DP_Flow, DP_IFlow
    {
        public SimpleJobServer SimpleJobServer;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          TraditionalRedundancySystemContext.SimpleJobServerContext.HandleResult HandleResult = source as TraditionalRedundancySystemContext.SimpleJobServerContext.HandleResult;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          TraditionalRedundancySystemContext.SimpleJobServerContext.HandleResult HandleResult = source as TraditionalRedundancySystemContext.SimpleJobServerContext.HandleResult;
          TraditionalRedundancySystemContext.SimpleJobServerContext.GetNextJob GetNextJob = target as TraditionalRedundancySystemContext.SimpleJobServerContext.GetNextJob;
        }

    }
}
