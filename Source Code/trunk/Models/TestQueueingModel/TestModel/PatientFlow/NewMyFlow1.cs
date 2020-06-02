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

    public class NewMyFlow1 : DP_Flow, DP_IFlow
    {
        public PatientFlow PatientFlow;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          PatientFlowContext.Die Die = source as PatientFlowContext.Die;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          PatientFlowContext.Die Die = source as PatientFlowContext.Die;
          PatientFlowContext.PatientArrival PatientArrival = target as PatientFlowContext.PatientArrival;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          PatientFlowContext.Die Die = source as PatientFlowContext.Die;
return Context;        }

    }
}
