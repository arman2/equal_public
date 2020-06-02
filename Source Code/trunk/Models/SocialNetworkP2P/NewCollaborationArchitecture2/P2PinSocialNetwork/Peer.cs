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
    using PeerContext;

    public class Peer : DP_Component, DP_IComponent
    {
        public P2PinSocialNetwork P2PinSocialNetwork;

        public System.Double UpdateFrequency
        {
          get { return ((Actor)Type).UpdateFrequency; }
        }

        public System.Double ReadFrequency
        {
          get { return ((Actor)Type).ReadFrequency; }
        }

        public System.Double CreateFrequency
        {
          get { return ((Actor)Type).CreateFrequency; }
        }

        public System.Double DeleteFrequency
        {
          get { return ((Actor)Type).DeleteFrequency; }
        }

        public void Read(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("Read");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void NextStep(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("NextStep");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void FwdCreate(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("FwdCreate");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        public void CreateMsg(bool sync = false)
        {
          DP_IMethod method = (DP_IMethod)Create("CreateMsg");
          DP_Schedulable schedulable = new DP_Schedulable(Model.Simulation.Simulator, method);
          schedulable.Schedule();
          if (sync)
          {
            Model.Simulation.Simulator.BlockedEvents[Thread.CurrentThread.ManagedThreadId].Set();
            method.Completed.WaitOne();
          }
        }

        private FriendList FriendListInstance;

        public FriendList FriendListData
        {
          get
          {
            return FriendListInstance;
          }
          set
          {
            FriendListInstance = value;
          }
        }

        public List<int> FriendList
        {
          get
          {
            return FriendListInstance.Value;
          }
          set
          {
            FriendListInstance.Value = value;
          }
        }

        private PeerReceivedMsgs PeerReceivedMsgsInstance;

        public PeerReceivedMsgs PeerReceivedMsgsData
        {
          get
          {
            return PeerReceivedMsgsInstance;
          }
          set
          {
            PeerReceivedMsgsInstance = value;
          }
        }

        public List<String> PeerReceivedMsgs
        {
          get
          {
            return PeerReceivedMsgsInstance.Value;
          }
          set
          {
            PeerReceivedMsgsInstance.Value = value;
          }
        }

        private OriginMsgCounter OriginMsgCounterInstance;

        public OriginMsgCounter OriginMsgCounterData
        {
          get
          {
            return OriginMsgCounterInstance;
          }
          set
          {
            OriginMsgCounterInstance = value;
          }
        }

        public int OriginMsgCounter
        {
          get
          {
            return OriginMsgCounterInstance.Value;
          }
          set
          {
            OriginMsgCounterInstance.Value = value;
          }
        }

        private PeerID PeerIDInstance;

        public PeerID PeerIDData
        {
          get
          {
            return PeerIDInstance;
          }
          set
          {
            PeerIDInstance = value;
          }
        }

        public string PeerID
        {
          get
          {
            return PeerIDInstance.Value;
          }
          set
          {
            PeerIDInstance.Value = value;
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

        private MsgFwdbox MsgFwdboxInstance;

        public MsgFwdbox MsgFwdboxData
        {
          get
          {
            return MsgFwdboxInstance;
          }
          set
          {
            MsgFwdboxInstance = value;
          }
        }

        public Queue<OutMessage> MsgFwdbox
        {
          get
          {
            return MsgFwdboxInstance.Value;
          }
          set
          {
            MsgFwdboxInstance.Value = value;
          }
        }

        private ReceivedCounter ReceivedCounterInstance;

        public ReceivedCounter ReceivedCounterData
        {
          get
          {
            return ReceivedCounterInstance;
          }
          set
          {
            ReceivedCounterInstance = value;
          }
        }

        public int ReceivedCounter
        {
          get
          {
            return ReceivedCounterInstance.Value;
          }
          set
          {
            ReceivedCounterInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          FriendListInstance = (FriendList)Create("FriendList");
          PeerReceivedMsgsInstance = (PeerReceivedMsgs)Create("PeerReceivedMsgs");
          OriginMsgCounterInstance = (OriginMsgCounter)Create("OriginMsgCounter");
          PeerIDInstance = (PeerID)Create("PeerID");
          MsgInboxInstance = (MsgInbox)Create("MsgInbox");
          MsgFwdboxInstance = (MsgFwdbox)Create("MsgFwdbox");
          ReceivedCounterInstance = (ReceivedCounter)Create("ReceivedCounter");

            Startup();
        }

    }
}
