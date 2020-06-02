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
    using MonSysContext;

    public class NewCollabArchV5 : DP_Model, DP_IModel
    {
        private List<MonSys> MonSysInstances = new List<MonSys>();

        public List<MonSys> MonSysList
        {
          get
          {
            return MonSysInstances;
          }
          set
          {
            MonSysInstances = value;
          }
        }

        public void Initialize()
        {

MonSysList[0].AnalysisTeamList[0].TaskAssignmentList[0].CrowdDep.AnalysisCrowd = MonSysList[0].AnalysisCrowdList[0];
        }

    }
}
