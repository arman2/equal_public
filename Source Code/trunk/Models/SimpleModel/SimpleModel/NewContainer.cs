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

namespace Simulation
{
    using NewContainerContext;

    public class NewContainer : DP_Component, DP_IComponent
    {
        private List<NewInputGenerator> NewInputGeneratorInstances = new List<NewInputGenerator>();

        public List<NewInputGenerator> NewInputGeneratorList
        {
          get
          {
            return NewInputGeneratorInstances;
          }
          set
          {
            NewInputGeneratorInstances = value;
          }
        }

        private List<NewProcessor> NewProcessorInstances = new List<NewProcessor>();

        public List<NewProcessor> NewProcessorList
        {
          get
          {
            return NewProcessorInstances;
          }
          set
          {
            NewProcessorInstances = value;
          }
        }

        private List<NewRunsOn> NewRunsOnInstances = new List<NewRunsOn>();

        public List<NewRunsOn> NewRunsOnList
        {
          get
          {
            return NewRunsOnInstances;
          }
          set
          {
            NewRunsOnInstances = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();


            Startup();
        }

        public void Startup()
        {
        }

    }
}
