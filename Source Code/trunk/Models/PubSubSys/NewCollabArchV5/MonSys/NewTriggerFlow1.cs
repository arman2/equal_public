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

namespace Simulation.MonSysContext
{

    public class NewTriggerFlow1 : DP_Flow, DP_IFlow
    {
        public MonSys MonSys;

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
          MonSysContext.PubMsgContext.Created Created = target as MonSysContext.PubMsgContext.Created;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.PublisherContext.Publish Publish = source as MonSysContext.AgentContext.PublisherContext.Publish;
return Publish.newEvent;        }

    }
}
