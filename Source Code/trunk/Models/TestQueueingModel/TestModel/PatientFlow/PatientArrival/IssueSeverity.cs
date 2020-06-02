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
using Simulation.PatientFlowContext;

namespace Simulation.PatientFlowContext.PatientArrivalContext
{

    public class IssueSeverity : DP_Data, DP_IData
    {
        public PatientArrival PatientArrival;

        public new double Value
        {
          get
          {
            return (double)val;
          }
          set
          {
            OnDataChanged(new DP_DataChangedEventArgs(Id, Model.Simulation.Simulator.Scheduler.Time, value));
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


            Value = 0;
        }

    }
}
