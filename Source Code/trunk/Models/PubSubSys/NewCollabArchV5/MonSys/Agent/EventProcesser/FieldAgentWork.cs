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

    public class FieldAgentWork : DP_Method, DP_IMethod
    {
        public EventProcesser EventProcesser;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
int eventCount = EventProcesser.InEvents.Count;
Agent agent = EventProcesser.Agent;
agent.ProcessingWork = eventCount;
Dictionary<int,int> dict = EventProcesser.Situations;
double throughput = agent.WorkExeDuration;
double load = eventCount/throughput;
double time = agent.WorkExeDuration;

if (load > time)
{
	agent.WorkOverLoad = (load - time);
	agent.IdleCapacity = 0;
}
else
{
	agent.WorkOverLoad = 0;
	agent.IdleCapacity = (time-load);
}
agent.EWMAvgWorkOverLoad = agent.EWMAalpha*agent.WorkOverLoad + (1-agent.EWMAalpha)*agent.EWMAvgWorkOverLoad;

for (int i = 0; i<eventCount; i++)
{
	PubMsg msg = EventProcesser.InEvents.Dequeue();
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

foreach (KeyValuePair<int,int> pair in EventProcesser.Situations)
{
	int id = pair.Key;
	int count = pair.Value;
	
	if (count > 10)
	{
		DomainProAnalyst.Instance.Report("Field Agent Detects Situation: "+id);	
		agent.PublisherList[0].ProcEvents.Enqueue(id);
	}		    
}
        }

        public override double Duration
        {
          get
          {
//double dur = Math.Max(Math.Min(EventProcesser.InEvents.Count/EventProcesser.Agent.WorkExeDuration, EventProcesser.Agent.WorkExeDuration), 5);
//EventProcesser.Agent.ProcessingWork = dur;

double dur = EventProcesser.Agent.WorkExeDuration;
return dur;
          }
        }

    }
}
