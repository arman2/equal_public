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
using Simulation.MonSysContext;

namespace Simulation.MonSysContext.AgentContext
{
    using ContributorContext;

    public class Contributor : DP_Component, DP_IComponent
    {
        public Agent Agent;

        public System.Double CreateP
        {
          get { return ((Role)Type).CreateP; }
        }

        public System.Double ReadP
        {
          get { return ((Role)Type).ReadP; }
        }

        public System.Double UpdateP
        {
          get { return ((Role)Type).UpdateP; }
        }

        public System.Double DeleteP
        {
          get { return ((Role)Type).DeleteP; }
        }

        public System.Double IdleP
        {
          get { return ((Role)Type).IdleP; }
        }

        public void UpdateStatus(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("UpdateStatus");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void ReadFeedback(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("ReadFeedback");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private ArtifactVersion ArtifactVersionInstance;

        public ArtifactVersion ArtifactVersionData
        {
          get
          {
            return ArtifactVersionInstance;
          }
          set
          {
            ArtifactVersionInstance = value;
          }
        }

        public int ArtifactVersion
        {
          get
          {
            return ArtifactVersionInstance.Value;
          }
          set
          {
            ArtifactVersionInstance.Value = value;
          }
        }

        private WriteTries WriteTriesInstance;

        public WriteTries WriteTriesData
        {
          get
          {
            return WriteTriesInstance;
          }
          set
          {
            WriteTriesInstance = value;
          }
        }

        public int WriteTries
        {
          get
          {
            return WriteTriesInstance.Value;
          }
          set
          {
            WriteTriesInstance.Value = value;
          }
        }

        private WorkingOnUpdate WorkingOnUpdateInstance;

        public WorkingOnUpdate WorkingOnUpdateLink
        {
          get
          {
            return WorkingOnUpdateInstance;
          }
          set
          {
            if (WorkingOnUpdateInstance == value)
            {
              return;
            }
            WorkingOnUpdateInstance = value;
            if (WorkingOnUpdateInstance != null && WorkingOnUpdateInstance.Role1 != this)
            {
              WorkingOnUpdateInstance.Role1 = this;
            }
          }
        }

        public MonSysContext.StatusArtifactContext.Update WorkingOnUpdate
        {
          get
          {
            return WorkingOnUpdateInstance.Update;
          }
          set
          {
            WorkingOnUpdateInstance.Update = value;
          }
        }

        private SharedStatusArtifact SharedStatusArtifactInstance;

        public SharedStatusArtifact SharedStatusArtifactLink
        {
          get
          {
            return SharedStatusArtifactInstance;
          }
          set
          {
            if (SharedStatusArtifactInstance == value)
            {
              return;
            }
            SharedStatusArtifactInstance = value;
            if (SharedStatusArtifactInstance != null && SharedStatusArtifactInstance.Role1 != this)
            {
              SharedStatusArtifactInstance.Role1 = this;
            }
          }
        }

        public MonSysContext.StatusArtifact SharedStatusArtifact
        {
          get
          {
            return SharedStatusArtifactInstance.StatusArtifact;
          }
          set
          {
            SharedStatusArtifactInstance.StatusArtifact = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          ArtifactVersionInstance = (ArtifactVersion)Create("ArtifactVersion");
          WriteTriesInstance = (WriteTries)Create("WriteTries");

            Startup();
        }

        public void Startup()
        {
SharedStatusArtifactLink = Agent.MonSys.Create("SharedStatusArtifact") as SharedStatusArtifact;
WorkingOnUpdateLink = Agent.MonSys.Create("WorkingOnUpdate") as WorkingOnUpdate;

// more init code to set the link to an actual shared artifact
int pos = Agent.MonSys.AgentList.IndexOf(Agent);
if (pos != -1 && pos < Agent.MonSys.AgentPubTopic.Count)
{
	Topic topic = Agent.MonSys.AgentPubTopic[pos];	
	int posSA = Agent.MonSys.TopicList.IndexOf(topic);
	SharedStatusArtifact = Agent.MonSys.StatusArtifactList[posSA];
}
else
{
	SharedStatusArtifact = Agent.MonSys.StatusArtifactList[0];
}
        }

    }
}
