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
    using PatientArrivalContext;

    public class PatientArrival : DP_Method, DP_IMethod
    {
        public PatientFlow PatientFlow;

        private IssueSeverity IssueSeverityInstance;

        public IssueSeverity IssueSeverityData
        {
          get
          {
            return IssueSeverityInstance;
          }
          set
          {
            IssueSeverityInstance = value;
          }
        }

        public double IssueSeverity
        {
          get
          {
            return IssueSeverityInstance.Value;
          }
          set
          {
            IssueSeverityInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          IssueSeverityInstance = (IssueSeverity)Create("IssueSeverity");

        }

        public override void Run()
        {
//Creates new patients
IssueSeverity = Random.Uniform(0,1);        }

        public override double Duration
        {
          get
          {
return Random.Uniform(0,60);
          }
        }

    }
}
