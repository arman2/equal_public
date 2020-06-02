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

namespace Simulation.MonSysContext.AgentContext
{
    using EventProcesserContext;

    public class EventProcesser : DP_Component, DP_IComponent
    {
        public Agent Agent;

        public System.Double CreateP
        {
          get { return ((Role)Type).CreateP; }
        }

        public System.Double ReadP
        {
          get { return ((Role)Type).ReadP; }
        }

        public System.Double UpdateP
        {
          get { return ((Role)Type).UpdateP; }
        }

        public System.Double DeleteP
        {
          get { return ((Role)Type).DeleteP; }
        }

        public System.Double IdleP
        {
          get { return ((Role)Type).IdleP; }
        }

        private InEvents InEventsInstance;

        public InEvents InEventsData
        {
          get
          {
            return InEventsInstance;
          }
          set
          {
            InEventsInstance = value;
          }
        }

        public Queue<PubMsg> InEvents
        {
          get
          {
            return InEventsInstance.Value;
          }
          set
          {
            InEventsInstance.Value = value;
          }
        }

        public void FieldAgentWork(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("FieldAgentWork");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private Situations SituationsInstance;

        public Situations SituationsData
        {
          get
          {
            return SituationsInstance;
          }
          set
          {
            SituationsInstance = value;
          }
        }

        public Dictionary<int,int> Situations
        {
          get
          {
            return SituationsInstance.Value;
          }
          set
          {
            SituationsInstance.Value = value;
          }
        }

        private isIdle isIdleInstance;

        public isIdle isIdleData
        {
          get
          {
            return isIdleInstance;
          }
          set
          {
            isIdleInstance = value;
          }
        }

        public bool isIdle
        {
          get
          {
            return isIdleInstance.Value;
          }
          set
          {
            isIdleInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          InEventsInstance = (InEvents)Create("InEvents");
          SituationsInstance = (Situations)Create("Situations");
          isIdleInstance = (isIdle)Create("isIdle");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
