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
    using NextStepContext;

    public class NextStep : DP_Method, DP_IMethod
    {
        public Peer Peer;

        private NextAction NextActionInstance;

        public NextAction NextActionData
        {
          get
          {
            return NextActionInstance;
          }
          set
          {
            NextActionInstance = value;
          }
        }

        public double NextAction
        {
          get
          {
            return NextActionInstance.Value;
          }
          set
          {
            NextActionInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          NextActionInstance = (NextAction)Create("NextAction");

        }

        public override void Run()
        {
NextAction = Model.Simulation.Simulator.Random;
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
