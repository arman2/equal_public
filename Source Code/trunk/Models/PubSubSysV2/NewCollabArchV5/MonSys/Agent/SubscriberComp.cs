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
    using SubscriberCompContext;

    public class SubscriberComp : DP_Component, DP_IComponent
    {
        public Agent Agent;

        public System.Int32 NrEventSources
        {
          get { return ((Subscriber)Type).NrEventSources; }
        }

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

        public void Receive(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Receive");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private SubType SubTypeInstance;

        public SubType SubTypeData
        {
          get
          {
            return SubTypeInstance;
          }
          set
          {
            SubTypeInstance = value;
          }
        }

        public int SubType
        {
          get
          {
            return SubTypeInstance.Value;
          }
          set
          {
            SubTypeInstance.Value = value;
          }
        }

        private Subscriptions SubscriptionsInstance;

        public Subscriptions SubscriptionsData
        {
          get
          {
            return SubscriptionsInstance;
          }
          set
          {
            SubscriptionsInstance = value;
          }
        }

        public List<Topic> Subscriptions
        {
          get
          {
            return SubscriptionsInstance.Value;
          }
          set
          {
            SubscriptionsInstance.Value = value;
          }
        }

        private NewFocusOnObjConn NewFocusOnObjConnInstance;

        public NewFocusOnObjConn NewFocusOnObjConnLink
        {
          get
          {
            return NewFocusOnObjConnInstance;
          }
          set
          {
            if (NewFocusOnObjConnInstance == value)
            {
              return;
            }
            NewFocusOnObjConnInstance = value;
            if (NewFocusOnObjConnInstance != null && NewFocusOnObjConnInstance.Role1 != this)
            {
              NewFocusOnObjConnInstance.Role1 = this;
            }
          }
        }

        public MonSysContext.TopicGroup NewFocusOnObjConn
        {
          get
          {
            return NewFocusOnObjConnInstance.TopicGroup;
          }
          set
          {
            NewFocusOnObjConnInstance.TopicGroup = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          SubTypeInstance = (SubType)Create("SubType");
          SubscriptionsInstance = (Subscriptions)Create("Subscriptions");

            Startup();
        }

        public void Startup()
        {
Topic topic = null;
SubType = Agent.AgentType;
TopicGroup tg = null;
switch(SubType)
{
	case 0: //sensor, don't sub to anything
	break;
	case 1: // onsite staff	
		tg = Agent.MonSys.TopicGroupList[0];
// 		topic = Agent.MonSys.TopicList[0]; //from sensors
//		topic.Subscribers.Add(this);		
		break;
	case 2: // backoffice staff
		tg = Agent.MonSys.TopicGroupList[1];
		break;
	case 3: // backoffice team leader
		tg = Agent.MonSys.TopicGroupList[2];
		break;
	default: 	
		tg = Agent.MonSys.TopicGroupList[0];	
	break;
}
if (tg != null)
{	
	//int pos = (int)Random.Uint((uint)0,(uint)tg.Topics.Count);
	int pos = Agent.MonSys.AgentList.IndexOf(Agent);
	topic = tg.Topics[pos%tg.Topics.Count];
	topic.Subscribers.Add(this);
	topic.SubCount++;
	Subscriptions.Add(topic);
	int moreSubs = Math.Min(NrEventSources -1, tg.Topics.Count-1);	
	for (int i = 1; i <= moreSubs; i++)
	{
		topic = tg.Topics[(pos+i)%tg.Topics.Count];
		topic.Subscribers.Add(this);
		topic.SubCount++;
		Subscriptions.Add(topic);
	}
}
        }

    }
}
