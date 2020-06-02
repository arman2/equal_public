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

    public class SharedStatusArtifact : DP_Link, DP_ILink
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

        private MonSysContext.StatusArtifact StatusArtifactInstance;

        public MonSysContext.StatusArtifact StatusArtifact
        {
          get
          {
            return StatusArtifactInstance;
          }
          set
          {
            StatusArtifactInstance = (MonSysContext.StatusArtifact)value;
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
