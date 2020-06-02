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

    public class InQueue : DP_Data, DP_IData
    {
        public ConflictDetection ConflictDetection;

        public new Queue<StatusArtifact> Value
        {
          get
          {
            return (Queue<StatusArtifact>)val;
          }
          set
          {
            OnDataChanged(new DP_DataChangedEventArgs(Id, Context.Id, Model.Simulation.Simulator.Scheduler.Time, value));
            val = value;
          }
        }

        public Double Size
        {
          get { return 0; }
        }

        public override void Initialize()
        {
          base.Initialize();


            Value = new Queue<StatusArtifact>();
        }

    }
}
