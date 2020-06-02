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

namespace Simulation.MonSysContext
{
    using HotSpotContext;

    public class HotSpot : DP_Component, DP_IComponent
    {
        public MonSys MonSys;

        private DurDict DurDictInstance;

        public DurDict DurDictData
        {
          get
          {
            return DurDictInstance;
          }
          set
          {
            DurDictInstance = value;
          }
        }

        public Dictionary<int, double> DurDict
        {
          get
          {
            return DurDictInstance.Value;
          }
          set
          {
            DurDictInstance.Value = value;
          }
        }

        private CurrHotSpotId CurrHotSpotIdInstance;

        public CurrHotSpotId CurrHotSpotIdData
        {
          get
          {
            return CurrHotSpotIdInstance;
          }
          set
          {
            CurrHotSpotIdInstance = value;
          }
        }

        public int CurrHotSpotId
        {
          get
          {
            return CurrHotSpotIdInstance.Value;
          }
          set
          {
            CurrHotSpotIdInstance.Value = value;
          }
        }

        private UndetectedDict UndetectedDictInstance;

        public UndetectedDict UndetectedDictData
        {
          get
          {
            return UndetectedDictInstance;
          }
          set
          {
            UndetectedDictInstance = value;
          }
        }

        public Dictionary<int, double> UndetectedDict
        {
          get
          {
            return UndetectedDictInstance.Value;
          }
          set
          {
            UndetectedDictInstance.Value = value;
          }
        }

        public void SwitchHotSpot(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("SwitchHotSpot");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void Timer(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Timer");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private SwitchMoment SwitchMomentInstance;

        public SwitchMoment SwitchMomentData
        {
          get
          {
            return SwitchMomentInstance;
          }
          set
          {
            SwitchMomentInstance = value;
          }
        }

        public double SwitchMoment
        {
          get
          {
            return SwitchMomentInstance.Value;
          }
          set
          {
            SwitchMomentInstance.Value = value;
          }
        }

        private DetectionDuration DetectionDurationInstance;

        public DetectionDuration DetectionDurationData
        {
          get
          {
            return DetectionDurationInstance;
          }
          set
          {
            DetectionDurationInstance = value;
          }
        }

        public double DetectionDuration
        {
          get
          {
            return DetectionDurationInstance.Value;
          }
          set
          {
            DetectionDurationInstance.Value = value;
          }
        }

        private LastDuration LastDurationInstance;

        public LastDuration LastDurationData
        {
          get
          {
            return LastDurationInstance;
          }
          set
          {
            LastDurationInstance = value;
          }
        }

        public double LastDuration
        {
          get
          {
            return LastDurationInstance.Value;
          }
          set
          {
            LastDurationInstance.Value = value;
          }
        }

        private Undetected UndetectedInstance;

        public Undetected UndetectedData
        {
          get
          {
            return UndetectedInstance;
          }
          set
          {
            UndetectedInstance = value;
          }
        }

        public int Undetected
        {
          get
          {
            return UndetectedInstance.Value;
          }
          set
          {
            UndetectedInstance.Value = value;
          }
        }

        private EventBurstSourceCount EventBurstSourceCountInstance;

        public EventBurstSourceCount EventBurstSourceCountData
        {
          get
          {
            return EventBurstSourceCountInstance;
          }
          set
          {
            EventBurstSourceCountInstance = value;
          }
        }

        public int EventBurstSourceCount
        {
          get
          {
            return EventBurstSourceCountInstance.Value;
          }
          set
          {
            EventBurstSourceCountInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          DurDictInstance = (DurDict)Create("DurDict");
          CurrHotSpotIdInstance = (CurrHotSpotId)Create("CurrHotSpotId");
          UndetectedDictInstance = (UndetectedDict)Create("UndetectedDict");
          SwitchMomentInstance = (SwitchMoment)Create("SwitchMoment");
          DetectionDurationInstance = (DetectionDuration)Create("DetectionDuration");
          LastDurationInstance = (LastDuration)Create("LastDuration");
          UndetectedInstance = (Undetected)Create("Undetected");
          EventBurstSourceCountInstance = (EventBurstSourceCount)Create("EventBurstSourceCount");

            Startup();
        }

        public void Startup()
        {
CurrHotSpotId = 0;
double timeNow = Model.Simulation.Simulator.Scheduler.Time;
UndetectedDict.Add(CurrHotSpotId,timeNow);
SwitchMoment = timeNow;

        }

    }
}
