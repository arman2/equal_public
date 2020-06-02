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
    using TopicContext;

    public class Topic : DP_Component, DP_IComponent
    {
        public MonSys MonSys;

        private Subscribers SubscribersInstance;

        public Subscribers SubscribersData
        {
          get
          {
            return SubscribersInstance;
          }
          set
          {
            SubscribersInstance = value;
          }
        }

        public List<Simulation.MonSysContext.AgentContext.SubscriberComp> Subscribers
        {
          get
          {
            return SubscribersInstance.Value;
          }
          set
          {
            SubscribersInstance.Value = value;
          }
        }

        private Publishers PublishersInstance;

        public Publishers PublishersData
        {
          get
          {
            return PublishersInstance;
          }
          set
          {
            PublishersInstance = value;
          }
        }

        public List<Simulation.MonSysContext.AgentContext.PublisherComp> Publishers
        {
          get
          {
            return PublishersInstance.Value;
          }
          set
          {
            PublishersInstance.Value = value;
          }
        }

        private TopicNameId TopicNameIdInstance;

        public TopicNameId TopicNameIdData
        {
          get
          {
            return TopicNameIdInstance;
          }
          set
          {
            TopicNameIdInstance = value;
          }
        }

        public String TopicNameId
        {
          get
          {
            return TopicNameIdInstance.Value;
          }
          set
          {
            TopicNameIdInstance.Value = value;
          }
        }

        private PubCount PubCountInstance;

        public PubCount PubCountData
        {
          get
          {
            return PubCountInstance;
          }
          set
          {
            PubCountInstance = value;
          }
        }

        public int PubCount
        {
          get
          {
            return PubCountInstance.Value;
          }
          set
          {
            PubCountInstance.Value = value;
          }
        }

        private SubCount SubCountInstance;

        public SubCount SubCountData
        {
          get
          {
            return SubCountInstance;
          }
          set
          {
            SubCountInstance = value;
          }
        }

        public int SubCount
        {
          get
          {
            return SubCountInstance.Value;
          }
          set
          {
            SubCountInstance.Value = value;
          }
        }

        private IsPartOfHotspot IsPartOfHotspotInstance;

        public IsPartOfHotspot IsPartOfHotspotData
        {
          get
          {
            return IsPartOfHotspotInstance;
          }
          set
          {
            IsPartOfHotspotInstance = value;
          }
        }

        public bool IsPartOfHotspot
        {
          get
          {
            return IsPartOfHotspotInstance.Value;
          }
          set
          {
            IsPartOfHotspotInstance.Value = value;
          }
        }

        private TopicRef TopicRefInstance;

        public TopicRef TopicRefLink
        {
          get
          {
            return TopicRefInstance;
          }
          set
          {
            if (TopicRefInstance == value)
            {
              return;
            }
            TopicRefInstance = value;
            if (TopicRefInstance != null && TopicRefInstance.Role2 != this)
            {
              TopicRefInstance.Role2 = this;
            }
          }
        }

        public MonSysContext.PubMsg TopicRef
        {
          get
          {
            return TopicRefInstance.PubMsg;
          }
          set
          {
            TopicRefInstance.PubMsg = value;
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
            if (NewObjectRefConnectionInstance != null && NewObjectRefConnectionInstance.Role2 != this)
            {
              NewObjectRefConnectionInstance.Role2 = this;
            }
          }
        }

        public MonSysContext.TopicGroup NewObjectRefConnection
        {
          get
          {
            return NewObjectRefConnectionInstance.TopicGroup;
          }
          set
          {
            NewObjectRefConnectionInstance.TopicGroup = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          SubscribersInstance = (Subscribers)Create("Subscribers");
          PublishersInstance = (Publishers)Create("Publishers");
          TopicNameIdInstance = (TopicNameId)Create("TopicNameId");
          PubCountInstance = (PubCount)Create("PubCount");
          SubCountInstance = (SubCount)Create("SubCount");
          IsPartOfHotspotInstance = (IsPartOfHotspot)Create("IsPartOfHotspot");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
