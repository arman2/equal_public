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

namespace Simulation.SmartRedundancySystemContext
{

    public class VolunteerNetwork : DP_Dependency, DP_IDependency
    {
        public SmartRedundancySystem SmartRedundancySystem;

        private SmartRedundancySystemContext.SimpleJobServer SimpleJobServerInstance;

        public SmartRedundancySystemContext.SimpleJobServer SimpleJobServer
        {
          get
          {
            return SimpleJobServerInstance;
          }
          set
          {
            SimpleJobServerInstance = (SmartRedundancySystemContext.SimpleJobServer)value;
            if (Object != value)
            {
              Object = value;
            }
          }
        }

        private SmartRedundancySystemContext.Volunteers VolunteersInstance;

        public SmartRedundancySystemContext.Volunteers Volunteers
        {
          get
          {
            return VolunteersInstance;
          }
          set
          {
            VolunteersInstance = (SmartRedundancySystemContext.Volunteers)value;
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
