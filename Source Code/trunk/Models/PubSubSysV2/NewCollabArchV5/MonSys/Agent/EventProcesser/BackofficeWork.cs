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

namespace Simulation.MonSysContext.AgentContext.EventProcesserContext
{

    public class BackofficeWork : DP_Method, DP_IMethod
    {
        public EventProcesser EventProcesser;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
int eventCount = EventProcesser.eventCount;
Agent agent = EventProcesser.Agent;
agent.ProcessingWork = eventCount;

Dictionary<int,int> dict = EventProcesser.Situations;
double throughput = EventProcesser.Capacity*EventProcesser.ExeDuration*EventProcesser.UpdateP;

if (eventCount > throughput)
{
	agent.WorkOverLoad = (eventCount/throughput);
	agent.IdleCapacity = 0;
}
else
{
	agent.WorkOverLoad = 0;
	agent.IdleCapacity = ((throughput-eventCount)/throughput);
}
agent.EWMAvgWorkOverLoad = agent.EWMAalpha*agent.WorkOverLoad + (1-agent.EWMAalpha)*agent.EWMAvgWorkOverLoad;

for (int i = 0; i<eventCount; i++)
{
	PubMsg msg = EventProcesser.InEvents.Dequeue();
	if (EventProcesser.Agent.DoDropOverload && i > throughput)
	{;
	}
	else	
	{	
		int counter = 0;		
		if (dict.TryGetValue(msg.SituationId, out counter))
		{
			dict[msg.SituationId] = counter+1;
		}	
		else
		{
			dict.Add(msg.SituationId, 1);
		}
	}

}

foreach (KeyValuePair<int,int> pair in EventProcesser.Situations)
{
	int id = pair.Key;
	int count = pair.Value;
	
	if (count > 5)
	{
		DomainProAnalyst.Instance.Report("Backoffice Worker Detects Situation: "+id);	
		agent.PublisherCompList[0].ProcEvents.Enqueue(id);
	}		    
}
        }

        public override double Duration
        {
          get
          {
// Backoffice worker use only half the time for analysis due to crowd sourcing
//double dur = EventProcesser.ExeDuration/2;

int eventCount = EventProcesser.eventCount;
if (EventProcesser.Agent.DoDropOverload)
	return EventProcesser.ExeDuration;
else
	return Math.Max(EventProcesser.ExeDuration, eventCount/(EventProcesser.Capacity*EventProcesser.UpdateP));


          }
        }

    }
}
