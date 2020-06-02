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
    using PatientFlowContext;

    public class PatientFlow : DP_Component, DP_IComponent
    {
        public void SeeDoctor()
        {
          DP_IMethod method = (DP_IMethod)Create("SeeDoctor");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
          method.Completed.WaitOne();
        }

        public void Live()
        {
          DP_IMethod method = (DP_IMethod)Create("Live");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
          method.Completed.WaitOne();
        }

        public void Die()
        {
          DP_IMethod method = (DP_IMethod)Create("Die");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
          method.Completed.WaitOne();
        }

        public void PatientArrival()
        {
          DP_IMethod method = (DP_IMethod)Create("PatientArrival");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
          method.Completed.WaitOne();
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
