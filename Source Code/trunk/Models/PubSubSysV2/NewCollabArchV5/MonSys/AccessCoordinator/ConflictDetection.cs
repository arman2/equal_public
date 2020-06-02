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

namespace Simulation.MonSysContext.AccessCoordinatorContext
{
    using ConflictDetectionContext;

    public class ConflictDetection : DP_Component, DP_IComponent
    {
        public AccessCoordinator AccessCoordinator;

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

        public void CheckUpdate(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("CheckUpdate");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void UpdateFeedback(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("UpdateFeedback");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private InQueue InQueueInstance;

        public InQueue InQueueData
        {
          get
          {
            return InQueueInstance;
          }
          set
          {
            InQueueInstance = value;
          }
        }

        public Queue<StatusArtifact> InQueue
        {
          get
          {
            return InQueueInstance.Value;
          }
          set
          {
            InQueueInstance.Value = value;
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

        private isIdleInternal isIdleInternalInstance;

        public isIdleInternal isIdleInternalData
        {
          get
          {
            return isIdleInternalInstance;
          }
          set
          {
            isIdleInternalInstance = value;
          }
        }

        public bool isIdleInternal
        {
          get
          {
            return isIdleInternalInstance.Value;
          }
          set
          {
            isIdleInternalInstance.Value = value;
          }
        }

        private OutQueue OutQueueInstance;

        public OutQueue OutQueueData
        {
          get
          {
            return OutQueueInstance;
          }
          set
          {
            OutQueueInstance = value;
          }
        }

        public Queue<Simulation.MonSysContext.StatusArtifactContext.Update> OutQueue
        {
          get
          {
            return OutQueueInstance.Value;
          }
          set
          {
            OutQueueInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          InQueueInstance = (InQueue)Create("InQueue");
          isIdleInstance = (isIdle)Create("isIdle");
          isIdleInternalInstance = (isIdleInternal)Create("isIdleInternal");
          OutQueueInstance = (OutQueue)Create("OutQueue");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
