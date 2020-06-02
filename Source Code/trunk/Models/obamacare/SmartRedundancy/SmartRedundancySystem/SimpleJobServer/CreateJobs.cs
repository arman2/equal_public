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
using Simulation.SmartRedundancySystemContext;

namespace Simulation.SmartRedundancySystemContext.SimpleJobServerContext
{

    public class CreateJobs : DP_Method, DP_IMethod
    {
        public SimpleJobServer SimpleJobServer;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
SimpleJobServer.NumCorrect = 0;
SimpleJobServer.NumIncorrect = 0;
SimpleJobServer.UniformJobQueue.Clear();

for (int i = 0; i < SimpleJobServer.NumTasks; i++)
{
	UniformJob newJob = (UniformJob)SimpleJobServer.Create("UniformJob");
	newJob.JobId = i;
	SimpleJobServer.UniformJobQueue.Enqueue(newJob);
}
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
