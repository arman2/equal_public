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
using Simulation.SmartRedundancySystemContext;

namespace Simulation.SmartRedundancySystemContext.SimpleJobServerContext
{

    public class UniformJobQueue : DP_Data, DP_IData
    {
        public SimpleJobServer SimpleJobServer;

        public new Queue<UniformJob> Value
        {
          get
          {
            return (Queue<UniformJob>)val;
          }
          set
          {
            OnDataChanged(new DP_DataChangedEventArgs(Id, Context.Id, Model.Simulation.Simulator.Scheduler.Time, value));
            val = value;
          }
        }

        public Double Size
        {
          get { return 0; }
        }

        private FrontOfQueue FrontOfQueueInstance;

        public FrontOfQueue FrontOfQueueLink
        {
          get
          {
            return FrontOfQueueInstance;
          }
          set
          {
            if (FrontOfQueueInstance == value)
            {
              return;
            }
            FrontOfQueueInstance = value;
            if (FrontOfQueueInstance != null && FrontOfQueueInstance.Role1 != this)
            {
              FrontOfQueueInstance.Role1 = this;
            }
          }
        }

        public SmartRedundancySystemContext.SimpleJobServerContext.GetNextJob FrontOfQueue
        {
          get
          {
            return FrontOfQueueInstance.GetNextJob;
          }
          set
          {
            FrontOfQueueInstance.GetNextJob = value;
          }
        }

        private EndOfQueue EndOfQueueInstance;

        public EndOfQueue EndOfQueueLink
        {
          get
          {
            return EndOfQueueInstance;
          }
          set
          {
            if (EndOfQueueInstance == value)
            {
              return;
            }
            EndOfQueueInstance = value;
            if (EndOfQueueInstance != null && EndOfQueueInstance.Role2 != this)
            {
              EndOfQueueInstance.Role2 = this;
            }
          }
        }

        public SmartRedundancySystemContext.SimpleJobServerContext.HandleResult EndOfQueue
        {
          get
          {
            return EndOfQueueInstance.HandleResult;
          }
          set
          {
            EndOfQueueInstance.HandleResult = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();


            Value = new Queue<UniformJob>();
        }

    }
}
