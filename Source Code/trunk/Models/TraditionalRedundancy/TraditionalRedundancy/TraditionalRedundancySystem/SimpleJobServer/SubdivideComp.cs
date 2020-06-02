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
using Simulation.TraditionalRedundancySystemContext;

namespace Simulation.TraditionalRedundancySystemContext.SimpleJobServerContext
{

    public class SubdivideComp : DP_Method, DP_IMethod
    {
        public SimpleJobServer SimpleJobServer;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
SimpleJobServer.NumTasks = SimpleJobServer.NewProblemSubmission.ComputationSize;
SimpleJobServer.KParameter = SimpleJobServer.NewProblemSubmission.RequiredConfidence;
        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
