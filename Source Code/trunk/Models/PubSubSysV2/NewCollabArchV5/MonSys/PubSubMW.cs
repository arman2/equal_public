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
    using PubSubMWContext;

    public class PubSubMW : DP_Component, DP_IComponent
    {
        public MonSys MonSys;

        public System.Double WorkExeDuration
        {
          get { return ((Collaborator)Type).WorkExeDuration; }
        }

        public System.Double EWMAalpha
        {
          get { return ((Collaborator)Type).EWMAalpha; }
        }

        private List<EventCoord> EventCoordInstances = new List<EventCoord>();

        public List<EventCoord> EventCoordList
        {
          get
          {
            return EventCoordInstances;
          }
          set
          {
            EventCoordInstances = value;
          }
        }

        private EWMAvgMsgDelivered EWMAvgMsgDeliveredInstance;

        public EWMAvgMsgDelivered EWMAvgMsgDeliveredData
        {
          get
          {
            return EWMAvgMsgDeliveredInstance;
          }
          set
          {
            EWMAvgMsgDeliveredInstance = value;
          }
        }

        public double EWMAvgMsgDelivered
        {
          get
          {
            return EWMAvgMsgDeliveredInstance.Value;
          }
          set
          {
            EWMAvgMsgDeliveredInstance.Value = value;
          }
        }

        private MsgLastDelivered MsgLastDeliveredInstance;

        public MsgLastDelivered MsgLastDeliveredData
        {
          get
          {
            return MsgLastDeliveredInstance;
          }
          set
          {
            MsgLastDeliveredInstance = value;
          }
        }

        public int MsgLastDelivered
        {
          get
          {
            return MsgLastDeliveredInstance.Value;
          }
          set
          {
            MsgLastDeliveredInstance.Value = value;
          }
        }

        private EventProcessed EventProcessedInstance;

        public EventProcessed EventProcessedData
        {
          get
          {
            return EventProcessedInstance;
          }
          set
          {
            EventProcessedInstance = value;
          }
        }

        public int EventProcessed
        {
          get
          {
            return EventProcessedInstance.Value;
          }
          set
          {
            EventProcessedInstance.Value = value;
          }
        }

        private TotalMsgDelivered TotalMsgDeliveredInstance;

        public TotalMsgDelivered TotalMsgDeliveredData
        {
          get
          {
            return TotalMsgDeliveredInstance;
          }
          set
          {
            TotalMsgDeliveredInstance = value;
          }
        }

        public int TotalMsgDelivered
        {
          get
          {
            return TotalMsgDeliveredInstance.Value;
          }
          set
          {
            TotalMsgDeliveredInstance.Value = value;
          }
        }

        private EWMAvgEventsProcessed EWMAvgEventsProcessedInstance;

        public EWMAvgEventsProcessed EWMAvgEventsProcessedData
        {
          get
          {
            return EWMAvgEventsProcessedInstance;
          }
          set
          {
            EWMAvgEventsProcessedInstance = value;
          }
        }

        public double EWMAvgEventsProcessed
        {
          get
          {
            return EWMAvgEventsProcessedInstance.Value;
          }
          set
          {
            EWMAvgEventsProcessedInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          EWMAvgMsgDeliveredInstance = (EWMAvgMsgDelivered)Create("EWMAvgMsgDelivered");
          MsgLastDeliveredInstance = (MsgLastDelivered)Create("MsgLastDelivered");
          EventProcessedInstance = (EventProcessed)Create("EventProcessed");
          TotalMsgDeliveredInstance = (TotalMsgDelivered)Create("TotalMsgDelivered");
          EWMAvgEventsProcessedInstance = (EWMAvgEventsProcessed)Create("EWMAvgEventsProcessed");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
