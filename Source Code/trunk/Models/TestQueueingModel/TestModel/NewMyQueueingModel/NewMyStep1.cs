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

    public class NewMyStep1 : DP_Method, DP_IMethod
    {
        public NewMyQueueingModel NewMyQueueingModel;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
