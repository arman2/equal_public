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

namespace Simulation.MonSysContext.StatusArtifactContext
{
    using UpdateContext;

    public class Update : DP_Component, DP_IComponent
    {
        public StatusArtifact StatusArtifact;

        private UpdateOnVersion UpdateOnVersionInstance;

        public UpdateOnVersion UpdateOnVersionData
        {
          get
          {
            return UpdateOnVersionInstance;
          }
          set
          {
            UpdateOnVersionInstance = value;
          }
        }

        public int UpdateOnVersion
        {
          get
          {
            return UpdateOnVersionInstance.Value;
          }
          set
          {
            UpdateOnVersionInstance.Value = value;
          }
        }

        private Scope ScopeInstance;

        public Scope ScopeData
        {
          get
          {
            return ScopeInstance;
          }
          set
          {
            ScopeInstance = value;
          }
        }

        public double Scope
        {
          get
          {
            return ScopeInstance.Value;
          }
          set
          {
            ScopeInstance.Value = value;
          }
        }

        private isUpdateSuccess isUpdateSuccessInstance;

        public isUpdateSuccess isUpdateSuccessData
        {
          get
          {
            return isUpdateSuccessInstance;
          }
          set
          {
            isUpdateSuccessInstance = value;
          }
        }

        public bool isUpdateSuccess
        {
          get
          {
            return isUpdateSuccessInstance.Value;
          }
          set
          {
            isUpdateSuccessInstance.Value = value;
          }
        }

        private Responsible ResponsibleInstance;

        public Responsible ResponsibleData
        {
          get
          {
            return ResponsibleInstance;
          }
          set
          {
            ResponsibleInstance = value;
          }
        }

        public Simulation.MonSysContext.AgentContext.Contributor Responsible
        {
          get
          {
            return ResponsibleInstance.Value;
          }
          set
          {
            ResponsibleInstance.Value = value;
          }
        }

        private WorkingOnUpdate WorkingOnUpdateInstance;

        public WorkingOnUpdate WorkingOnUpdateLink
        {
          get
          {
            return WorkingOnUpdateInstance;
          }
          set
          {
            if (WorkingOnUpdateInstance == value)
            {
              return;
            }
            WorkingOnUpdateInstance = value;
            if (WorkingOnUpdateInstance != null && WorkingOnUpdateInstance.Role2 != this)
            {
              WorkingOnUpdateInstance.Role2 = this;
            }
          }
        }

        public MonSysContext.AgentContext.Contributor WorkingOnUpdate
        {
          get
          {
            return WorkingOnUpdateInstance.Contributor;
          }
          set
          {
            WorkingOnUpdateInstance.Contributor = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          UpdateOnVersionInstance = (UpdateOnVersion)Create("UpdateOnVersion");
          ScopeInstance = (Scope)Create("Scope");
          isUpdateSuccessInstance = (isUpdateSuccess)Create("isUpdateSuccess");
          ResponsibleInstance = (Responsible)Create("Responsible");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
