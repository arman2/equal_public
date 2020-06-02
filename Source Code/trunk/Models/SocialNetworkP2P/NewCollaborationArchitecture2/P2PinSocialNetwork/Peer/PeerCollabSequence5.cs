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

    public class PeerCollabSequence5 : DP_Flow, DP_IFlow
    {
        public Peer Peer;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          P2PinSocialNetworkContext.PeerContext.CreateMsg CreateMsg = source as P2PinSocialNetworkContext.PeerContext.CreateMsg;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          P2PinSocialNetworkContext.PeerContext.CreateMsg CreateMsg = source as P2PinSocialNetworkContext.PeerContext.CreateMsg;
          P2PinSocialNetworkContext.PeerContext.NextStep NextStep = target as P2PinSocialNetworkContext.PeerContext.NextStep;
        }

    }
}
