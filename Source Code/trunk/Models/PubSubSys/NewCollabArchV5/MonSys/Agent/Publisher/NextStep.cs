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
using Simulation.MonSysContext;
using Simulation.MonSysContext.AgentContext;

namespace Simulation.MonSysContext.AgentContext.PublisherContext
{
    using NextStepContext;

    public class NextStep : DP_Method, DP_IMethod
    {
        public Publisher Publisher;

        private Choice ChoiceInstance;

        public Choice ChoiceData
        {
          get
          {
            return ChoiceInstance;
          }
          set
          {
            ChoiceInstance = value;
          }
        }

        public int Choice
        {
          get
          {
            return ChoiceInstance.Value;
          }
          set
          {
            ChoiceInstance.Value = value;
          }
        }

        public override void Initialize()
        {
          base.Initialize();

          ChoiceInstance = (Choice)Create("Choice");

        }

        public override void Run()
        {
double rand = Random.Uniform();
double createProb = Publisher.CreateP;
if (Publisher.regTopic.IsPartOfHotspot)
	createProb = createProb*2;

switch(Publisher.PubType)
{
	case 0: //sensor
	if (rand <= createProb)
		Choice = 1;
	else 
		Choice = 0;
	break;
	case 1: // onsite staff
 	case 2: // backoffice staff
	if (Publisher.ProcEvents.Count > 0)
		Choice = 1;
	else if (rand <= createProb/2)
		Choice = 1;
	else 
		Choice = 0;
	break;
	case 3: // backoffice team leader
		// don't publish, just deal with a found situation but not here.
	default: 	
	break;
}

        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
