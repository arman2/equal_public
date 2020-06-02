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

    public class NewTriggerFlow8 : DP_Flow, DP_IFlow
    {
        public MonSys MonSys;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.StatusArtifactContext.Updated Updated = source as MonSysContext.StatusArtifactContext.Updated;
return (Updated.StatusArtifact.MonSys.AccessCoordinatorList[0].ConflictDetectionList[0].isIdle);
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.StatusArtifactContext.Updated Updated = source as MonSysContext.StatusArtifactContext.Updated;
          MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate CheckUpdate = target as MonSysContext.AccessCoordinatorContext.ConflictDetectionContext.CheckUpdate;
Updated.StatusArtifact.MonSys.AccessCoordinatorList[0].ConflictDetectionList[0].isIdle = false;        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.StatusArtifactContext.Updated Updated = source as MonSysContext.StatusArtifactContext.Updated;
return Updated.StatusArtifact.MonSys.AccessCoordinatorList[0].ConflictDetectionList[0];        }

    }
}
