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
    using HandleResultContext;

    public class HandleResult : DP_Method, DP_IMethod
    {
        public SimpleJobServer SimpleJobServer;

        private JobAssignment JobAssignmentInstance;

        public JobAssignment JobAssignmentData
        {
          get
          {
            return JobAssignmentInstance;
          }
          set
          {
            JobAssignmentInstance = value;
          }
        }

        public UniformJob JobAssignment
        {
          get
          {
            return JobAssignmentInstance.Value;
          }
          set
          {
            JobAssignmentInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          JobAssignmentInstance = (JobAssignment)Create("JobAssignment");

        }

        public override void Run()
        {
if (!SimpleJobServer.ReceivedResults.ContainsKey(JobAssignment.JobId))
SimpleJobServer.ReceivedResults.Add(JobAssignment.JobId, (Vote)SimpleJobServer.Create("Vote"));

double r = Model.Simulation.Simulator.Random;
        
if (r < SimpleJobServer.VolunteerNetwork.Volunteers.VolunteerReliability)
	SimpleJobServer.ReceivedResults[JobAssignment.JobId].Correct++;
else
	SimpleJobServer.ReceivedResults[JobAssignment.JobId].Incorrect++;

if (SimpleJobServer.ReceivedResults[JobAssignment.JobId].Correct +
	SimpleJobServer.ReceivedResults[JobAssignment.JobId].Incorrect ==
	SimpleJobServer.KParameter)
{
	if (SimpleJobServer.ReceivedResults[JobAssignment.JobId].Correct >= SimpleJobServer.KParameter / 2.0)
		SimpleJobServer.NumCorrect++;
	else if (SimpleJobServer.ReceivedResults[JobAssignment.JobId].Incorrect >= SimpleJobServer.KParameter / 2.0)
		SimpleJobServer.NumIncorrect++;
	SimpleJobServer.PercentCorrect = SimpleJobServer.NumCorrect /
		((double)SimpleJobServer.NumCorrect + SimpleJobServer.NumIncorrect);
}
        }

        public override double Duration
        {
          get
          {
return 1;
          }
        }

    }
}
