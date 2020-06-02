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

namespace Simulation.P2PinSocialNetworkContext
{
    using OutMessageContext;

    public class OutMessage : DP_Component, DP_IComponent
    {
        public P2PinSocialNetwork P2PinSocialNetwork;

        private Sender SenderInstance;

        public Sender SenderData
        {
          get
          {
            return SenderInstance;
          }
          set
          {
            SenderInstance = value;
          }
        }

        public string Sender
        {
          get
          {
            return SenderInstance.Value;
          }
          set
          {
            SenderInstance.Value = value;
          }
        }

        private Receivers ReceiversInstance;

        public Receivers ReceiversData
        {
          get
          {
            return ReceiversInstance;
          }
          set
          {
            ReceiversInstance = value;
          }
        }

        public List<int> Receivers
        {
          get
          {
            return ReceiversInstance.Value;
          }
          set
          {
            ReceiversInstance.Value = value;
          }
        }

        public void MsgCreated(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("MsgCreated");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private MsgId MsgIdInstance;

        public MsgId MsgIdData
        {
          get
          {
            return MsgIdInstance;
          }
          set
          {
            MsgIdInstance = value;
          }
        }

        public string MsgId
        {
          get
          {
            return MsgIdInstance.Value;
          }
          set
          {
            MsgIdInstance.Value = value;
          }
        }

        public void MsgDelivered(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("MsgDelivered");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private TTL TTLInstance;

        public TTL TTLData
        {
          get
          {
            return TTLInstance;
          }
          set
          {
            TTLInstance = value;
          }
        }

        public int TTL
        {
          get
          {
            return TTLInstance.Value;
          }
          set
          {
            TTLInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          SenderInstance = (Sender)Create("Sender");
          ReceiversInstance = (Receivers)Create("Receivers");
          MsgIdInstance = (MsgId)Create("MsgId");
          TTLInstance = (TTL)Create("TTL");

            Startup();
        }

    }
}
