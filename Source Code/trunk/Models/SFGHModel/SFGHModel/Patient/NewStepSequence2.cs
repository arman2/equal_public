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

    public class NewStepSequence2 : DP_Flow, DP_IFlow
    {
        public Patient Patient;

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
