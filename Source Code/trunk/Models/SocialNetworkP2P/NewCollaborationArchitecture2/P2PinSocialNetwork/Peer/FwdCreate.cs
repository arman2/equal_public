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

    public class FwdCreate : DP_Method, DP_IMethod
    {
        public Peer Peer;

        private NewCollabConnection NewCollabConnectionInstance;

        public NewCollabConnection NewCollabConnectionLink
        {
          get
          {
            return NewCollabConnectionInstance;
          }
          set
          {
            if (NewCollabConnectionInstance == value)
            {
              return;
            }
            NewCollabConnectionInstance = value;
            if (NewCollabConnectionInstance != null && NewCollabConnectionInstance.Role1 != this)
            {
              NewCollabConnectionInstance.Role1 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.OutMessageContext.MsgCreated NewCollabConnection
        {
          get
          {
            return NewCollabConnectionInstance.MsgCreated;
          }
          set
          {
            NewCollabConnectionInstance.MsgCreated = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
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
