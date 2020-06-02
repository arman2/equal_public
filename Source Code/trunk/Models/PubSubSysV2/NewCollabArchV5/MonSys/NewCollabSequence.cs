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

    public class NewCollabSequence : DP_Flow, DP_IFlow
    {
        public MonSys MonSys;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback UpdateFeedback = source as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback;
return false;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback UpdateFeedback = source as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback;
          MonSysContext.AgentContext.ContributorContext.ReadFeedback ReadFeedback = target as MonSysContext.AgentContext.ContributorContext.ReadFeedback;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback UpdateFeedback = source as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback;
return Context;        }

    }
}
