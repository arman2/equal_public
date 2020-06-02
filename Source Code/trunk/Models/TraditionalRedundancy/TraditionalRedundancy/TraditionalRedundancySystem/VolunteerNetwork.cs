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

namespace Simulation.TraditionalRedundancySystemContext
{

    public class VolunteerNetwork : DP_Dependency, DP_IDependency
    {
        public TraditionalRedundancySystem TraditionalRedundancySystem;

        private TraditionalRedundancySystemContext.SimpleJobServer SimpleJobServerInstance;

        public TraditionalRedundancySystemContext.SimpleJobServer SimpleJobServer
        {
          get
          {
            return SimpleJobServerInstance;
          }
          set
          {
            SimpleJobServerInstance = (TraditionalRedundancySystemContext.SimpleJobServer)value;
            if (Object != value)
            {
              Object = value;
            }
          }
        }

        private TraditionalRedundancySystemContext.Volunteers VolunteersInstance;

        public TraditionalRedundancySystemContext.Volunteers Volunteers
        {
          get
          {
            return VolunteersInstance;
          }
          set
          {
            VolunteersInstance = (TraditionalRedundancySystemContext.Volunteers)value;
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
