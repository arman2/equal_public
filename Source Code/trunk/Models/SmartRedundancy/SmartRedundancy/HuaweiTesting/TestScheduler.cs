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

namespace Simulation.HuaweiTestingContext
{
    using TestSchedulerContext;

    public class TestScheduler : DP_Component, DP_IComponent
    {
        public HuaweiTesting HuaweiTesting;

        private UniformTestQueue UniformTestQueueInstance;

        public UniformTestQueue UniformTestQueueData
        {
          get
          {
            return UniformTestQueueInstance;
          }
          set
          {
            UniformTestQueueInstance = value;
          }
        }

        public Queue<UniformJob> UniformTestQueue
        {
          get
          {
            return UniformTestQueueInstance.Value;
          }
          set
          {
            UniformTestQueueInstance.Value = value;
          }
        }

        public void GenerateTests(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("GenerateTests");
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

        private List<FrontOfQueue> FrontOfQueueInstances = new List<FrontOfQueue>();

        public List<FrontOfQueue> FrontOfQueueList
        {
          get
          {
            return FrontOfQueueInstances;
          }
          set
          {
            FrontOfQueueInstances = value;
          }
        }

        private List<EndOfQueue> EndOfQueueInstances = new List<EndOfQueue>();

        public List<EndOfQueue> EndOfQueueList
        {
          get
          {
            return EndOfQueueInstances;
          }
          set
          {
            EndOfQueueInstances = value;
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

        private List<NewTestDefinition1> NewTestDefinition1Instances = new List<NewTestDefinition1>();

        public List<NewTestDefinition1> NewTestDefinition1List
        {
          get
          {
            return NewTestDefinition1Instances;
          }
          set
          {
            NewTestDefinition1Instances = value;
          }
        }

        private List<NewTestDefinition2> NewTestDefinition2Instances = new List<NewTestDefinition2>();

        public List<NewTestDefinition2> NewTestDefinition2List
        {
          get
          {
            return NewTestDefinition2Instances;
          }
          set
          {
            NewTestDefinition2Instances = value;
          }
        }

        private Network1 Network1Instance;
        public Network1 Network1
        {
          get
          {
            return Network1Instance;
          }
          set
          {
            Network1Instance = value;
            if (Network1Instance != null && Network1Instance.Object != this)
            {
              Network1Instance.Object = this;
            }
          }
        }

        private Network2 Network2Instance;
        public Network2 Network2
        {
          get
          {
            return Network2Instance;
          }
          set
          {
            Network2Instance = value;
            if (Network2Instance != null && Network2Instance.Object != this)
            {
              Network2Instance.Object = this;
            }
          }
        }

        private NewNetwork NewNetworkInstance;
        public NewNetwork NewNetwork
        {
          get
          {
            return NewNetworkInstance;
          }
          set
          {
            NewNetworkInstance = value;
            if (NewNetworkInstance != null && NewNetworkInstance.Object != this)
            {
              NewNetworkInstance.Object = this;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          UniformTestQueueInstance = (UniformTestQueue)Create("UniformTestQueue");
          NumTasksInstance = (NumTasks)Create("NumTasks");
          ReceivedResultsInstance = (ReceivedResults)Create("ReceivedResults");
          KParameterInstance = (KParameter)Create("KParameter");
          NumCorrectInstance = (NumCorrect)Create("NumCorrect");
          NumIncorrectInstance = (NumIncorrect)Create("NumIncorrect");
          PercentCorrectInstance = (PercentCorrect)Create("PercentCorrect");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
