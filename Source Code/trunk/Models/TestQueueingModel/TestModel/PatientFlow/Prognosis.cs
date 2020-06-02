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

    public class Prognosis : DP_Flow, DP_IFlow
    {
        public PatientFlow PatientFlow;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          PatientFlowContext.PatientArrival PatientArrival = source as PatientFlowContext.PatientArrival;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          PatientFlowContext.PatientArrival PatientArrival = source as PatientFlowContext.PatientArrival;
          PatientFlowContext.SeeDoctor SeeDoctor = target as PatientFlowContext.SeeDoctor;
SeeDoctor.Outcome = PatientArrival.IssueSeverity;        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          PatientFlowContext.PatientArrival PatientArrival = source as PatientFlowContext.PatientArrival;
return Context;        }

    }
}
