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

    public class NewCollabSequence3 : DP_Flow, DP_IFlow
    {
        public PeerNetwork PeerNetwork;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          P2PinSocialNetworkContext.PeerNetworkContext.Idle Idle = source as P2PinSocialNetworkContext.PeerNetworkContext.Idle;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          P2PinSocialNetworkContext.PeerNetworkContext.Idle Idle = source as P2PinSocialNetworkContext.PeerNetworkContext.Idle;
          P2PinSocialNetworkContext.PeerNetworkContext.CacheMsg CacheMsg = target as P2PinSocialNetworkContext.PeerNetworkContext.CacheMsg;
        }

    }
}
