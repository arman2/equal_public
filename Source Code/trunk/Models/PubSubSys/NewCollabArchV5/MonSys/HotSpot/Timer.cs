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

namespace Simulation.MonSysContext.HotSpotContext
{

    public class Timer : DP_Method, DP_IMethod
    {
        public HotSpot HotSpot;

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
return Random.LogNormal(0, 0.5)*10+10;
          }
        }

    }
}
