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

namespace Simulation.MonSysContext
{
    using AgentContext;

    public class Agent : DP_Component, DP_IComponent
    {
        public MonSys MonSys;

        public System.Double WorkExeDuration
        {
          get { return ((Collaborator)Type).WorkExeDuration; }
        }

        public System.Double EWMAalpha
        {
          get { return ((Collaborator)Type).EWMAalpha; }
        }

        private LastEventAmount LastEventAmountInstance;

        public LastEventAmount LastEventAmountData
        {
          get
          {
            return LastEventAmountInstance;
          }
          set
          {
            LastEventAmountInstance = value;
          }
        }

        public int LastEventAmount
        {
          get
          {
            return LastEventAmountInstance.Value;
          }
          set
          {
            LastEventAmountInstance.Value = value;
          }
        }

        private NfyCount NfyCountInstance;

        public NfyCount NfyCountData
        {
          get
          {
            return NfyCountInstance;
          }
          set
          {
            NfyCountInstance = value;
          }
        }

        public int NfyCount
        {
          get
          {
            return NfyCountInstance.Value;
          }
          set
          {
            NfyCountInstance.Value = value;
          }
        }

        private PubCount PubCountInstance;

        public PubCount PubCountData
        {
          get
          {
            return PubCountInstance;
          }
          set
          {
            PubCountInstance = value;
          }
        }

        public int PubCount
        {
          get
          {
            return PubCountInstance.Value;
          }
          set
          {
            PubCountInstance.Value = value;
          }
        }

        private ProcessingWork ProcessingWorkInstance;

        public ProcessingWork ProcessingWorkData
        {
          get
          {
            return ProcessingWorkInstance;
          }
          set
          {
            ProcessingWorkInstance = value;
          }
        }

        public double ProcessingWork
        {
          get
          {
            return ProcessingWorkInstance.Value;
          }
          set
          {
            ProcessingWorkInstance.Value = value;
          }
        }

        private AgentType AgentTypeInstance;

        public AgentType AgentTypeData
        {
          get
          {
            return AgentTypeInstance;
          }
          set
          {
            AgentTypeInstance = value;
          }
        }

        public int AgentType
        {
          get
          {
            return AgentTypeInstance.Value;
          }
          set
          {
            AgentTypeInstance.Value = value;
          }
        }

        private WorkOverLoad WorkOverLoadInstance;

        public WorkOverLoad WorkOverLoadData
        {
          get
          {
            return WorkOverLoadInstance;
          }
          set
          {
            WorkOverLoadInstance = value;
          }
        }

        public double WorkOverLoad
        {
          get
          {
            return WorkOverLoadInstance.Value;
          }
          set
          {
            WorkOverLoadInstance.Value = value;
          }
        }

        private EWMAvgWorkOverLoad EWMAvgWorkOverLoadInstance;

        public EWMAvgWorkOverLoad EWMAvgWorkOverLoadData
        {
          get
          {
            return EWMAvgWorkOverLoadInstance;
          }
          set
          {
            EWMAvgWorkOverLoadInstance = value;
          }
        }

        public double EWMAvgWorkOverLoad
        {
          get
          {
            return EWMAvgWorkOverLoadInstance.Value;
          }
          set
          {
            EWMAvgWorkOverLoadInstance.Value = value;
          }
        }

        private IdleCapacity IdleCapacityInstance;

        public IdleCapacity IdleCapacityData
        {
          get
          {
            return IdleCapacityInstance;
          }
          set
          {
            IdleCapacityInstance = value;
          }
        }

        public double IdleCapacity
        {
          get
          {
            return IdleCapacityInstance.Value;
          }
          set
          {
            IdleCapacityInstance.Value = value;
          }
        }

        private UpdateConflictPerWrite UpdateConflictPerWriteInstance;

        public UpdateConflictPerWrite UpdateConflictPerWriteData
        {
          get
          {
            return UpdateConflictPerWriteInstance;
          }
          set
          {
            UpdateConflictPerWriteInstance = value;
          }
        }

        public int UpdateConflictPerWrite
        {
          get
          {
            return UpdateConflictPerWriteInstance.Value;
          }
          set
          {
            UpdateConflictPerWriteInstance.Value = value;
          }
        }

        private List<EventProcesser> EventProcesserInstances = new List<EventProcesser>();

        public List<EventProcesser> EventProcesserList
        {
          get
          {
            return EventProcesserInstances;
          }
          set
          {
            EventProcesserInstances = value;
          }
        }

        private List<SubscriberComp> SubscriberCompInstances = new List<SubscriberComp>();

        public List<SubscriberComp> SubscriberCompList
        {
          get
          {
            return SubscriberCompInstances;
          }
          set
          {
            SubscriberCompInstances = value;
          }
        }

        private UpdateCount UpdateCountInstance;

        public UpdateCount UpdateCountData
        {
          get
          {
            return UpdateCountInstance;
          }
          set
          {
            UpdateCountInstance = value;
          }
        }

        public int UpdateCount
        {
          get
          {
            return UpdateCountInstance.Value;
          }
          set
          {
            UpdateCountInstance.Value = value;
          }
        }

        private List<Contributor> ContributorInstances = new List<Contributor>();

        public List<Contributor> ContributorList
        {
          get
          {
            return ContributorInstances;
          }
          set
          {
            ContributorInstances = value;
          }
        }

        private List<PublisherComp> PublisherCompInstances = new List<PublisherComp>();

        public List<PublisherComp> PublisherCompList
        {
          get
          {
            return PublisherCompInstances;
          }
          set
          {
            PublisherCompInstances = value;
          }
        }

        private UpdateConflictSum UpdateConflictSumInstance;

        public UpdateConflictSum UpdateConflictSumData
        {
          get
          {
            return UpdateConflictSumInstance;
          }
          set
          {
            UpdateConflictSumInstance = value;
          }
        }

        public int UpdateConflictSum
        {
          get
          {
            return UpdateConflictSumInstance.Value;
          }
          set
          {
            UpdateConflictSumInstance.Value = value;
          }
        }

        private DoUpdateArtifact DoUpdateArtifactInstance;

        public DoUpdateArtifact DoUpdateArtifactData
        {
          get
          {
            return DoUpdateArtifactInstance;
          }
          set
          {
            DoUpdateArtifactInstance = value;
          }
        }

        public bool DoUpdateArtifact
        {
          get
          {
            return DoUpdateArtifactInstance.Value;
          }
          set
          {
            DoUpdateArtifactInstance.Value = value;
          }
        }

        private DoDropOverload DoDropOverloadInstance;

        public DoDropOverload DoDropOverloadData
        {
          get
          {
            return DoDropOverloadInstance;
          }
          set
          {
            DoDropOverloadInstance = value;
          }
        }

        public bool DoDropOverload
        {
          get
          {
            return DoDropOverloadInstance.Value;
          }
          set
          {
            DoDropOverloadInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          LastEventAmountInstance = (LastEventAmount)Create("LastEventAmount");
          NfyCountInstance = (NfyCount)Create("NfyCount");
          PubCountInstance = (PubCount)Create("PubCount");
          ProcessingWorkInstance = (ProcessingWork)Create("ProcessingWork");
          AgentTypeInstance = (AgentType)Create("AgentType");
          WorkOverLoadInstance = (WorkOverLoad)Create("WorkOverLoad");
          EWMAvgWorkOverLoadInstance = (EWMAvgWorkOverLoad)Create("EWMAvgWorkOverLoad");
          IdleCapacityInstance = (IdleCapacity)Create("IdleCapacity");
          UpdateConflictPerWriteInstance = (UpdateConflictPerWrite)Create("UpdateConflictPerWrite");
          UpdateCountInstance = (UpdateCount)Create("UpdateCount");
          UpdateConflictSumInstance = (UpdateConflictSum)Create("UpdateConflictSum");
          DoUpdateArtifactInstance = (DoUpdateArtifact)Create("DoUpdateArtifact");
          DoDropOverloadInstance = (DoDropOverload)Create("DoDropOverload");

            Startup();
        }

        public void Startup()
        {
int pos = MonSys.AgentList.IndexOf(this);
if (pos != -1 && pos < MonSys.AgentTypeConfig.Count)
{
	AgentType = MonSys.AgentTypeConfig[pos];
}
else
{
	AgentType = 0;
}

        }

    }
}
