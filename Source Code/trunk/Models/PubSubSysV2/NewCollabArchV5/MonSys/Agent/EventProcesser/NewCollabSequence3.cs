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

namespace Simulation.MonSysContext.AgentContext.EventProcesserContext
{

    public class NewCollabSequence3 : DP_Flow, DP_IFlow
    {
        public EventProcesser EventProcesser;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.EventProcesserContext.Idle Idle = source as MonSysContext.AgentContext.EventProcesserContext.Idle;
return (Idle.EventProcesser.Agent.AgentType==3 && Idle.EventProcesser.isIdle);
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.EventProcesserContext.Idle Idle = source as MonSysContext.AgentContext.EventProcesserContext.Idle;
          MonSysContext.AgentContext.EventProcesserContext.TeamLeaderWork TeamLeaderWork = target as MonSysContext.AgentContext.EventProcesserContext.TeamLeaderWork;
Idle.EventProcesser.isIdle = false;
Idle.EventProcesser.eventCount = Idle.EventProcesser.InEvents.Count;        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.EventProcesserContext.Idle Idle = source as MonSysContext.AgentContext.EventProcesserContext.Idle;
return Context;        }

    }
}
