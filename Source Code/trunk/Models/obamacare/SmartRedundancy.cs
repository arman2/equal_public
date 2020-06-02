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
    using SmartRedundancySystemContext;

    public class SmartRedundancy : DP_Model, DP_IModel
    {
        private List<SmartRedundancySystem> SmartRedundancySystemInstances = new List<SmartRedundancySystem>();

        public List<SmartRedundancySystem> SmartRedundancySystemList
        {
          get
          {
            return SmartRedundancySystemInstances;
          }
          set
          {
            SmartRedundancySystemInstances = value;
          }
        }

        public void Initialize()
        {

foreach (SmartRedundancySystem t in SmartRedundancySystemList)
{

	for (int i = 0; i < t.NewProblemSubmissionList.Count; i++)
	{
    		t.NewProblemSubmissionList[i].Problem = t.ProblemList[i];
    		t.NewProblemSubmissionList[i].SimpleJobServer = t.SimpleJobServerList[i];
	}

	for (int i = 0; i < t.VolunteerNetworkList.Count; i++)
	{
    		t.VolunteerNetworkList[i].Volunteers = t.VolunteersList[i];
    		t.VolunteerNetworkList[i].SimpleJobServer = t.SimpleJobServerList[i];
	}

}

        }

    }
}
