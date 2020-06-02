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
    using SeeDoctorContext;

    public class SeeDoctor : DP_Method, DP_IMethod
    {
        public PatientFlow PatientFlow;

        private Outcome OutcomeInstance;

        public Outcome OutcomeData
        {
          get
          {
            return OutcomeInstance;
          }
          set
          {
            OutcomeInstance = value;
          }
        }

        public double Outcome
        {
          get
          {
            return OutcomeInstance.Value;
          }
          set
          {
            OutcomeInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          OutcomeInstance = (Outcome)Create("Outcome");

        }

        public override void Run()
        {
//Outcome = IssueSeverity
        }

        public override double Duration
        {
          get
          {
//Normal distribution
//Values represent simulated time units, so are relative within the model context
double mean = 5;
double sigma = 1.2;
return Random.Normal(mean,sigma);
          }
        }

    }
}
