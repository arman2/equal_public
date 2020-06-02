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
    using P2PinSocialNetworkContext;

    public class P2PinSocialNetwork : DP_Component, DP_IComponent
    {
        private List<PeerNetwork> PeerNetworkInstances = new List<PeerNetwork>();

        public List<PeerNetwork> PeerNetworkList
        {
          get
          {
            return PeerNetworkInstances;
          }
          set
          {
            PeerNetworkInstances = value;
          }
        }

        private List<NewCollabConnection> NewCollabConnectionInstances = new List<NewCollabConnection>();

        public List<NewCollabConnection> NewCollabConnectionList
        {
          get
          {
            return NewCollabConnectionInstances;
          }
          set
          {
            NewCollabConnectionInstances = value;
          }
        }

        private List<NewTriggerConnection> NewTriggerConnectionInstances = new List<NewTriggerConnection>();

        public List<NewTriggerConnection> NewTriggerConnectionList
        {
          get
          {
            return NewTriggerConnectionInstances;
          }
          set
          {
            NewTriggerConnectionInstances = value;
          }
        }

        private List<Peer> PeerInstances = new List<Peer>();

        public List<Peer> PeerList
        {
          get
          {
            return PeerInstances;
          }
          set
          {
            PeerInstances = value;
          }
        }

        private List<OutMessage> OutMessageInstances = new List<OutMessage>();

        public List<OutMessage> OutMessageList
        {
          get
          {
            return OutMessageInstances;
          }
          set
          {
            OutMessageInstances = value;
          }
        }

        private List<NewTriggerConnection2> NewTriggerConnection2Instances = new List<NewTriggerConnection2>();

        public List<NewTriggerConnection2> NewTriggerConnection2List
        {
          get
          {
            return NewTriggerConnection2Instances;
          }
          set
          {
            NewTriggerConnection2Instances = value;
          }
        }

        private List<NewCollabConnection1> NewCollabConnection1Instances = new List<NewCollabConnection1>();

        public List<NewCollabConnection1> NewCollabConnection1List
        {
          get
          {
            return NewCollabConnection1Instances;
          }
          set
          {
            NewCollabConnection1Instances = value;
          }
        }

        private List<NewCollabConnection2> NewCollabConnection2Instances = new List<NewCollabConnection2>();

        public List<NewCollabConnection2> NewCollabConnection2List
        {
          get
          {
            return NewCollabConnection2Instances;
          }
          set
          {
            NewCollabConnection2Instances = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();


            Startup();
        }

    }
}
