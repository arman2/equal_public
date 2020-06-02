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
    using TopicGroupContext;

    public class TopicGroup : DP_Component, DP_IComponent
    {
        public MonSys MonSys;

        private Topics TopicsInstance;

        public Topics TopicsData
        {
          get
          {
            return TopicsInstance;
          }
          set
          {
            TopicsInstance = value;
          }
        }

        public List<Topic> Topics
        {
          get
          {
            return TopicsInstance.Value;
          }
          set
          {
            TopicsInstance.Value = value;
          }
        }

        private GroupNameId GroupNameIdInstance;

        public GroupNameId GroupNameIdData
        {
          get
          {
            return GroupNameIdInstance;
          }
          set
          {
            GroupNameIdInstance = value;
          }
        }

        public String GroupNameId
        {
          get
          {
            return GroupNameIdInstance.Value;
          }
          set
          {
            GroupNameIdInstance.Value = value;
          }
        }

        private NewFocusOnObjConn NewFocusOnObjConnInstance;

        public NewFocusOnObjConn NewFocusOnObjConnLink
        {
          get
          {
            return NewFocusOnObjConnInstance;
          }
          set
          {
            if (NewFocusOnObjConnInstance == value)
            {
              return;
            }
            NewFocusOnObjConnInstance = value;
            if (NewFocusOnObjConnInstance != null && NewFocusOnObjConnInstance.Role2 != this)
            {
              NewFocusOnObjConnInstance.Role2 = this;
            }
          }
        }

        public MonSysContext.AgentContext.SubscriberComp NewFocusOnObjConn
        {
          get
          {
            return NewFocusOnObjConnInstance.SubscriberComp;
          }
          set
          {
            NewFocusOnObjConnInstance.SubscriberComp = value;
          }
        }

        private NewObjectRefConnection NewObjectRefConnectionInstance;

        public NewObjectRefConnection NewObjectRefConnectionLink
        {
          get
          {
            return NewObjectRefConnectionInstance;
          }
          set
          {
            if (NewObjectRefConnectionInstance == value)
            {
              return;
            }
            NewObjectRefConnectionInstance = value;
            if (NewObjectRefConnectionInstance != null && NewObjectRefConnectionInstance.Role1 != this)
            {
              NewObjectRefConnectionInstance.Role1 = this;
            }
          }
        }

        public MonSysContext.Topic NewObjectRefConnection
        {
          get
          {
            return NewObjectRefConnectionInstance.Topic;
          }
          set
          {
            NewObjectRefConnectionInstance.Topic = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          TopicsInstance = (Topics)Create("Topics");
          GroupNameIdInstance = (GroupNameId)Create("GroupNameId");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
