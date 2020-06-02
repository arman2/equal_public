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

namespace Simulation.MonSysContext
{

    public class NewTriggerFlow2 : DP_Flow, DP_IFlow
    {
        public MonSys MonSys;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.NfyMsgContext.Created Created = source as MonSysContext.NfyMsgContext.Created;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.NfyMsgContext.Created Created = source as MonSysContext.NfyMsgContext.Created;
          MonSysContext.AgentContext.SubscriberContext.Receive Receive = target as MonSysContext.AgentContext.SubscriberContext.Receive;
Receive.notification = Created.NfyMsg;        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.NfyMsgContext.Created Created = source as MonSysContext.NfyMsgContext.Created;
return Created.NfyMsg.Receiver;        }

    }
}
