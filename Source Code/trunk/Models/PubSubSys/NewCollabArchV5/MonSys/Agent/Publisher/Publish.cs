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

namespace Simulation.MonSysContext.AgentContext.PublisherContext
{
    using PublishContext;

    public class Publish : DP_Method, DP_IMethod
    {
        public Publisher Publisher;

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
newEvent = Publisher.Agent.MonSys.Create("PubMsg") as PubMsg;

// set situation id
if (Publisher.ProcEvents.Count > 0)
{
	newEvent.SituationId = Publisher.ProcEvents.Dequeue();
}
else
{	// set random situation id
	if (Publisher.PubType == 0)	{
		newEvent.SituationId =  Publisher.Agent.MonSys.HotSpotList[0].CurrHotSpotId;
	}
	else {
		newEvent.SituationId = 100+(int)Math.Floor(Random.Uniform()*5);
	}
}
// set isAlert

// set topic
TopicRef tRef = Publisher.Agent.MonSys.Create("TopicRef") as TopicRef;
tRef.Topic = Publisher.regTopic;	
newEvent.TopicRefLink = tRef;

Publisher.Agent.PubCount++;        }

        public override double Duration
        {
          get
          {
double dur = 1;
if (Publisher.regTopic.IsPartOfHotspot)
	return dur/2;
else
	return dur;
          }
        }

    }
}
