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

namespace Simulation.FacilityContext
{
    using DecontaminationRoomContext;

    public class DecontaminationRoom : DP_Component, DP_IComponent
    {
        public Facility Facility;

        public void Decontaminate(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Decontaminate");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
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
