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
    using AccessCoordinatorContext;

    public class AccessCoordinator : DP_Component, DP_IComponent
    {
        public MonSys MonSys;

        public System.Double WorkExeDuration
        {
          get { return ((Collaborator)Type).WorkExeDuration; }
        }

        public System.Double EWMAalpha
        {
          get { return ((Collaborator)Type).EWMAalpha; }
        }

        private List<ConflictDetection> ConflictDetectionInstances = new List<ConflictDetection>();

        public List<ConflictDetection> ConflictDetectionList
        {
          get
          {
            return ConflictDetectionInstances;
          }
          set
          {
            ConflictDetectionInstances = value;
          }
        }

        private UpdateSuccess UpdateSuccessInstance;

        public UpdateSuccess UpdateSuccessData
        {
          get
          {
            return UpdateSuccessInstance;
          }
          set
          {
            UpdateSuccessInstance = value;
          }
        }

        public int UpdateSuccess
        {
          get
          {
            return UpdateSuccessInstance.Value;
          }
          set
          {
            UpdateSuccessInstance.Value = value;
          }
        }

        private UpdateConflict UpdateConflictInstance;

        public UpdateConflict UpdateConflictData
        {
          get
          {
            return UpdateConflictInstance;
          }
          set
          {
            UpdateConflictInstance = value;
          }
        }

        public int UpdateConflict
        {
          get
          {
            return UpdateConflictInstance.Value;
          }
          set
          {
            UpdateConflictInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          UpdateSuccessInstance = (UpdateSuccess)Create("UpdateSuccess");
          UpdateConflictInstance = (UpdateConflict)Create("UpdateConflict");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
