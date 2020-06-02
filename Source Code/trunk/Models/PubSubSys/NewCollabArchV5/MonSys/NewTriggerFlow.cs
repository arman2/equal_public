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

    public class NewTriggerFlow : DP_Flow, DP_IFlow
    {
        public MonSys MonSys;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          MonSysContext.PubMsgContext.Created Created = source as MonSysContext.PubMsgContext.Created;
return (Created.PubMsg.MonSys.PubSubMWList[0].EventCoordList[0].isIdle);
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          MonSysContext.PubMsgContext.Created Created = source as MonSysContext.PubMsgContext.Created;
          MonSysContext.PubSubMWContext.EventCoordContext.Receive Receive = target as MonSysContext.PubSubMWContext.EventCoordContext.Receive;
//Receive.EventCoord.isIdle = false;
Created.PubMsg.MonSys.PubSubMWList[0].EventCoordList[0].isIdle = false;        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          MonSysContext.PubMsgContext.Created Created = source as MonSysContext.PubMsgContext.Created;
return Created.PubMsg.MonSys.PubSubMWList[0].EventCoordList[0];        }

    }
}
