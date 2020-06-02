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

    public class NewCollabSequence2 : DP_Flow, DP_IFlow
    {
        public EventProcesser EventProcesser;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.EventProcesserContext.TeamLeaderWork TeamLeaderWork = source as MonSysContext.AgentContext.EventProcesserContext.TeamLeaderWork;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.EventProcesserContext.TeamLeaderWork TeamLeaderWork = source as MonSysContext.AgentContext.EventProcesserContext.TeamLeaderWork;
          MonSysContext.AgentContext.EventProcesserContext.Fwd Fwd = target as MonSysContext.AgentContext.EventProcesserContext.Fwd;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.EventProcesserContext.TeamLeaderWork TeamLeaderWork = source as MonSysContext.AgentContext.EventProcesserContext.TeamLeaderWork;
return Context;        }

    }
}
