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

namespace Simulation.NewContainerContext
{

    public class NewRunsOn : DP_Dependency, DP_IDependency
    {
        public NewContainer NewContainer;

        private NewContainerContext.NewInputGenerator NewInputGeneratorInstance;

        public NewContainerContext.NewInputGenerator NewInputGenerator
        {
          get
          {
            return NewInputGeneratorInstance;
          }
          set
          {
            NewInputGeneratorInstance = (NewContainerContext.NewInputGenerator)value;
            if (Object != value)
            {
              Object = value;
            }
          }
        }

        private NewContainerContext.NewProcessor NewProcessorInstance;

        public NewContainerContext.NewProcessor NewProcessor
        {
          get
          {
            return NewProcessorInstance;
          }
          set
          {
            NewProcessorInstance = (NewContainerContext.NewProcessor)value;
            if (Resource != value)
            {
              Resource = value;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
