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

namespace Simulation.PatientFlowContext
{

    public class NewMyFlow : DP_Flow, DP_IFlow
    {
        public PatientFlow PatientFlow;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          PatientFlowContext.Live Live = source as PatientFlowContext.Live;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          PatientFlowContext.Live Live = source as PatientFlowContext.Live;
          PatientFlowContext.PatientArrival PatientArrival = target as PatientFlowContext.PatientArrival;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          PatientFlowContext.Live Live = source as PatientFlowContext.Live;
return Context;        }

    }
}
