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

namespace Simulation.P2PinSocialNetworkContext.PeerNetworkContext
{
    using CacheMsgContext;

    public class CacheMsg : DP_Method, DP_IMethod
    {
        public PeerNetwork PeerNetwork;

        private NextMsg NextMsgInstance;

        public NextMsg NextMsgData
        {
          get
          {
            return NextMsgInstance;
          }
          set
          {
            NextMsgInstance = value;
          }
        }

        public OutMessage NextMsg
        {
          get
          {
            return NextMsgInstance.Value;
          }
          set
          {
            NextMsgInstance.Value = value;
          }
        }

        private NewTriggerConnection NewTriggerConnectionInstance;

        public NewTriggerConnection NewTriggerConnectionLink
        {
          get
          {
            return NewTriggerConnectionInstance;
          }
          set
          {
            if (NewTriggerConnectionInstance == value)
            {
              return;
            }
            NewTriggerConnectionInstance = value;
            if (NewTriggerConnectionInstance != null && NewTriggerConnectionInstance.Role2 != this)
            {
              NewTriggerConnectionInstance.Role2 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.OutMessageContext.MsgCreated NewTriggerConnection
        {
          get
          {
            return NewTriggerConnectionInstance.MsgCreated;
          }
          set
          {
            NewTriggerConnectionInstance.MsgCreated = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          NextMsgInstance = (NextMsg)Create("NextMsg");

        }

        public override void Run()
        {
while (PeerNetwork.MsgInbox.Count > 0)
{
	NextMsg = PeerNetwork.MsgInbox.Dequeue();
	if (NextMsg.Receivers != null && NextMsg.Receivers.Count > 0)
	{
		foreach(int receiverId in NextMsg.Receivers)
		{	
			OutMessage newMessage = PeerNetwork.P2PinSocialNetwork.Create("OutMessage") as OutMessage;
			newMessage.Sender = NextMsg.Sender;
			newMessage.MsgId = NextMsg.MsgId;
			newMessage.TTL = NextMsg.TTL;
			newMessage.Receivers.Add(receiverId);
			PeerNetwork.MsgOutbox.Enqueue(newMessage);
		}
	}
	PeerNetwork.ReceivedMsgs++;
}			
NextMsg = null;
        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
