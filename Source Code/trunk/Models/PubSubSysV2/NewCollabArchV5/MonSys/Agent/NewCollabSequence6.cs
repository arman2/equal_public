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

    public class NewCollabSequence6 : DP_Flow, DP_IFlow
    {
        public Agent Agent;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.EventProcesserContext.Fwd Fwd = source as MonSysContext.AgentContext.EventProcesserContext.Fwd;
return Fwd.EventProcesser.Agent.DoUpdateArtifact;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.EventProcesserContext.Fwd Fwd = source as MonSysContext.AgentContext.EventProcesserContext.Fwd;
          MonSysContext.AgentContext.ContributorContext.UpdateStatus UpdateStatus = target as MonSysContext.AgentContext.ContributorContext.UpdateStatus;
Fwd.EventProcesser.Agent.ContributorList[0].ArtifactVersion = Fwd.EventProcesser.Agent.ContributorList[0].SharedStatusArtifact.Version;
	        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.EventProcesserContext.Fwd Fwd = source as MonSysContext.AgentContext.EventProcesserContext.Fwd;
return Fwd.EventProcesser.Agent.ContributorList[0];        }

    }
}
