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

    public class NewFocusOnObjConn : DP_Link, DP_ILink
    {
        public MonSys MonSys;

        private MonSysContext.AgentContext.SubscriberComp SubscriberCompInstance;

        public MonSysContext.AgentContext.SubscriberComp SubscriberComp
        {
          get
          {
            return SubscriberCompInstance;
          }
          set
          {
            SubscriberCompInstance = (MonSysContext.AgentContext.SubscriberComp)value;
            if (Role1 != value)
            {
              Role1 = value;
            }
          }
        }

        private MonSysContext.TopicGroup TopicGroupInstance;

        public MonSysContext.TopicGroup TopicGroup
        {
          get
          {
            return TopicGroupInstance;
          }
          set
          {
            TopicGroupInstance = (MonSysContext.TopicGroup)value;
            if (Role2 != value)
            {
              Role2 = value;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
