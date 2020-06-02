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

namespace Simulation.NewMyQueueingModelContext
{

    public class NewMyFlow3 : DP_Flow, DP_IFlow
    {
        public NewMyQueueingModel NewMyQueueingModel;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          NewMyQueueingModelContext.NewMyStep1 NewMyStep1 = source as NewMyQueueingModelContext.NewMyStep1;
return false;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          NewMyQueueingModelContext.NewMyStep1 NewMyStep1 = source as NewMyQueueingModelContext.NewMyStep1;
          NewMyQueueingModelContext.NewMyDestination NewMyDestination = target as NewMyQueueingModelContext.NewMyDestination;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          NewMyQueueingModelContext.NewMyStep1 NewMyStep1 = source as NewMyQueueingModelContext.NewMyStep1;
return Context;        }

    }
}
