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

    public class Forward : DP_Method, DP_IMethod
    {
        public EventCoord EventCoord;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
DomainProAnalyst.Instance.Report("Delivering to # subscribers: "+EventCoord.EventDict.Count);

int msgCount = 0;

foreach (KeyValuePair<MonSysContext.AgentContext.Subscriber,NfyMsg> pair in EventCoord.EventDict)
{
	NfyMsg msg = pair.Value;
	//DomainProAnalyst.Instance.Report("Triggering Delivery");
	msgCount +=	msg.MsgList.Count;
	msg.Created(false);	    
}
EventCoord.EventDict.Clear();
EventCoord.PubSubMW.TotalMsgDelivered += msgCount;
EventCoord.PubSubMW.MsgLastDelivered = msgCount;
EventCoord.PubSubMW.EWMAvgMsgDelivered = EventCoord.PubSubMW.EWMAalpha * (double)msgCount + (1-EventCoord.PubSubMW.EWMAalpha)*EventCoord.PubSubMW.EWMAvgMsgDelivered ;

// calculate overall Agent Load here as this is one of the most regularly executed methods:
double fieldLoadSum = 0;
double fieldIdleSum = 0;
int fieldCount = 0;
double officeLoadSum = 0;
double officeIdleSum = 0;
int officeCount = 0;
double leaderLoadSum = 0;
double leaderIdleSum = 0;
int leaderCount = 0;
double fieldAlpha = 1;
double officeAlpha = 1;
double leaderAlpha = 1;
foreach (Agent agent in EventCoord.PubSubMW.MonSys.AgentList)
{
	switch (agent.AgentType)
	{
		case 0: break;
		case 1: 
			fieldLoadSum += agent.WorkOverLoad;
			fieldIdleSum += agent.IdleCapacity;
			fieldAlpha = agent.EWMAalpha;
			fieldCount++;
			break;
		case 2: 
			officeLoadSum += agent.WorkOverLoad;
			officeIdleSum += agent.IdleCapacity;
			officeAlpha = agent.EWMAalpha;
			officeCount++;
			break;
		case 3:
			leaderLoadSum += agent.WorkOverLoad;
			leaderIdleSum += agent.IdleCapacity;
			leaderAlpha = agent.EWMAalpha;
			leaderCount++;
			break;
		default : break;	
	}	
}
MonSys ms = EventCoord.PubSubMW.MonSys;
ms.EWMAFieldAgentIdle = (fieldAlpha*fieldIdleSum/fieldCount) + (1-fieldAlpha)*ms.EWMAFieldAgentIdle;
ms.EWMAOfficeAgentIdle = (officeAlpha*officeIdleSum/officeCount) + (1-officeAlpha)*ms.EWMAOfficeAgentIdle;
ms.EWMALeaderAgentIdle = (leaderAlpha*leaderIdleSum/leaderCount) + (1-leaderAlpha)*ms.EWMALeaderAgentIdle;

ms.EWMAFieldAgentLoad = (fieldAlpha*fieldLoadSum/fieldCount) + (1-fieldAlpha)*ms.EWMAFieldAgentLoad;
ms.EWMAOfficeAgentLoad = (officeAlpha*officeLoadSum/officeCount) + (1-officeAlpha)*ms.EWMAOfficeAgentLoad;
ms.EWMALeaderAgentLoad = (leaderAlpha*leaderLoadSum/leaderCount) + (1-leaderAlpha)*ms.EWMALeaderAgentLoad;


EventCoord.isIdle = true;        }

        public override double Duration
        {
          get
          {
return EventCoord.PubSubMW.WorkExeDuration/EventCoord.CreateP;

          }
        }

    }
}
