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

    public class GetWorse : DP_Flow, DP_IFlow
    {
        public PatientFlow PatientFlow;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          PatientFlowContext.SeeDoctor SeeDoctor = source as PatientFlowContext.SeeDoctor;
return SeeDoctor.Outcome >= 0.5;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          PatientFlowContext.SeeDoctor SeeDoctor = source as PatientFlowContext.SeeDoctor;
          PatientFlowContext.Die Die = target as PatientFlowContext.Die;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          PatientFlowContext.SeeDoctor SeeDoctor = source as PatientFlowContext.SeeDoctor;
return Context;        }

    }
}
