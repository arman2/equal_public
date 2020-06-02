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

    public class NewCollabSequence5 : DP_Flow, DP_IFlow
    {
        public Agent Agent;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.ContributorContext.ReadFeedback ReadFeedback = source as MonSysContext.AgentContext.ContributorContext.ReadFeedback;
// we need to capture error cases (when update == null)  and then return anyway
return (ReadFeedback.Contributor.WorkingOnUpdate == null || ReadFeedback.Contributor.WorkingOnUpdate.isUpdateSuccess);        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.ContributorContext.ReadFeedback ReadFeedback = source as MonSysContext.AgentContext.ContributorContext.ReadFeedback;
          MonSysContext.AgentContext.EventProcesserContext.Idle Idle = target as MonSysContext.AgentContext.EventProcesserContext.Idle;
ReadFeedback.Contributor.WorkingOnUpdate = null;        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.ContributorContext.ReadFeedback ReadFeedback = source as MonSysContext.AgentContext.ContributorContext.ReadFeedback;
return ReadFeedback.Contributor.Agent.EventProcesserList[0];        }

    }
}
