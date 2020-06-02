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

    public class NewCollabSequence : DP_Flow, DP_IFlow
    {
        public Agent Agent;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.AgentContext.SubscriberCompContext.Receive Receive = source as MonSysContext.AgentContext.SubscriberCompContext.Receive;
return (Receive.SubscriberComp.SubType==1 && Receive.SubscriberComp.Agent.EventProcesserList[0].isIdle);        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.AgentContext.SubscriberCompContext.Receive Receive = source as MonSysContext.AgentContext.SubscriberCompContext.Receive;
          MonSysContext.AgentContext.EventProcesserContext.FieldAgentWork FieldAgentWork = target as MonSysContext.AgentContext.EventProcesserContext.FieldAgentWork;
Receive.SubscriberComp.Agent.EventProcesserList[0].isIdle = false;
Receive.SubscriberComp.Agent.EventProcesserList[0].eventCount = Receive.SubscriberComp.Agent.EventProcesserList[0].InEvents.Count;        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.AgentContext.SubscriberCompContext.Receive Receive = source as MonSysContext.AgentContext.SubscriberCompContext.Receive;
return Receive.SubscriberComp.Agent.EventProcesserList[0];        }

    }
}
