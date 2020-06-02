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
    using UpdateStatusContext;

    public class UpdateStatus : DP_Method, DP_IMethod
    {
        public Contributor Contributor;

        private isError isErrorInstance;

        public isError isErrorData
        {
          get
          {
            return isErrorInstance;
          }
          set
          {
            isErrorInstance = value;
          }
        }

        public bool isError
        {
          get
          {
            return isErrorInstance.Value;
          }
          set
          {
            isErrorInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          isErrorInstance = (isError)Create("isError");

        }

        public override void Run()
        {
// determine where to get version Nr from
// determine update extend/scope
// determine update duration

if (Contributor.SharedStatusArtifact == null)
{
	isError = true;
	return;
}
StatusArtifact sa = Contributor.SharedStatusArtifact;

Simulation.MonSysContext.StatusArtifactContext.Update up = Contributor.WorkingOnUpdate;
if (up == null)
{
	// working on new update
	Contributor.WriteTries = 1;
	Contributor.Agent.UpdateCount++;
}
else
{
	Contributor.WriteTries++;
	// working on conflicting update
	Contributor.Agent.UpdateConflictSum++;
	Contributor.ArtifactVersion = up.StatusArtifact.Version;	
}
up = sa.Create("Update") as Simulation.MonSysContext.StatusArtifactContext.Update;
Contributor.WorkingOnUpdate = up;
up.WorkingOnUpdate = Contributor;
up.Responsible = Contributor;
up.Scope = 1.0;
up.UpdateOnVersion = Contributor.ArtifactVersion;

        }

        public override double Duration
        {
          get
          {
double dur = Contributor.Agent.WorkExeDuration*Contributor.UpdateP;
return dur;
          }
        }

    }
}
