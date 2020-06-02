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
    using NfyMsgContext;

    public class NfyMsg : DP_Component, DP_IComponent
    {
        public MonSys MonSys;

        public void Created(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Created");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private MsgList MsgListInstance;

        public MsgList MsgListData
        {
          get
          {
            return MsgListInstance;
          }
          set
          {
            MsgListInstance = value;
          }
        }

        public List<PubMsg> MsgList
        {
          get
          {
            return MsgListInstance.Value;
          }
          set
          {
            MsgListInstance.Value = value;
          }
        }

        private Receiver ReceiverInstance;

        public Receiver ReceiverData
        {
          get
          {
            return ReceiverInstance;
          }
          set
          {
            ReceiverInstance = value;
          }
        }

        public Simulation.MonSysContext.AgentContext.SubscriberComp Receiver
        {
          get
          {
            return ReceiverInstance.Value;
          }
          set
          {
            ReceiverInstance.Value = value;
          }
        }

        private NewFocusOnObjConn1 NewFocusOnObjConn1Instance;

        public NewFocusOnObjConn1 NewFocusOnObjConn1Link
        {
          get
          {
            return NewFocusOnObjConn1Instance;
          }
          set
          {
            if (NewFocusOnObjConn1Instance == value)
            {
              return;
            }
            NewFocusOnObjConn1Instance = value;
            if (NewFocusOnObjConn1Instance != null && NewFocusOnObjConn1Instance.Role2 != this)
            {
              NewFocusOnObjConn1Instance.Role2 = this;
            }
          }
        }

        public MonSysContext.PubSubMWContext.EventCoord NewFocusOnObjConn1
        {
          get
          {
            return NewFocusOnObjConn1Instance.EventCoord;
          }
          set
          {
            NewFocusOnObjConn1Instance.EventCoord = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          MsgListInstance = (MsgList)Create("MsgList");
          ReceiverInstance = (Receiver)Create("Receiver");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
