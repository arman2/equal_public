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
using Simulation.FacilityContext;

namespace Simulation.FacilityContext.ProcedureRoomsContext
{

    public class PhysicianReport : DP_Method, DP_IMethod
    {
        public ProcedureRooms ProcedureRooms;

        public override void Initialize()
        {
          base.Initialize();


        }

    }
}
