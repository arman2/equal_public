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

namespace Simulation.MonSysContext.AgentContext.PublisherCompContext
{
    using PublishContext;

    public class Publish : DP_Method, DP_IMethod
    {
        public PublisherComp PublisherComp;

        private newEvent newEventInstance;

        public newEvent newEventData
        {
          get
          {
            return newEventInstance;
          }
          set
          {
            newEventInstance = value;
          }
        }

        public PubMsg newEvent
        {
          get
          {
            return newEventInstance.Value;
          }
          set
          {
            newEventInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          newEventInstance = (newEvent)Create("newEvent");

        }

        public override void Run()
        {
// create PubSubMsg
newEvent = PublisherComp.Agent.MonSys.Create("PubMsg") as PubMsg;

// set situation id
if (PublisherComp.ProcEvents.Count > 0)
{
	newEvent.SituationId = PublisherComp.ProcEvents.Dequeue();
}
else
{	// set random situation id
	if (PublisherComp.PubType == 0 && PublisherComp.regTopic.IsPartOfHotspot)	{
		newEvent.SituationId =  PublisherComp.Agent.MonSys.HotSpotList[0].CurrHotSpotId;
	}
	else {
		newEvent.SituationId = 200+(int)Math.Floor(Random.Uniform()*10);
	}
}

// set topic
TopicRef tRef = PublisherComp.Agent.MonSys.Create("TopicRef") as TopicRef;
tRef.Topic = PublisherComp.regTopic;	
newEvent.TopicRefLink = tRef;
newEvent.Sender = PublisherComp;

PublisherComp.Agent.PubCount++;        }

        public override double Duration
        {
          get
          {
return 0.05;

          }
        }

    }
}
