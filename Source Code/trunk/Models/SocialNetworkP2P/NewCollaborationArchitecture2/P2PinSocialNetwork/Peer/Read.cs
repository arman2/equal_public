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
using Simulation.P2PinSocialNetworkContext;

namespace Simulation.P2PinSocialNetworkContext.PeerContext
{
    using ReadContext;

    public class Read : DP_Method, DP_IMethod
    {
        public Peer Peer;

        private inMsg inMsgInstance;

        public inMsg inMsgData
        {
          get
          {
            return inMsgInstance;
          }
          set
          {
            inMsgInstance = value;
          }
        }

        public OutMessage inMsg
        {
          get
          {
            return inMsgInstance.Value;
          }
          set
          {
            inMsgInstance.Value = value;
          }
        }

        private NewTriggerConnection2 NewTriggerConnection2Instance;

        public NewTriggerConnection2 NewTriggerConnection2Link
        {
          get
          {
            return NewTriggerConnection2Instance;
          }
          set
          {
            if (NewTriggerConnection2Instance == value)
            {
              return;
            }
            NewTriggerConnection2Instance = value;
            if (NewTriggerConnection2Instance != null && NewTriggerConnection2Instance.Role2 != this)
            {
              NewTriggerConnection2Instance.Role2 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.OutMessageContext.MsgDelivered NewTriggerConnection2
        {
          get
          {
            return NewTriggerConnection2Instance.MsgDelivered;
          }
          set
          {
            NewTriggerConnection2Instance.MsgDelivered = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          inMsgInstance = (inMsg)Create("inMsg");

        }

        public override void Run()
        {
while (Peer.MsgInbox.Count > 0)
{
	inMsg = Peer.MsgInbox.Dequeue();
	inMsg.TTL--;
	if (inMsg.TTL > 0)
	{		
		Peer.MsgFwdbox.Enqueue(inMsg);		
	}
	Peer.PeerReceivedMsgs.Add(inMsg.MsgId);
	Peer.ReceivedCounter++;
}			
inMsg = null;        }

        public override double Duration
        {
          get
          {
return 1;
          }
        }

    }
}
