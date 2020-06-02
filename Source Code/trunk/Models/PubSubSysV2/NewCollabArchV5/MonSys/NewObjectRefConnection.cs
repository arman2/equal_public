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

    public class NewObjectRefConnection : DP_Link, DP_ILink
    {
        public MonSys MonSys;

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
