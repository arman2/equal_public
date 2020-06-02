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
using Simulation.NewContainerContext;

namespace Simulation.NewContainerContext.NewInputGeneratorContext
{

    public class NewFunction1 : DP_Method, DP_IMethod
    {
        public NewInputGenerator NewInputGenerator;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
DomainProAnalyst.Instance.Report(NewInputGenerator.MyProp.ToString());        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
