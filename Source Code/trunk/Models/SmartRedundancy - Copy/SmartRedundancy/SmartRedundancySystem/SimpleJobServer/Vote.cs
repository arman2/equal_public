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
using Simulation.SmartRedundancySystemContext;

namespace Simulation.SmartRedundancySystemContext.SimpleJobServerContext
{
    using VoteContext;

    public class Vote : DP_Component, DP_IComponent
    {
        public SimpleJobServer SimpleJobServer;

        private Correct CorrectInstance;

        public Correct CorrectData
        {
          get
          {
            return CorrectInstance;
          }
          set
          {
            CorrectInstance = value;
          }
        }

        public int Correct
        {
          get
          {
            return CorrectInstance.Value;
          }
          set
          {
            CorrectInstance.Value = value;
          }
        }

        private Incorrect IncorrectInstance;

        public Incorrect IncorrectData
        {
          get
          {
            return IncorrectInstance;
          }
          set
          {
            IncorrectInstance = value;
          }
        }

        public int Incorrect
        {
          get
          {
            return IncorrectInstance.Value;
          }
          set
          {
            IncorrectInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          CorrectInstance = (Correct)Create("Correct");
          IncorrectInstance = (Incorrect)Create("Incorrect");

            Startup();
        }

        public void Startup()
        {
        }

    }
}
