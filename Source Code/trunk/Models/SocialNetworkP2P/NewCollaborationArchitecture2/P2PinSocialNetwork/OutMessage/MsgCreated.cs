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

namespace Simulation.P2PinSocialNetworkContext.OutMessageContext
{

    public class MsgCreated : DP_Method, DP_IMethod
    {
        public OutMessage OutMessage;

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
            if (NewCollabConnectionInstance != null && NewCollabConnectionInstance.Role2 != this)
            {
              NewCollabConnectionInstance.Role2 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.PeerContext.FwdCreate NewCollabConnection
        {
          get
          {
            return NewCollabConnectionInstance.FwdCreate;
          }
          set
          {
            NewCollabConnectionInstance.FwdCreate = value;
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
            if (NewTriggerConnectionInstance != null && NewTriggerConnectionInstance.Role1 != this)
            {
              NewTriggerConnectionInstance.Role1 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.PeerNetworkContext.CacheMsg NewTriggerConnection
        {
          get
          {
            return NewTriggerConnectionInstance.CacheMsg;
          }
          set
          {
            NewTriggerConnectionInstance.CacheMsg = value;
          }
        }

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
            if (NewCollabConnection1Instance != null && NewCollabConnection1Instance.Role2 != this)
            {
              NewCollabConnection1Instance.Role2 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.PeerContext.CreateMsg NewCollabConnection1
        {
          get
          {
            return NewCollabConnection1Instance.CreateMsg;
          }
          set
          {
            NewCollabConnection1Instance.CreateMsg = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
OutMessage.P2PinSocialNetwork.PeerNetworkList[0].MsgInbox.Enqueue(OutMessage);
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
