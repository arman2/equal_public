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

namespace Simulation.MonSysContext.AgentContext.ContributorContext
{

    public class NewCollabSequence : DP_Flow, DP_IFlow
    {
        public Contributor Contributor;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.ContributorContext.ReadFeedback ReadFeedback = source as MonSysContext.AgentContext.ContributorContext.ReadFeedback;
return (ReadFeedback.Contributor.WorkingOnUpdate != null && !ReadFeedback.Contributor.WorkingOnUpdate.isUpdateSuccess);
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.ContributorContext.ReadFeedback ReadFeedback = source as MonSysContext.AgentContext.ContributorContext.ReadFeedback;
          MonSysContext.AgentContext.ContributorContext.UpdateStatus UpdateStatus = target as MonSysContext.AgentContext.ContributorContext.UpdateStatus;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.ContributorContext.ReadFeedback ReadFeedback = source as MonSysContext.AgentContext.ContributorContext.ReadFeedback;
return Context;        }

    }
}
