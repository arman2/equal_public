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

    public class NewFocusOnObjConn1 : DP_Link, DP_ILink
    {
        public MonSys MonSys;

        private MonSysContext.AgentContext.Subscriber SubscriberInstance;

        public MonSysContext.AgentContext.Subscriber Subscriber
        {
          get
          {
            return SubscriberInstance;
          }
          set
          {
            SubscriberInstance = (MonSysContext.AgentContext.Subscriber)value;
            if (Role1 != value)
            {
              Role1 = value;
            }
          }
        }

        private MonSysContext.Topic TopicInstance;

        public MonSysContext.Topic Topic
        {
          get
          {
            return TopicInstance;
          }
          set
          {
            TopicInstance = (MonSysContext.Topic)value;
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
