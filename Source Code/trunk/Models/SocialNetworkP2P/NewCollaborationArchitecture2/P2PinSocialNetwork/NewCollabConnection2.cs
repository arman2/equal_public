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

namespace Simulation.P2PinSocialNetworkContext
{

    public class NewCollabConnection2 : DP_Link, DP_ILink
    {
        public P2PinSocialNetwork P2PinSocialNetwork;

        private P2PinSocialNetworkContext.PeerNetworkContext.FwdMessage FwdMessageInstance;

        public P2PinSocialNetworkContext.PeerNetworkContext.FwdMessage FwdMessage
        {
          get
          {
            return FwdMessageInstance;
          }
          set
          {
            FwdMessageInstance = (P2PinSocialNetworkContext.PeerNetworkContext.FwdMessage)value;
            if (Role1 != value)
            {
              Role1 = value;
            }
          }
        }

        private P2PinSocialNetworkContext.OutMessageContext.MsgDelivered MsgDeliveredInstance;

        public P2PinSocialNetworkContext.OutMessageContext.MsgDelivered MsgDelivered
        {
          get
          {
            return MsgDeliveredInstance;
          }
          set
          {
            MsgDeliveredInstance = (P2PinSocialNetworkContext.OutMessageContext.MsgDelivered)value;
            if (Role2 != value)
            {
              Role2 = value;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
