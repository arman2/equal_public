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

namespace Simulation.TraditionalRedundancySystemContext
{

    public class NewProblemSubmission : DP_Link, DP_ILink
    {
        public TraditionalRedundancySystem TraditionalRedundancySystem;

        private TraditionalRedundancySystemContext.Problem ProblemInstance;

        public TraditionalRedundancySystemContext.Problem Problem
        {
          get
          {
            return ProblemInstance;
          }
          set
          {
            ProblemInstance = (TraditionalRedundancySystemContext.Problem)value;
            if (Role1 != value)
            {
              Role1 = value;
            }
          }
        }

        private TraditionalRedundancySystemContext.SimpleJobServer SimpleJobServerInstance;

        public TraditionalRedundancySystemContext.SimpleJobServer SimpleJobServer
        {
          get
          {
            return SimpleJobServerInstance;
          }
          set
          {
            SimpleJobServerInstance = (TraditionalRedundancySystemContext.SimpleJobServer)value;
            if (Role2 != value)
            {
              Role2 = value;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
