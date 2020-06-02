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

    public class EndOfQueue : DP_Link, DP_ILink
    {
        public SimpleJobServer SimpleJobServer;

        private SmartRedundancySystemContext.SimpleJobServerContext.HandleResult HandleResultInstance;

        public SmartRedundancySystemContext.SimpleJobServerContext.HandleResult HandleResult
        {
          get
          {
            return HandleResultInstance;
          }
          set
          {
            HandleResultInstance = (SmartRedundancySystemContext.SimpleJobServerContext.HandleResult)value;
            if (Role1 != value)
            {
              Role1 = value;
            }
          }
        }

        private SmartRedundancySystemContext.SimpleJobServerContext.UniformJobQueue UniformJobQueueInstance;

        public SmartRedundancySystemContext.SimpleJobServerContext.UniformJobQueue UniformJobQueue
        {
          get
          {
            return UniformJobQueueInstance;
          }
          set
          {
            UniformJobQueueInstance = (SmartRedundancySystemContext.SimpleJobServerContext.UniformJobQueue)value;
            if (Role2 != value)
            {
              Role2 = value;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
