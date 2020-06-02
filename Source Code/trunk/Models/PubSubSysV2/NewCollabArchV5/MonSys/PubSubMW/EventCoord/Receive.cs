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
using Simulation.MonSysContext.PubSubMWContext;

namespace Simulation.MonSysContext.PubSubMWContext.EventCoordContext
{

    public class Receive : DP_Method, DP_IMethod
    {
        public EventCoord EventCoord;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
EventCoord.isIdle = false;
if (!EventCoord.isIdleInternal)
	return;
EventCoord.isIdleInternal = false;
int eventCounter = 0;
while (EventCoord.InQueue.Count > 0)
{
	eventCounter++;
	PubMsg msg = EventCoord.InQueue.Dequeue();
	Topic topic = msg.TopicRef;
	foreach (MonSysContext.AgentContext.SubscriberComp sub in topic.Subscribers)
	{
		NfyMsg exMsg;		
		if (EventCoord.EventDict.TryGetValue(sub, out exMsg))
		{
			exMsg.MsgList.Add(msg);
			//EventCoord.EventDict[sub] = exMsg;
		}
		else
		{
			exMsg = EventCoord.PubSubMW.MonSys.Create("NfyMsg") as NfyMsg;
			exMsg.MsgList.Add(msg);
			exMsg.Receiver = sub;
			EventCoord.EventDict.Add(sub,exMsg);
		}				
	}
}
EventCoord.PubSubMW.EventProcessed = eventCounter;
EventCoord.isIdleInternal = true;	
        }

        public override double Duration
        {
          get
          {
return EventCoord.PubSubMW.WorkExeDuration/EventCoord.ReadP;
          }
        }

    }
}
