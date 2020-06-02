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

namespace Simulation.MonSysContext.TopicContext
{

    public class Publishers : DP_Data, DP_IData
    {
        public Topic Topic;

        public new List<Simulation.MonSysContext.AgentContext.Publisher> Value
        {
          get
          {
            return (List<Simulation.MonSysContext.AgentContext.Publisher>)val;
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


            Value = new List<Simulation.MonSysContext.AgentContext.Publisher>();
        }

    }
}
