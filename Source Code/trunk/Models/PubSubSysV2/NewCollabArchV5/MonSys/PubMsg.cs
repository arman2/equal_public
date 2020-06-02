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
    using PubMsgContext;

    public class PubMsg : DP_Component, DP_IComponent
    {
        public MonSys MonSys;

        public void Created(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Created");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private SituationId SituationIdInstance;

        public SituationId SituationIdData
        {
          get
          {
            return SituationIdInstance;
          }
          set
          {
            SituationIdInstance = value;
          }
        }

        public int SituationId
        {
          get
          {
            return SituationIdInstance.Value;
          }
          set
          {
            SituationIdInstance.Value = value;
          }
        }

        private Sender SenderInstance;

        public Sender SenderData
        {
          get
          {
            return SenderInstance;
          }
          set
          {
            SenderInstance = value;
          }
        }

        public MonSysContext.AgentContext.PublisherComp Sender
        {
          get
          {
            return SenderInstance.Value;
          }
          set
          {
            SenderInstance.Value = value;
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
            if (TopicRefInstance != null && TopicRefInstance.Role1 != this)
            {
              TopicRefInstance.Role1 = this;
            }
          }
        }

        public MonSysContext.Topic TopicRef
        {
          get
          {
            return TopicRefInstance.Topic;
          }
          set
          {
            TopicRefInstance.Topic = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          SituationIdInstance = (SituationId)Create("SituationId");
          SenderInstance = (Sender)Create("Sender");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
