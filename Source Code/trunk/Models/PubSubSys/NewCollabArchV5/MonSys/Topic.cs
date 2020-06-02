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

        public List<Simulation.MonSysContext.AgentContext.Subscriber> Subscribers
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

        public List<Simulation.MonSysContext.AgentContext.Publisher> Publishers
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

        private NewFocusOnObjConn1 NewFocusOnObjConn1Instance;

        public NewFocusOnObjConn1 NewFocusOnObjConn1Link
        {
          get
          {
            return NewFocusOnObjConn1Instance;
          }
          set
          {
            if (NewFocusOnObjConn1Instance == value)
            {
              return;
            }
            NewFocusOnObjConn1Instance = value;
            if (NewFocusOnObjConn1Instance != null && NewFocusOnObjConn1Instance.Role2 != this)
            {
              NewFocusOnObjConn1Instance.Role2 = this;
            }
          }
        }

        public MonSysContext.AgentContext.Subscriber NewFocusOnObjConn1
        {
          get
          {
            return NewFocusOnObjConn1Instance.Subscriber;
          }
          set
          {
            NewFocusOnObjConn1Instance.Subscriber = value;
          }
        }

        private NewFocusOnObjConn2 NewFocusOnObjConn2Instance;

        public NewFocusOnObjConn2 NewFocusOnObjConn2Link
        {
          get
          {
            return NewFocusOnObjConn2Instance;
          }
          set
          {
            if (NewFocusOnObjConn2Instance == value)
            {
              return;
            }
            NewFocusOnObjConn2Instance = value;
            if (NewFocusOnObjConn2Instance != null && NewFocusOnObjConn2Instance.Role2 != this)
            {
              NewFocusOnObjConn2Instance.Role2 = this;
            }
          }
        }

        public MonSysContext.AgentContext.Publisher NewFocusOnObjConn2
        {
          get
          {
            return NewFocusOnObjConn2Instance.Publisher;
          }
          set
          {
            NewFocusOnObjConn2Instance.Publisher = value;
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

            Startup();
        }

        public void Startup()
        {
        }

    }
}
