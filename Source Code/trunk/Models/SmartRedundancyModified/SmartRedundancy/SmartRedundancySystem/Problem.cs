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

namespace Simulation.SmartRedundancySystemContext
{

    public class Problem : DP_Component, DP_IComponent
    {
        public SmartRedundancySystem SmartRedundancySystem;

        public System.Int32 ComputationSize
        {
          get { return ((ProblemSpec)Type).ComputationSize; }
        }

        public System.Int32 RequiredConfidence
        {
          get { return ((ProblemSpec)Type).RequiredConfidence; }
        }

        private NewProblemSubmission NewProblemSubmissionInstance;

        public NewProblemSubmission NewProblemSubmissionLink
        {
          get
          {
            return NewProblemSubmissionInstance;
          }
          set
          {
            if (NewProblemSubmissionInstance == value)
            {
              return;
            }
            NewProblemSubmissionInstance = value;
            if (NewProblemSubmissionInstance != null && NewProblemSubmissionInstance.Role1 != this)
            {
              NewProblemSubmissionInstance.Role1 = this;
            }
          }
        }

        public SmartRedundancySystemContext.SimpleJobServer NewProblemSubmission
        {
          get
          {
            return NewProblemSubmissionInstance.SimpleJobServer;
          }
          set
          {
            NewProblemSubmissionInstance.SimpleJobServer = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();


            Startup();
        }

        public void Startup()
        {
        }

    }
}
