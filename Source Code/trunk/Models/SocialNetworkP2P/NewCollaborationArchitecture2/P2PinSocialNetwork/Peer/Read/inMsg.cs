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
using Simulation.P2PinSocialNetworkContext.PeerContext;

namespace Simulation.P2PinSocialNetworkContext.PeerContext.ReadContext
{

    public class inMsg : DP_Data, DP_IData
    {
        public Read Read;

        public new OutMessage Value
        {
          get
          {
            return (OutMessage)val;
          }
          set
          {
            OnDataChanged(new DP_DataChangedEventArgs(Id, Context.Id, Model.Simulation.Simulator.Scheduler.Time, value));
            val = value;
          }
        }

        public Double Size
        {
          get { return 0; }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
