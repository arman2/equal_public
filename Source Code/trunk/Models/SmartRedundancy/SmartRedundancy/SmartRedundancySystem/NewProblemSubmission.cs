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

    public class NewProblemSubmission : DP_Link, DP_ILink
    {
        public SmartRedundancySystem SmartRedundancySystem;

        private SmartRedundancySystemContext.Problem ProblemInstance;

        public SmartRedundancySystemContext.Problem Problem
        {
          get
          {
            return ProblemInstance;
          }
          set
          {
            ProblemInstance = (SmartRedundancySystemContext.Problem)value;
            if (Role1 != value)
            {
              Role1 = value;
            }
          }
        }

        private SmartRedundancySystemContext.SimpleJobServer SimpleJobServerInstance;

        public SmartRedundancySystemContext.SimpleJobServer SimpleJobServer
        {
          get
          {
            return SimpleJobServerInstance;
          }
          set
          {
            SimpleJobServerInstance = (SmartRedundancySystemContext.SimpleJobServer)value;
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
