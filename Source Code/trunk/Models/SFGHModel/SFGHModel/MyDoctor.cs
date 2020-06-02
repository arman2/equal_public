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

    public class MyDoctor : DP_Dependency, DP_IDependency
    {
        private Facility FacilityInstance;

        public Facility Facility
        {
          get
          {
            return FacilityInstance;
          }
          set
          {
            FacilityInstance = (Facility)value;
            if (Object != value)
            {
              Object = value;
            }
          }
        }

        private Physician PhysicianInstance;

        public Physician Physician
        {
          get
          {
            return PhysicianInstance;
          }
          set
          {
            PhysicianInstance = (Physician)value;
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
