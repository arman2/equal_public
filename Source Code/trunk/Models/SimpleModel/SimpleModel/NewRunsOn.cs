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

    public class NewRunsOn : DP_Dependency, DP_IDependency
    {
        private NewInputGenerator NewInputGeneratorInstance;

        public NewInputGenerator NewInputGenerator
        {
          get
          {
            return NewInputGeneratorInstance;
          }
          set
          {
            NewInputGeneratorInstance = (NewInputGenerator)value;
            if (Object != value)
            {
              Object = value;
            }
          }
        }

        private NewProcessor NewProcessorInstance;

        public NewProcessor NewProcessor
        {
          get
          {
            return NewProcessorInstance;
          }
          set
          {
            NewProcessorInstance = (NewProcessor)value;
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
