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

    public class CreateMsg : DP_Method, DP_IMethod
    {
        public Peer Peer;

        private NewCollabConnection1 NewCollabConnection1Instance;

        public NewCollabConnection1 NewCollabConnection1Link
        {
          get
          {
            return NewCollabConnection1Instance;
          }
          set
          {
            if (NewCollabConnection1Instance == value)
            {
              return;
            }
            NewCollabConnection1Instance = value;
            if (NewCollabConnection1Instance != null && NewCollabConnection1Instance.Role1 != this)
            {
              NewCollabConnection1Instance.Role1 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.OutMessageContext.MsgCreated NewCollabConnection1
        {
          get
          {
            return NewCollabConnection1Instance.MsgCreated;
          }
          set
          {
            NewCollabConnection1Instance.MsgCreated = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
//OutMessage newMessage = new OutMessage();
OutMessage newMessage = Peer.P2PinSocialNetwork.Create("OutMessage") as OutMessage;
newMessage.Sender = Peer.PeerID;
newMessage.MsgId = Peer.OriginMsgCounter+"@"+ Peer.PeerID;
newMessage.TTL = 3;

for( int i=0 ; i<2 ; i++)
{
	int id = System.Convert.ToInt32(Math.Floor(Model.Simulation.Simulator.Random * System.Convert.ToDouble(Peer.P2PinSocialNetwork.PeerList.Count)));
	newMessage.Receivers.Add(id);
}

Peer.OriginMsgCounter++;
//Peer.P2PinSocialNetwork.PeerNetworkList[0].MsgInbox.Enqueue(newMessage);
newMessage.MsgCreated();	

// NewCollabConnection1 returns Object Type of MsgCreated
// NewCollabConnection1.NewTriggerConnection return CacheMsg object
        }

        public override double Duration
        {
          get
          {
return 1;
          }
        }

    }
}
