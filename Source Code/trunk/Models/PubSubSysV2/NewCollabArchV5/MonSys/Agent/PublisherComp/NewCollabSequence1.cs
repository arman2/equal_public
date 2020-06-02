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

namespace Simulation.MonSysContext.AgentContext.PublisherCompContext
{

    public class NewCollabSequence1 : DP_Flow, DP_IFlow
    {
        public PublisherComp PublisherComp;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.PublisherCompContext.NextStep NextStep = source as MonSysContext.AgentContext.PublisherCompContext.NextStep;
return (NextStep.Choice == 1);

        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.PublisherCompContext.NextStep NextStep = source as MonSysContext.AgentContext.PublisherCompContext.NextStep;
          MonSysContext.AgentContext.PublisherCompContext.Publish Publish = target as MonSysContext.AgentContext.PublisherCompContext.Publish;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.PublisherCompContext.NextStep NextStep = source as MonSysContext.AgentContext.PublisherCompContext.NextStep;
return Context;        }

    }
}
