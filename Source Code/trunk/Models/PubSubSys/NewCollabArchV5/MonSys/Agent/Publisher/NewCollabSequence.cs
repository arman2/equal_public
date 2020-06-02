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
using Simulation.MonSysContext;
using Simulation.MonSysContext.AgentContext;

namespace Simulation.MonSysContext.AgentContext.PublisherContext
{

    public class NewCollabSequence : DP_Flow, DP_IFlow
    {
        public Publisher Publisher;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.PublisherContext.NextStep NextStep = source as MonSysContext.AgentContext.PublisherContext.NextStep;
return (NextStep.Choice == 0);
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.PublisherContext.NextStep NextStep = source as MonSysContext.AgentContext.PublisherContext.NextStep;
          MonSysContext.AgentContext.PublisherContext.Idle Idle = target as MonSysContext.AgentContext.PublisherContext.Idle;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.PublisherContext.NextStep NextStep = source as MonSysContext.AgentContext.PublisherContext.NextStep;
return Context;        }

    }
}
