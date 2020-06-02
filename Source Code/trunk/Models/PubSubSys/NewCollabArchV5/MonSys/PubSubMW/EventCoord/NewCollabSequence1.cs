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
using Simulation.MonSysContext.PubSubMWContext;

namespace Simulation.MonSysContext.PubSubMWContext.EventCoordContext
{

    public class NewCollabSequence1 : DP_Flow, DP_IFlow
    {
        public EventCoord EventCoord;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.PubSubMWContext.EventCoordContext.Forward Forward = source as MonSysContext.PubSubMWContext.EventCoordContext.Forward;
return (EventCoord.InQueue.Count > 0 && EventCoord.isIdle == true);
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.PubSubMWContext.EventCoordContext.Forward Forward = source as MonSysContext.PubSubMWContext.EventCoordContext.Forward;
          MonSysContext.PubSubMWContext.EventCoordContext.Receive Receive = target as MonSysContext.PubSubMWContext.EventCoordContext.Receive;
Forward.EventCoord.isIdle = false;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.PubSubMWContext.EventCoordContext.Forward Forward = source as MonSysContext.PubSubMWContext.EventCoordContext.Forward;
return Context;        }

    }
}
