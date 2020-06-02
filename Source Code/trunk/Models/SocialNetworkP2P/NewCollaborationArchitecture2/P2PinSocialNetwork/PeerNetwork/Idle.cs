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

    public class Idle : DP_Method, DP_IMethod
    {
        public PeerNetwork PeerNetwork;

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
