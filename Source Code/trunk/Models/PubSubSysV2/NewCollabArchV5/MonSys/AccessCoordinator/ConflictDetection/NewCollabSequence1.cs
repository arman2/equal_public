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
using Simulation.MonSysContext.AccessCoordinatorContext;

namespace Simulation.MonSysContext.AccessCoordinatorContext.ConflictDetectionContext
{

    public class NewCollabSequence1 : DP_Flow, DP_IFlow
    {
        public ConflictDetection ConflictDetection;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback UpdateFeedback = source as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback;
return (ConflictDetection.InQueue.Count > 0 && ConflictDetection.isIdle == true);
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback UpdateFeedback = source as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback;
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate CheckUpdate = target as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate;
UpdateFeedback.ConflictDetection.isIdle = false;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback UpdateFeedback = source as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback;
return Context;        }

    }
}
