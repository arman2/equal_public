using System;
using System.Collections;
using System.Collections.Generic;
using DomainPro.Analyst;
using DomainPro.Analyst.Interfaces;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;
using Analyst.Types;

namespace Simulation
{
    using NewContainerContext;

    public class SimpleModel : DP_Model, DP_IModel
    {
        private List<NewContainer> NewContainerInstances = new List<NewContainer>();

        public List<NewContainer> NewContainerList
        {
          get
          {
            return NewContainerInstances;
          }
          set
          {
            NewContainerInstances = value;
          }
        }

        public void Initialize()
        {

NewContainerList[0].NewRunsOnList[0].NewInputGenerator = NewContainerList[0].NewInputGeneratorList[0];
NewContainerList[0].NewRunsOnList[0].NewProcessor = NewContainerList[0].NewProcessorList[0];
        }

    }
}
