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

    public class MsgDelivered : DP_Method, DP_IMethod
    {
        public OutMessage OutMessage;

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
            if (NewTriggerConnection2Instance != null && NewTriggerConnection2Instance.Role1 != this)
            {
              NewTriggerConnection2Instance.Role1 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.PeerContext.Read NewTriggerConnection2
        {
          get
          {
            return NewTriggerConnection2Instance.Read;
          }
          set
          {
            NewTriggerConnection2Instance.Read = value;
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
            if (NewCollabConnection2Instance != null && NewCollabConnection2Instance.Role2 != this)
            {
              NewCollabConnection2Instance.Role2 = this;
            }
          }
        }

        public P2PinSocialNetworkContext.PeerNetworkContext.FwdMessage NewCollabConnection2
        {
          get
          {
            return NewCollabConnection2Instance.FwdMessage;
          }
          set
          {
            NewCollabConnection2Instance.FwdMessage = value;
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
return 0;
          }
        }

    }
}
