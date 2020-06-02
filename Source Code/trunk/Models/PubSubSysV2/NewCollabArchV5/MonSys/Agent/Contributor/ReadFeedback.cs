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

    public class ReadFeedback : DP_Method, DP_IMethod
    {
        public Contributor Contributor;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
if (Contributor.WorkingOnUpdate != null && Contributor.WorkingOnUpdate.isUpdateSuccess)
{
	Contributor.ArtifactVersion = Contributor.WorkingOnUpdate.StatusArtifact.Version;
	Contributor.Agent.UpdateConflictPerWrite = (Contributor.WriteTries-1);
	
}        }

        public override double Duration
        {
          get
          {
return 0.001;
          }
        }

    }
}
