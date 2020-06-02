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

namespace Simulation.HuaweiTestingContext
{

    public class Resource1 : DP_Resource, DP_IResource
    {
        public HuaweiTesting HuaweiTesting;

        public System.Int32 PoolSize
        {
          get { return ((VolunteerPool)Type).PoolSize; }
        }

        public System.Double VolunteerReliability
        {
          get { return ((VolunteerPool)Type).VolunteerReliability; }
        }

        public System.Double ProcessingPower
        {
          get { return ((VolunteerPool)Type).ProcessingPower; }
        }

        private Network1 Network1Instance;
        public Network1 Network1
        {
          get
          {
            return Network1Instance;
          }
          set
          {
            Network1Instance = value;
            if (Network1Instance != null && Network1Instance.Resource != this)
            {
              Network1Instance.Resource = this;
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

          for (int i = 0; i < PoolSize; i++)
          {
            Worker newWorker = new Worker();
            newWorker.Id = 0;
            newWorker.Velocity = 1;
            idle.Enqueue(newWorker);
          }

        }

    }
}
