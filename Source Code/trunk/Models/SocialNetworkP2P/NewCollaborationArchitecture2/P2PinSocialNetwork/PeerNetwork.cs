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
    using PeerNetworkContext;

    public class PeerNetwork : DP_Component, DP_IComponent
    {
        public P2PinSocialNetwork P2PinSocialNetwork;

        public void FwdMessage(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("FwdMessage");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private MaxRounds MaxRoundsInstance;

        public MaxRounds MaxRoundsData
        {
          get
          {
            return MaxRoundsInstance;
          }
          set
          {
            MaxRoundsInstance = value;
          }
        }

        public int MaxRounds
        {
          get
          {
            return MaxRoundsInstance.Value;
          }
          set
          {
            MaxRoundsInstance.Value = value;
          }
        }

        public void CacheMsg(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("CacheMsg");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void Idle(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Idle");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private ReceivedMsgs ReceivedMsgsInstance;

        public ReceivedMsgs ReceivedMsgsData
        {
          get
          {
            return ReceivedMsgsInstance;
          }
          set
          {
            ReceivedMsgsInstance = value;
          }
        }

        public int ReceivedMsgs
        {
          get
          {
            return ReceivedMsgsInstance.Value;
          }
          set
          {
            ReceivedMsgsInstance.Value = value;
          }
        }

        private MsgInbox MsgInboxInstance;

        public MsgInbox MsgInboxData
        {
          get
          {
            return MsgInboxInstance;
          }
          set
          {
            MsgInboxInstance = value;
          }
        }

        public Queue<OutMessage> MsgInbox
        {
          get
          {
            return MsgInboxInstance.Value;
          }
          set
          {
            MsgInboxInstance.Value = value;
          }
        }

        private MsgOutbox MsgOutboxInstance;

        public MsgOutbox MsgOutboxData
        {
          get
          {
            return MsgOutboxInstance;
          }
          set
          {
            MsgOutboxInstance = value;
          }
        }

        public Queue<OutMessage> MsgOutbox
        {
          get
          {
            return MsgOutboxInstance.Value;
          }
          set
          {
            MsgOutboxInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          MaxRoundsInstance = (MaxRounds)Create("MaxRounds");
          ReceivedMsgsInstance = (ReceivedMsgs)Create("ReceivedMsgs");
          MsgInboxInstance = (MsgInbox)Create("MsgInbox");
          MsgOutboxInstance = (MsgOutbox)Create("MsgOutbox");

            Startup();
        }

    }
}
