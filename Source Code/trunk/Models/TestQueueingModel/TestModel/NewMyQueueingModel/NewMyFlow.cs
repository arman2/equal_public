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

    public class NewMyFlow : DP_Flow, DP_IFlow
    {
        public NewMyQueueingModel NewMyQueueingModel;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          NewMyQueueingModelContext.NewMySource NewMySource = source as NewMyQueueingModelContext.NewMySource;
return false;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          NewMyQueueingModelContext.NewMySource NewMySource = source as NewMyQueueingModelContext.NewMySource;
          NewMyQueueingModelContext.NewMyStep NewMyStep = target as NewMyQueueingModelContext.NewMyStep;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          NewMyQueueingModelContext.NewMySource NewMySource = source as NewMyQueueingModelContext.NewMySource;
return Context;        }

    }
}
