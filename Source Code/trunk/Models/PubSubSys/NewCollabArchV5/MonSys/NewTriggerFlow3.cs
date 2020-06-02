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

namespace Simulation.MonSysContext
{

    public class NewTriggerFlow3 : DP_Flow, DP_IFlow
    {
        public MonSys MonSys;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.PubSubMWContext.EventCoordContext.Forward Forward = source as MonSysContext.PubSubMWContext.EventCoordContext.Forward;
return false;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.PubSubMWContext.EventCoordContext.Forward Forward = source as MonSysContext.PubSubMWContext.EventCoordContext.Forward;
          MonSysContext.NfyMsgContext.Created Created = target as MonSysContext.NfyMsgContext.Created;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.PubSubMWContext.EventCoordContext.Forward Forward = source as MonSysContext.PubSubMWContext.EventCoordContext.Forward;
return Context;        }

    }
}
