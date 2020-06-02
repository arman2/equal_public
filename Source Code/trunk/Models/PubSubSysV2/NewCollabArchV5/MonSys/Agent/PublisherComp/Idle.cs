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
using Simulation.MonSysContext;
using Simulation.MonSysContext.AgentContext;

namespace Simulation.MonSysContext.AgentContext.PublisherCompContext
{

    public class Idle : DP_Method, DP_IMethod
    {
        public PublisherComp PublisherComp;

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
//double dur = Random.Uniform()+0.5;
//if (PublisherComp.regTopic.IsPartOfHotspot)
//	return dur;
//else
//	return dur+0.5;

return Random.Uniform()+0.7;
          }
        }

    }
}
