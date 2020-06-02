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
    using SmartRedundancySystemContext;

    public class SmartRedundancySystem : DP_Component, DP_IComponent
    {
        private List<Problem> ProblemInstances = new List<Problem>();

        public List<Problem> ProblemList
        {
          get
          {
            return ProblemInstances;
          }
          set
          {
            ProblemInstances = value;
          }
        }

        private List<Volunteers> VolunteersInstances = new List<Volunteers>();

        public List<Volunteers> VolunteersList
        {
          get
          {
            return VolunteersInstances;
          }
          set
          {
            VolunteersInstances = value;
          }
        }

        private List<SimpleJobServer> SimpleJobServerInstances = new List<SimpleJobServer>();

        public List<SimpleJobServer> SimpleJobServerList
        {
          get
          {
            return SimpleJobServerInstances;
          }
          set
          {
            SimpleJobServerInstances = value;
          }
        }

        private List<NewProblemSubmission> NewProblemSubmissionInstances = new List<NewProblemSubmission>();

        public List<NewProblemSubmission> NewProblemSubmissionList
        {
          get
          {
            return NewProblemSubmissionInstances;
          }
          set
          {
            NewProblemSubmissionInstances = value;
          }
        }

        private List<VolunteerNetwork> VolunteerNetworkInstances = new List<VolunteerNetwork>();

        public List<VolunteerNetwork> VolunteerNetworkList
        {
          get
          {
            return VolunteerNetworkInstances;
          }
          set
          {
            VolunteerNetworkInstances = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();


            Startup();
        }

        public void Startup()
        {
        }

    }
}
