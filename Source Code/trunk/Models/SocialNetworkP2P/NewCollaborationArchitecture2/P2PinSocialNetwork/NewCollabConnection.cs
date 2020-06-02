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

    public class NewCollabConnection : DP_Link, DP_ILink
    {
        public P2PinSocialNetwork P2PinSocialNetwork;

        private P2PinSocialNetworkContext.PeerContext.FwdCreate FwdCreateInstance;

        public P2PinSocialNetworkContext.PeerContext.FwdCreate FwdCreate
        {
          get
          {
            return FwdCreateInstance;
          }
          set
          {
            FwdCreateInstance = (P2PinSocialNetworkContext.PeerContext.FwdCreate)value;
            if (Role1 != value)
            {
              Role1 = value;
            }
          }
        }

        private P2PinSocialNetworkContext.OutMessageContext.MsgCreated MsgCreatedInstance;

        public P2PinSocialNetworkContext.OutMessageContext.MsgCreated MsgCreated
        {
          get
          {
            return MsgCreatedInstance;
          }
          set
          {
            MsgCreatedInstance = (P2PinSocialNetworkContext.OutMessageContext.MsgCreated)value;
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
