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
    using StatusArtifactContext;

    public class StatusArtifact : DP_Component, DP_IComponent
    {
        public MonSys MonSys;

        private Version VersionInstance;

        public Version VersionData
        {
          get
          {
            return VersionInstance;
          }
          set
          {
            VersionInstance = value;
          }
        }

        public int Version
        {
          get
          {
            return VersionInstance.Value;
          }
          set
          {
            VersionInstance.Value = value;
          }
        }

        private NrConflicts NrConflictsInstance;

        public NrConflicts NrConflictsData
        {
          get
          {
            return NrConflictsInstance;
          }
          set
          {
            NrConflictsInstance = value;
          }
        }

        public int NrConflicts
        {
          get
          {
            return NrConflictsInstance.Value;
          }
          set
          {
            NrConflictsInstance.Value = value;
          }
        }

        public void Updated(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Updated");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private List<Update> UpdateInstances = new List<Update>();

        public List<Update> UpdateList
        {
          get
          {
            return UpdateInstances;
          }
          set
          {
            UpdateInstances = value;
          }
        }

        private SharedStatusArtifact SharedStatusArtifactInstance;

        public SharedStatusArtifact SharedStatusArtifactLink
        {
          get
          {
            return SharedStatusArtifactInstance;
          }
          set
          {
            if (SharedStatusArtifactInstance == value)
            {
              return;
            }
            SharedStatusArtifactInstance = value;
            if (SharedStatusArtifactInstance != null && SharedStatusArtifactInstance.Role2 != this)
            {
              SharedStatusArtifactInstance.Role2 = this;
            }
          }
        }

        public MonSysContext.AgentContext.Contributor SharedStatusArtifact
        {
          get
          {
            return SharedStatusArtifactInstance.Contributor;
          }
          set
          {
            SharedStatusArtifactInstance.Contributor = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          VersionInstance = (Version)Create("Version");
          NrConflictsInstance = (NrConflicts)Create("NrConflicts");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
