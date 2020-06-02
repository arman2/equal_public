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

namespace Simulation
{
    using MonSysContext;

    public class MonSys : DP_Component, DP_IComponent
    {
        public System.Double SensorRatio
        {
          get { return ((CollabPattern)Type).SensorRatio; }
        }

        public System.Double FieldAgentRatio
        {
          get { return ((CollabPattern)Type).FieldAgentRatio; }
        }

        public System.Double BackOfficeRatio
        {
          get { return ((CollabPattern)Type).BackOfficeRatio; }
        }

        public System.Double TeamLeaderRatio
        {
          get { return ((CollabPattern)Type).TeamLeaderRatio; }
        }

        public System.UInt32 SeedU
        {
          get { return ((CollabPattern)Type).SeedU; }
        }

        public System.UInt32 SeedV
        {
          get { return ((CollabPattern)Type).SeedV; }
        }

        private List<Agent> AgentInstances = new List<Agent>();

        public List<Agent> AgentList
        {
          get
          {
            return AgentInstances;
          }
          set
          {
            AgentInstances = value;
          }
        }

        private List<PubSubMW> PubSubMWInstances = new List<PubSubMW>();

        public List<PubSubMW> PubSubMWList
        {
          get
          {
            return PubSubMWInstances;
          }
          set
          {
            PubSubMWInstances = value;
          }
        }

        private List<PubMsg> PubMsgInstances = new List<PubMsg>();

        public List<PubMsg> PubMsgList
        {
          get
          {
            return PubMsgInstances;
          }
          set
          {
            PubMsgInstances = value;
          }
        }

        private List<TopicRef> TopicRefInstances = new List<TopicRef>();

        public List<TopicRef> TopicRefList
        {
          get
          {
            return TopicRefInstances;
          }
          set
          {
            TopicRefInstances = value;
          }
        }

        private AgentTypeConfig AgentTypeConfigInstance;

        public AgentTypeConfig AgentTypeConfigData
        {
          get
          {
            return AgentTypeConfigInstance;
          }
          set
          {
            AgentTypeConfigInstance = value;
          }
        }

        public List<int> AgentTypeConfig
        {
          get
          {
            return AgentTypeConfigInstance.Value;
          }
          set
          {
            AgentTypeConfigInstance.Value = value;
          }
        }

        private List<HotSpot> HotSpotInstances = new List<HotSpot>();

        public List<HotSpot> HotSpotList
        {
          get
          {
            return HotSpotInstances;
          }
          set
          {
            HotSpotInstances = value;
          }
        }

        private AgentPubTopic AgentPubTopicInstance;

        public AgentPubTopic AgentPubTopicData
        {
          get
          {
            return AgentPubTopicInstance;
          }
          set
          {
            AgentPubTopicInstance = value;
          }
        }

        public List<Topic> AgentPubTopic
        {
          get
          {
            return AgentPubTopicInstance.Value;
          }
          set
          {
            AgentPubTopicInstance.Value = value;
          }
        }

        private List<NewFocusOnObjConn> NewFocusOnObjConnInstances = new List<NewFocusOnObjConn>();

        public List<NewFocusOnObjConn> NewFocusOnObjConnList
        {
          get
          {
            return NewFocusOnObjConnInstances;
          }
          set
          {
            NewFocusOnObjConnInstances = value;
          }
        }

        private List<NewObjectRefConnection> NewObjectRefConnectionInstances = new List<NewObjectRefConnection>();

        public List<NewObjectRefConnection> NewObjectRefConnectionList
        {
          get
          {
            return NewObjectRefConnectionInstances;
          }
          set
          {
            NewObjectRefConnectionInstances = value;
          }
        }

        private List<NewFocusOnObjConn1> NewFocusOnObjConn1Instances = new List<NewFocusOnObjConn1>();

        public List<NewFocusOnObjConn1> NewFocusOnObjConn1List
        {
          get
          {
            return NewFocusOnObjConn1Instances;
          }
          set
          {
            NewFocusOnObjConn1Instances = value;
          }
        }

        private List<TopicGroup> TopicGroupInstances = new List<TopicGroup>();

        public List<TopicGroup> TopicGroupList
        {
          get
          {
            return TopicGroupInstances;
          }
          set
          {
            TopicGroupInstances = value;
          }
        }

        private List<NfyMsg> NfyMsgInstances = new List<NfyMsg>();

        public List<NfyMsg> NfyMsgList
        {
          get
          {
            return NfyMsgInstances;
          }
          set
          {
            NfyMsgInstances = value;
          }
        }

        private List<Topic> TopicInstances = new List<Topic>();

        public List<Topic> TopicList
        {
          get
          {
            return TopicInstances;
          }
          set
          {
            TopicInstances = value;
          }
        }

        private EWMAFieldAgentLoad EWMAFieldAgentLoadInstance;

        public EWMAFieldAgentLoad EWMAFieldAgentLoadData
        {
          get
          {
            return EWMAFieldAgentLoadInstance;
          }
          set
          {
            EWMAFieldAgentLoadInstance = value;
          }
        }

        public double EWMAFieldAgentLoad
        {
          get
          {
            return EWMAFieldAgentLoadInstance.Value;
          }
          set
          {
            EWMAFieldAgentLoadInstance.Value = value;
          }
        }

        private EWMAOfficeAgentIdle EWMAOfficeAgentIdleInstance;

        public EWMAOfficeAgentIdle EWMAOfficeAgentIdleData
        {
          get
          {
            return EWMAOfficeAgentIdleInstance;
          }
          set
          {
            EWMAOfficeAgentIdleInstance = value;
          }
        }

        public double EWMAOfficeAgentIdle
        {
          get
          {
            return EWMAOfficeAgentIdleInstance.Value;
          }
          set
          {
            EWMAOfficeAgentIdleInstance.Value = value;
          }
        }

        private EWMAOfficeAgentLoad EWMAOfficeAgentLoadInstance;

        public EWMAOfficeAgentLoad EWMAOfficeAgentLoadData
        {
          get
          {
            return EWMAOfficeAgentLoadInstance;
          }
          set
          {
            EWMAOfficeAgentLoadInstance = value;
          }
        }

        public double EWMAOfficeAgentLoad
        {
          get
          {
            return EWMAOfficeAgentLoadInstance.Value;
          }
          set
          {
            EWMAOfficeAgentLoadInstance.Value = value;
          }
        }

        private EWMAFieldAgentIdle EWMAFieldAgentIdleInstance;

        public EWMAFieldAgentIdle EWMAFieldAgentIdleData
        {
          get
          {
            return EWMAFieldAgentIdleInstance;
          }
          set
          {
            EWMAFieldAgentIdleInstance = value;
          }
        }

        public double EWMAFieldAgentIdle
        {
          get
          {
            return EWMAFieldAgentIdleInstance.Value;
          }
          set
          {
            EWMAFieldAgentIdleInstance.Value = value;
          }
        }

        private EWMALeaderAgentIdle EWMALeaderAgentIdleInstance;

        public EWMALeaderAgentIdle EWMALeaderAgentIdleData
        {
          get
          {
            return EWMALeaderAgentIdleInstance;
          }
          set
          {
            EWMALeaderAgentIdleInstance = value;
          }
        }

        public double EWMALeaderAgentIdle
        {
          get
          {
            return EWMALeaderAgentIdleInstance.Value;
          }
          set
          {
            EWMALeaderAgentIdleInstance.Value = value;
          }
        }

        private EWMALeaderAgentLoad EWMALeaderAgentLoadInstance;

        public EWMALeaderAgentLoad EWMALeaderAgentLoadData
        {
          get
          {
            return EWMALeaderAgentLoadInstance;
          }
          set
          {
            EWMALeaderAgentLoadInstance = value;
          }
        }

        public double EWMALeaderAgentLoad
        {
          get
          {
            return EWMALeaderAgentLoadInstance.Value;
          }
          set
          {
            EWMALeaderAgentLoadInstance.Value = value;
          }
        }

        private List<AccessCoordinator> AccessCoordinatorInstances = new List<AccessCoordinator>();

        public List<AccessCoordinator> AccessCoordinatorList
        {
          get
          {
            return AccessCoordinatorInstances;
          }
          set
          {
            AccessCoordinatorInstances = value;
          }
        }

        private List<StatusArtifact> StatusArtifactInstances = new List<StatusArtifact>();

        public List<StatusArtifact> StatusArtifactList
        {
          get
          {
            return StatusArtifactInstances;
          }
          set
          {
            StatusArtifactInstances = value;
          }
        }

        private List<WorkingOnUpdate> WorkingOnUpdateInstances = new List<WorkingOnUpdate>();

        public List<WorkingOnUpdate> WorkingOnUpdateList
        {
          get
          {
            return WorkingOnUpdateInstances;
          }
          set
          {
            WorkingOnUpdateInstances = value;
          }
        }

        private List<SharedStatusArtifact> SharedStatusArtifactInstances = new List<SharedStatusArtifact>();

        public List<SharedStatusArtifact> SharedStatusArtifactList
        {
          get
          {
            return SharedStatusArtifactInstances;
          }
          set
          {
            SharedStatusArtifactInstances = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          AgentTypeConfigInstance = (AgentTypeConfig)Create("AgentTypeConfig");
          AgentPubTopicInstance = (AgentPubTopic)Create("AgentPubTopic");
          EWMAFieldAgentLoadInstance = (EWMAFieldAgentLoad)Create("EWMAFieldAgentLoad");
          EWMAOfficeAgentIdleInstance = (EWMAOfficeAgentIdle)Create("EWMAOfficeAgentIdle");
          EWMAOfficeAgentLoadInstance = (EWMAOfficeAgentLoad)Create("EWMAOfficeAgentLoad");
          EWMAFieldAgentIdleInstance = (EWMAFieldAgentIdle)Create("EWMAFieldAgentIdle");
          EWMALeaderAgentIdleInstance = (EWMALeaderAgentIdle)Create("EWMALeaderAgentIdle");
          EWMALeaderAgentLoadInstance = (EWMALeaderAgentLoad)Create("EWMALeaderAgentLoad");

            Startup();
        }

        public void Startup()
        {
if (SeedU > 0 && SeedV > 0)
{
	Random.Seed(SeedU, SeedV);
}

TopicGroup topicG0 = Create("TopicGroup") as TopicGroup;
topicG0.GroupNameId = "Sensor";
TopicGroup topicG1 = Create("TopicGroup") as TopicGroup;
topicG1.GroupNameId = "FieldAgent";
TopicGroup topicG2 = Create("TopicGroup") as TopicGroup;
topicG2.GroupNameId = "BackOfficeAgent";
TopicGroup topicG3 = Create("TopicGroup") as TopicGroup;
topicG3.GroupNameId = "BackOfficeLeader";


Topic topic = null; //Create("Topic") as Topic;
//topic.TopicNameId = "Sensor";
//topic = Create("Topic") as Topic;
//topic.TopicNameId = "FieldAgent";

// List of Object DPStartInstance : Model.Simulation.StartInstances
// public List<DP_StartInstance> StartInstances
// Type == Agent, read count value
int total = 0;
foreach (DP_StartInstance si in Model.Simulation.StartInstances)
{
	if (si.Type == "MonSys")
	{
		foreach (DP_StartInstance i in si.Instances) {	
		if (i.Type == "Agent")
		{
			total = i.Count;
			break;
		}}
	}
}
// for now, generate only sensors, field agents, and backoffice agents
//int total = AgentList.Count;
if (total <= 0)
	total = 1111;
//DomainProAnalyst.Instance.Report("Nr of Agents:"+total);
int sensorC = Math.Min((int)Math.Floor(total*SensorRatio),(int)Math.Floor(total-3d));
DomainProAnalyst.Instance.Report("Nr of Sensors: "+ sensorC);

int fieldC = Math.Max(1,Math.Min((int)Math.Floor(total*FieldAgentRatio),(int)Math.Floor(total-2d)));
DomainProAnalyst.Instance.Report("Nr of FieldAgents: "+ fieldC);

int officeC = Math.Max(1,Math.Min((int)Math.Floor(total*BackOfficeRatio),(int)Math.Floor(total-1d)));
DomainProAnalyst.Instance.Report("Nr of OfficeAgents: "+ officeC);

int leaderC = Math.Max(1,(int)Math.Floor(total*TeamLeaderRatio));
DomainProAnalyst.Instance.Report("Nr of LeaderAgents: "+ leaderC);

List<StatusArtifact> artifacts = new List<StatusArtifact>();
StatusArtifact sa = null; 

Queue<int> groupSizes = new Queue<int>();
groupSizes.Enqueue(sensorC); 
groupSizes.Enqueue(fieldC); 
groupSizes.Enqueue(officeC); 
groupSizes.Enqueue(leaderC); 

Queue<List<Topic>> topics = new Queue<List<Topic>>();
List<Topic> sensorTopics = new List<Topic>();
int tc = Math.Max(1,(int)(total*SensorRatio/20));
DomainProAnalyst.Instance.Report("Nr of SensorTopics: "+ tc);
for (int j=0; j<tc; j++)
{
	topic = Create("Topic") as Topic;
	topic.PubCount = 0;
	topic.SubCount = 0;
	topic.TopicNameId = "SensorGroup"+j;
	sensorTopics.Add(topic);
	topicG0.Topics.Add(topic);
	sa = Create("StatusArtifact") as StatusArtifact;
	artifacts.Add(sa);
}
	topics.Enqueue(sensorTopics);
List<Topic> fieldTopics = new List<Topic>();
tc = Math.Max(1,(int)(total*FieldAgentRatio/10));
DomainProAnalyst.Instance.Report("Nr of FieldTopics: "+ tc);
for (int j=0; j<tc; j++)
{
	topic = Create("Topic") as Topic;
	topic.PubCount = 0;
	topic.SubCount = 0;
	topic.TopicNameId = "FieldAgentGroup"+j;
	fieldTopics.Add(topic);
	topicG1.Topics.Add(topic);
	sa = Create("StatusArtifact") as StatusArtifact;
	artifacts.Add(sa);
}
	topics.Enqueue(fieldTopics);
List<Topic> officeTopics = new List<Topic>();
	topic = Create("Topic") as Topic;
	topic.PubCount = 0;
	topic.SubCount = 0;
	topic.TopicNameId = "BackOfficeAgent";
	officeTopics.Add(topic);
	topicG2.Topics.Add(topic);
	topics.Enqueue(officeTopics);
	sa = Create("StatusArtifact") as StatusArtifact;
	artifacts.Add(sa);
DomainProAnalyst.Instance.Report("Nr of OfficeTopics: "+ officeTopics.Count);

List<Topic> leaderTopics = new List<Topic>();
	topic = Create("Topic") as Topic;
	topic.PubCount = 0;
	topic.SubCount = 0;
	topic.TopicNameId = "BackOfficeLeader";
	leaderTopics.Add(topic);
	topicG3.Topics.Add(topic);
	topics.Enqueue(leaderTopics);
	sa = Create("StatusArtifact") as StatusArtifact;
	artifacts.Add(sa);
DomainProAnalyst.Instance.Report("Nr of LeaderTopics: "+ leaderTopics.Count);


DomainProAnalyst.Instance.Report("Nr of Topics: "+ TopicList.Count);
DomainProAnalyst.Instance.Report("Nr of Artifacts: "+ StatusArtifactList.Count);


List<Topic> group = topics.Dequeue();
int type = 0;
int count = 0;
int limit = groupSizes.Dequeue();
int rotate = 0;
for (int i=0; i<total; i++)
{
	while (count >= limit && groupSizes.Count > 0 && topics.Count > 0)
	{
		rotate = 0;
		type++;
		group = topics.Dequeue();
		limit += groupSizes.Dequeue();
	}		
	AgentTypeConfig.Add(type);
	AgentPubTopic.Add(group[rotate%group.Count]);
	rotate++;
	count++;		
}



        }

    }
}
