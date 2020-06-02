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

    public class NewMyFlow2 : DP_Flow, DP_IFlow
    {
        public NewMyQueueingModel NewMyQueueingModel;

        public override void Initialize()
        {
          base.Initialize();


        }

        public bool Trigger(DP_IMethod source)
        {
          NewMyQueueingModelContext.NewMyStep NewMyStep = source as NewMyQueueingModelContext.NewMyStep;
return false;
        }

        public void Transfer(DP_IMethod source, DP_IMethod target)
        {
          NewMyQueueingModelContext.NewMyStep NewMyStep = source as NewMyQueueingModelContext.NewMyStep;
          NewMyQueueingModelContext.NewMyStep1 NewMyStep1 = target as NewMyQueueingModelContext.NewMyStep1;
        }

        public DP_IObject Resolve(DP_IMethod source)
        {
          NewMyQueueingModelContext.NewMyStep NewMyStep = source as NewMyQueueingModelContext.NewMyStep;
return Context;        }

    }
}
