using System;
using System.Collections;
using System.Collections.Generic;
using DomainPro.Analyst;
using DomainPro.Analyst.Interfaces;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;
using Analyst.Types;

namespace Simulation
{
    using P2PinSocialNetworkContext;

    public class NewCollaborationArchitecture2 : DP_Model, DP_IModel
    {
        private List<P2PinSocialNetwork> P2PinSocialNetworkInstances = new List<P2PinSocialNetwork>();

        public List<P2PinSocialNetwork> P2PinSocialNetworkList
        {
          get
          {
            return P2PinSocialNetworkInstances;
          }
          set
          {
            P2PinSocialNetworkInstances = value;
          }
        }

        public void Initialize()
        {

foreach (P2PinSocialNetwork s in P2PinSocialNetworkList)
{
	int i = 0;
	foreach (Peer p in s.PeerList)
	{
		p.PeerID = "Peer"+i;
		i++;
	}
}
        }

    }
}
