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

    public class WorkingOnUpdate : DP_Link, DP_ILink
    {
        public MonSys MonSys;

        private MonSysContext.AgentContext.Contributor ContributorInstance;

        public MonSysContext.AgentContext.Contributor Contributor
        {
          get
          {
            return ContributorInstance;
          }
          set
          {
            ContributorInstance = (MonSysContext.AgentContext.Contributor)value;
            if (Role1 != value)
            {
              Role1 = value;
            }
          }
        }

        private MonSysContext.StatusArtifactContext.Update UpdateInstance;

        public MonSysContext.StatusArtifactContext.Update Update
        {
          get
          {
            return UpdateInstance;
          }
          set
          {
            UpdateInstance = (MonSysContext.StatusArtifactContext.Update)value;
            if (Role2 != value)
            {
              Role2 = value;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
