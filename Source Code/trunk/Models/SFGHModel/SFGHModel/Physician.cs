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

namespace Simulation
{
    using PhysicianContext;

    public class Physician : DP_Resource, DP_IResource
    {
        public void Relax(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Relax");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void PerformProcedure(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("PerformProcedure");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void PrepareReport(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("PrepareReport");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private MyDoctor MyDoctorInstance;
        public MyDoctor MyDoctor
        {
          get
          {
            return MyDoctorInstance;
          }
          set
          {
            MyDoctorInstance = value;
            if (MyDoctorInstance != null && MyDoctorInstance.Resource != this)
            {
              MyDoctorInstance.Resource = this;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


          foreach (DP_Queue queue in Type.Queues)
          {
            if (queue.Ordering == DP_Queue.QueueOrdering.FIFO)
            {
              queues.Add(queue.Name, new Queue());
            }
            else if (queue.Ordering == DP_Queue.QueueOrdering.LIFO)
            {
              queues.Add(queue.Name, new Stack());
            }
          }

          for (int i = 0; i < 3; i++)
          {
            Worker newWorker = new Worker();
            newWorker.Id = 0;
            newWorker.Velocity = 1.5;
            idle.Enqueue(newWorker);
          }

          for (int i = 0; i < 3; i++)
          {
            Worker newWorker = new Worker();
            newWorker.Id = 1;
            newWorker.Velocity = 1.0;
            idle.Enqueue(newWorker);
          }

        }

    }
}
