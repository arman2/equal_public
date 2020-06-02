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

        private EndOfQueue EndOfQueueInstance;

        public EndOfQueue EndOfQueueLink
        {
          get
          {
            return EndOfQueueInstance;
          }
          set
          {
            if (EndOfQueueInstance == value)
            {
              return;
            }
            EndOfQueueInstance = value;
            if (EndOfQueueInstance != null && EndOfQueueInstance.Role1 != this)
            {
              EndOfQueueInstance.Role1 = this;
            }
          }
        }

        public SmartRedundancySystemContext.SimpleJobServerContext.UniformJobQueue EndOfQueue
        {
          get
          {
            return EndOfQueueInstance.UniformJobQueue;
          }
          set
          {
            EndOfQueueInstance.UniformJobQueue = value;
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

double r = Random.Uniform();
        
if (r < SimpleJobServer.VolunteerNetwork.Volunteers.VolunteerReliability)
{
	SimpleJobServer.ReceivedResults[JobAssignment.JobId].Correct++;
}
else
{
	SimpleJobServer.ReceivedResults[JobAssignment.JobId].Incorrect++;
}

if (SimpleJobServer.ReceivedResults[JobAssignment.JobId].Correct -
	SimpleJobServer.ReceivedResults[JobAssignment.JobId].Incorrect >=
	SimpleJobServer.KParameter)
{
	SimpleJobServer.NumCorrect++;
	SimpleJobServer.PercentCorrect = SimpleJobServer.NumCorrect /
		((double)SimpleJobServer.NumCorrect + SimpleJobServer.NumIncorrect);
}
else if (SimpleJobServer.ReceivedResults[JobAssignment.JobId].Incorrect -
	SimpleJobServer.ReceivedResults[JobAssignment.JobId].Correct >=
	SimpleJobServer.KParameter)
{
	SimpleJobServer.NumIncorrect++;
	SimpleJobServer.PercentCorrect = SimpleJobServer.NumCorrect /
		((double)SimpleJobServer.NumCorrect + SimpleJobServer.NumIncorrect);
}
else
{
	UniformJob newJob = (UniformJob)SimpleJobServer.Create("UniformJob");
	newJob.JobId = JobAssignment.JobId;
	SimpleJobServer.UniformJobQueue.Enqueue(newJob);
}
        }

        public override double Duration
        {
          get
          {
return Random.Uniform();
          }
        }

    }
}
