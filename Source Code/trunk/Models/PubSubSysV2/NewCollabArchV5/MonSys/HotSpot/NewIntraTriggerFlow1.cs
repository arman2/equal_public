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

    public class NewIntraTriggerFlow1 : DP_Flow, DP_IFlow
    {
        public HotSpot HotSpot;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.HotSpotContext.Timer Timer = source as MonSysContext.HotSpotContext.Timer;
return true;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.HotSpotContext.Timer Timer = source as MonSysContext.HotSpotContext.Timer;
          MonSysContext.HotSpotContext.SwitchHotSpot SwitchHotSpot = target as MonSysContext.HotSpotContext.SwitchHotSpot;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.HotSpotContext.Timer Timer = source as MonSysContext.HotSpotContext.Timer;
return Context;        }

    }
}
