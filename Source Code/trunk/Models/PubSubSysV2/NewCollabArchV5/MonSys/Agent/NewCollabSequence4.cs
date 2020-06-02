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

namespace Simulation.MonSysContext.AgentContext
{

    public class NewCollabSequence4 : DP_Flow, DP_IFlow
    {
        public Agent Agent;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.ContributorContext.UpdateStatus UpdateStatus = source as MonSysContext.AgentContext.ContributorContext.UpdateStatus;
return UpdateStatus.isError;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.ContributorContext.UpdateStatus UpdateStatus = source as MonSysContext.AgentContext.ContributorContext.UpdateStatus;
          MonSysContext.AgentContext.EventProcesserContext.Idle Idle = target as MonSysContext.AgentContext.EventProcesserContext.Idle;
UpdateStatus.isError = false;        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.ContributorContext.UpdateStatus UpdateStatus = source as MonSysContext.AgentContext.ContributorContext.UpdateStatus;
return UpdateStatus.Contributor.Agent.EventProcesserList[0];        }

    }
}
