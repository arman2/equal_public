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
    using HuaweiTestingContainerContext;

    public class NewHuaweiTesting : DP_Model, DP_IModel
    {
        private List<HuaweiTestingContainer> HuaweiTestingContainerInstances = new List<HuaweiTestingContainer>();

        public List<HuaweiTestingContainer> HuaweiTestingContainerList
        {
          get
          {
            return HuaweiTestingContainerInstances;
          }
          set
          {
            HuaweiTestingContainerInstances = value;
          }
        }

        public void Initialize()
        {

HuaweiTestingContainerList[0].NewRunsOnList[0].NewTestScheduler = HuaweiTestingContainerList[0].NewTestSchedulerList[0];
HuaweiTestingContainerList[0].NewRunsOnList[0].NewResourcePool = HuaweiTestingContainerList[0].NewResourcePoolList[0];
        }

    }
}
