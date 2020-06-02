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

namespace Simulation.HuaweiTestingContainerContext
{

    public class NewResourcePool : DP_Resource, DP_IResource
    {
        public HuaweiTestingContainer HuaweiTestingContainer;

        private NewRunsOn NewRunsOnInstance;
        public NewRunsOn NewRunsOn
        {
          get
          {
            return NewRunsOnInstance;
          }
          set
          {
            NewRunsOnInstance = value;
            if (NewRunsOnInstance != null && NewRunsOnInstance.Resource != this)
            {
              NewRunsOnInstance.Resource = this;
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
