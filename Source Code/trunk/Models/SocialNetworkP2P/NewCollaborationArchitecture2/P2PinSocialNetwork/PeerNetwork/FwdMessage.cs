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
    using FwdMessageContext;

    public class FwdMessage : DP_Method, DP_IMethod
    {
        public PeerNetwork PeerNetwork;

        private OutMsg OutMsgInstance;

        public OutMsg OutMsgData
        {
          get
          {
            return OutMsgInstance;
          }
          set
          {
            OutMsgInstance = value;
          }
        }

        public OutMessage OutMsg
        {
          get
          {
            return OutMsgInstance.Value;
          }
          set
          {
            OutMsgInstance.Value = value;
          }
        }

        private NewCollabConnection2 NewCollabConnection2Instance;

        public NewCollabConnection2 NewCollabConnection2Link
        {
          get
          {
            return NewCollabConnection2Instance;
          }
          set
          {
            if (NewCollabConnection2Instance == value)
            {
              return;
            }
            NewCollabConnection2Instance = value;
            if (NewCollabConnection2Instance != null && NewCollabConnection2Instance.Role1 != this)
            {
              NewCollabConnection2Instance.Role1 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.OutMessageContext.MsgDelivered NewCollabConnection2
        {
          get
          {
            return NewCollabConnection2Instance.MsgDelivered;
          }
          set
          {
            NewCollabConnection2Instance.MsgDelivered = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          OutMsgInstance = (OutMsg)Create("OutMsg");

        }

        public override void Run()
        {
while (PeerNetwork.MsgOutbox.Count > 0)
{
	OutMsg = PeerNetwork.MsgOutbox.Dequeue();
	PeerNetwork.P2PinSocialNetwork.PeerList[OutMsg.Receivers[0]].MsgInbox.Enqueue(OutMsg);
}        }

        public override double Duration
        {
          get
          {
return 1;
          }
        }

    }
}
