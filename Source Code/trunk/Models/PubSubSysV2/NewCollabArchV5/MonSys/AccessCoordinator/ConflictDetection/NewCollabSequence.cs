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

    public class NewCollabSequence : DP_Flow, DP_IFlow
    {
        public ConflictDetection ConflictDetection;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate CheckUpdate = source as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate;
return (CheckUpdate.ConflictDetection.OutQueue.Count > 0);
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate CheckUpdate = source as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate;
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback UpdateFeedback = target as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.UpdateFeedback;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate CheckUpdate = source as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate;
return Context;        }

    }
}
