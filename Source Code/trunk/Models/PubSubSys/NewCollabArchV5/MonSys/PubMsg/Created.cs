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
using Simulation.MonSysContext;

namespace Simulation.MonSysContext.PubMsgContext
{

    public class Created : DP_Method, DP_IMethod
    {
        public PubMsg PubMsg;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
PubMsg.MonSys.PubSubMWList[0].EventCoordList[0].InQueue.Enqueue(PubMsg);        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
