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

    public class NewCollabSequence2 : DP_Flow, DP_IFlow
    {
        public Publisher Publisher;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.PublisherContext.Publish Publish = source as MonSysContext.AgentContext.PublisherContext.Publish;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.PublisherContext.Publish Publish = source as MonSysContext.AgentContext.PublisherContext.Publish;
          MonSysContext.AgentContext.PublisherContext.NextStep NextStep = target as MonSysContext.AgentContext.PublisherContext.NextStep;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.PublisherContext.Publish Publish = source as MonSysContext.AgentContext.PublisherContext.Publish;
return Context;        }

    }
}
