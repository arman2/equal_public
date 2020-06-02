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

namespace Simulation.PatientContext
{

    public class NewStepSequence14 : DP_Flow, DP_IFlow
    {
        public Patient Patient;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          PatientContext.Prep Prep = source as PatientContext.Prep;
return false;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          PatientContext.Prep Prep = source as PatientContext.Prep;
          PatientContext.PresentComplication PresentComplication = target as PatientContext.PresentComplication;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          PatientContext.Prep Prep = source as PatientContext.Prep;
return Context;        }

    }
}
