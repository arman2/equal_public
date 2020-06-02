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
using Simulation.MonSysContext.AgentContext;

namespace Simulation.MonSysContext.AgentContext.SubscriberContext
{
    using ReceiveContext;

    public class Receive : DP_Method, DP_IMethod
    {
        public Subscriber Subscriber;

        private notification notificationInstance;

        public notification notificationData
        {
          get
          {
            return notificationInstance;
          }
          set
          {
            notificationInstance = value;
          }
        }

        public NfyMsg notification
        {
          get
          {
            return notificationInstance.Value;
          }
          set
          {
            notificationInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          notificationInstance = (notification)Create("notification");

        }

        public override void Run()
        {
Subscriber.Agent.NfyCount++;
Subscriber.Agent.LastEventAmount = notification.MsgList.Count;

switch(Subscriber.SubType)
{
	case 0: //sensor, don't do anything
	break;
	case 1: // onsite staff	
		foreach (PubMsg msg in notification.MsgList)
		{
			Subscriber.Agent.EventProcesserList[0].InEvents.Enqueue(msg);	
		}
		break;
 	case 2: // backoffice staff
			foreach (PubMsg msg in notification.MsgList)
		{
			Subscriber.Agent.MasterList[0].InEvents.Enqueue(msg);	
		}
		break;
	case 3: // backoffice team leader
		foreach (PubMsg msg in notification.MsgList)
		{
			Subscriber.Agent.EventProcesserList[0].InEvents.Enqueue(msg);	
		}
		break;
	default: 	
	break;
}        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
