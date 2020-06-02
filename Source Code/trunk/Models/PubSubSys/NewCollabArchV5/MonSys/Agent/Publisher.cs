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
    using PublisherContext;

    public class Publisher : DP_Component, DP_IComponent
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

        public void Publish(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Publish");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private regTopic regTopicInstance;

        public regTopic regTopicData
        {
          get
          {
            return regTopicInstance;
          }
          set
          {
            regTopicInstance = value;
          }
        }

        public Topic regTopic
        {
          get
          {
            return regTopicInstance.Value;
          }
          set
          {
            regTopicInstance.Value = value;
          }
        }

        public void NextStep(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("NextStep");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private PubType PubTypeInstance;

        public PubType PubTypeData
        {
          get
          {
            return PubTypeInstance;
          }
          set
          {
            PubTypeInstance = value;
          }
        }

        public int PubType
        {
          get
          {
            return PubTypeInstance.Value;
          }
          set
          {
            PubTypeInstance.Value = value;
          }
        }

        public void Idle(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Idle");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private ProcEvents ProcEventsInstance;

        public ProcEvents ProcEventsData
        {
          get
          {
            return ProcEventsInstance;
          }
          set
          {
            ProcEventsInstance = value;
          }
        }

        public Queue<int> ProcEvents
        {
          get
          {
            return ProcEventsInstance.Value;
          }
          set
          {
            ProcEventsInstance.Value = value;
          }
        }

        private NewFocusOnObjConn2 NewFocusOnObjConn2Instance;

        public NewFocusOnObjConn2 NewFocusOnObjConn2Link
        {
          get
          {
            return NewFocusOnObjConn2Instance;
          }
          set
          {
            if (NewFocusOnObjConn2Instance == value)
            {
              return;
            }
            NewFocusOnObjConn2Instance = value;
            if (NewFocusOnObjConn2Instance != null && NewFocusOnObjConn2Instance.Role1 != this)
            {
              NewFocusOnObjConn2Instance.Role1 = this;
            }
          }
        }

        public MonSysContext.Topic NewFocusOnObjConn2
        {
          get
          {
            return NewFocusOnObjConn2Instance.Topic;
          }
          set
          {
            NewFocusOnObjConn2Instance.Topic = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          regTopicInstance = (regTopic)Create("regTopic");
          PubTypeInstance = (PubType)Create("PubType");
          ProcEventsInstance = (ProcEvents)Create("ProcEvents");

            Startup();
        }

        public void Startup()
        {
PubType = Agent.AgentType;

int pos = Agent.MonSys.AgentList.IndexOf(Agent);
if (pos != -1 && pos < Agent.MonSys.AgentPubTopic.Count)
{
	regTopic = Agent.MonSys.AgentPubTopic[pos];	
}
else
{
	regTopic = Agent.MonSys.TopicList[0];
}
regTopic.Publishers.Add(this);
regTopic.PubCount++;

//switch(PubType)
//{
//	case 0: //sensor
//		regTopic = Agent.MonSys.TopicList[0];
//		regTopic.Publishers.Add(this);
//	break;
//	case 1: // onsite staff	
// 		regTopic = Agent.MonSys.TopicList[1];
//		regTopic.Publishers.Add(this);
//		break;
//	case 2: // backoffice staff
//		regTopic = Agent.MonSys.TopicList[2];
//		regTopic.Publishers.Add(this);
//		break;
//	case 3: // backoffice team leader
//		regTopic = Agent.MonSys.TopicList[3];
//		regTopic.Publishers.Add(this);
//		break;
//	default: 
//		
//	break;
//}
;        }

    }
}
