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

    public class NewVolunteerPool : DP_Resource, DP_IResource
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

        private NewNetwork NewNetworkInstance;
        public NewNetwork NewNetwork
        {
          get
          {
            return NewNetworkInstance;
          }
          set
          {
            NewNetworkInstance = value;
            if (NewNetworkInstance != null && NewNetworkInstance.Resource != this)
            {
              NewNetworkInstance.Resource = this;
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

        }

    }
}
