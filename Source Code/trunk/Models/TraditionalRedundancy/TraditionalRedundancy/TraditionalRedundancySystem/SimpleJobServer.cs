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
    using SimpleJobServerContext;

    public class SimpleJobServer : DP_Component, DP_IComponent
    {
        public TraditionalRedundancySystem TraditionalRedundancySystem;

        private UniformJobQueue UniformJobQueueInstance;

        public UniformJobQueue UniformJobQueueData
        {
          get
          {
            return UniformJobQueueInstance;
          }
          set
          {
            UniformJobQueueInstance = value;
          }
        }

        public Queue<UniformJob> UniformJobQueue
        {
          get
          {
            return UniformJobQueueInstance.Value;
          }
          set
          {
            UniformJobQueueInstance.Value = value;
          }
        }

        public void SubdivideComp(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("SubdivideComp");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void CreateJobs(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("CreateJobs");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void GetNextJob(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("GetNextJob");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void HandleResult(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("HandleResult");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private List<UniformJob> UniformJobInstances = new List<UniformJob>();

        public List<UniformJob> UniformJobList
        {
          get
          {
            return UniformJobInstances;
          }
          set
          {
            UniformJobInstances = value;
          }
        }

        private List<Vote> VoteInstances = new List<Vote>();

        public List<Vote> VoteList
        {
          get
          {
            return VoteInstances;
          }
          set
          {
            VoteInstances = value;
          }
        }

        private NumTasks NumTasksInstance;

        public NumTasks NumTasksData
        {
          get
          {
            return NumTasksInstance;
          }
          set
          {
            NumTasksInstance = value;
          }
        }

        public int NumTasks
        {
          get
          {
            return NumTasksInstance.Value;
          }
          set
          {
            NumTasksInstance.Value = value;
          }
        }

        private ReceivedResults ReceivedResultsInstance;

        public ReceivedResults ReceivedResultsData
        {
          get
          {
            return ReceivedResultsInstance;
          }
          set
          {
            ReceivedResultsInstance = value;
          }
        }

        public Dictionary<int, Vote> ReceivedResults
        {
          get
          {
            return ReceivedResultsInstance.Value;
          }
          set
          {
            ReceivedResultsInstance.Value = value;
          }
        }

        private KParameter KParameterInstance;

        public KParameter KParameterData
        {
          get
          {
            return KParameterInstance;
          }
          set
          {
            KParameterInstance = value;
          }
        }

        public int KParameter
        {
          get
          {
            return KParameterInstance.Value;
          }
          set
          {
            KParameterInstance.Value = value;
          }
        }

        private NumCorrect NumCorrectInstance;

        public NumCorrect NumCorrectData
        {
          get
          {
            return NumCorrectInstance;
          }
          set
          {
            NumCorrectInstance = value;
          }
        }

        public int NumCorrect
        {
          get
          {
            return NumCorrectInstance.Value;
          }
          set
          {
            NumCorrectInstance.Value = value;
          }
        }

        private NumIncorrect NumIncorrectInstance;

        public NumIncorrect NumIncorrectData
        {
          get
          {
            return NumIncorrectInstance;
          }
          set
          {
            NumIncorrectInstance = value;
          }
        }

        public int NumIncorrect
        {
          get
          {
            return NumIncorrectInstance.Value;
          }
          set
          {
            NumIncorrectInstance.Value = value;
          }
        }

        public void AssignJob(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("AssignJob");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private PercentCorrect PercentCorrectInstance;

        public PercentCorrect PercentCorrectData
        {
          get
          {
            return PercentCorrectInstance;
          }
          set
          {
            PercentCorrectInstance = value;
          }
        }

        public double PercentCorrect
        {
          get
          {
            return PercentCorrectInstance.Value;
          }
          set
          {
            PercentCorrectInstance.Value = value;
          }
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
            if (NewProblemSubmissionInstance != null && NewProblemSubmissionInstance.Role2 != this)
            {
              NewProblemSubmissionInstance.Role2 = this;
            }
          }
        }

        public TraditionalRedundancySystemContext.Problem NewProblemSubmission
        {
          get
          {
            return NewProblemSubmissionInstance.Problem;
          }
          set
          {
            NewProblemSubmissionInstance.Problem = value;
          }
        }

        private VolunteerNetwork VolunteerNetworkInstance;
        public VolunteerNetwork VolunteerNetwork
        {
          get
          {
            return VolunteerNetworkInstance;
          }
          set
          {
            VolunteerNetworkInstance = value;
            if (VolunteerNetworkInstance != null && VolunteerNetworkInstance.Object != this)
            {
              VolunteerNetworkInstance.Object = this;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          UniformJobQueueInstance = (UniformJobQueue)Create("UniformJobQueue");
          NumTasksInstance = (NumTasks)Create("NumTasks");
          ReceivedResultsInstance = (ReceivedResults)Create("ReceivedResults");
          KParameterInstance = (KParameter)Create("KParameter");
          NumCorrectInstance = (NumCorrect)Create("NumCorrect");
          NumIncorrectInstance = (NumIncorrect)Create("NumIncorrect");
          PercentCorrectInstance = (PercentCorrect)Create("PercentCorrect");

            Startup();
        }

    }
}
