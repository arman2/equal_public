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
using Simulation.MonSysContext.StatusArtifactContext;

namespace Simulation.MonSysContext.StatusArtifactContext.UpdateContext
{

    public class Responsible : DP_Data, DP_IData
    {
        public Update Update;

        public new Simulation.MonSysContext.AgentContext.Contributor Value
        {
          get
          {
            return (Simulation.MonSysContext.AgentContext.Contributor)val;
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


            Value = null;
        }

    }
}
