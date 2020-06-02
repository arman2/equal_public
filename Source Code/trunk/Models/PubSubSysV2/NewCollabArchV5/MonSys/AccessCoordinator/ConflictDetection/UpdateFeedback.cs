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
using Simulation.MonSysContext.AccessCoordinatorContext;

namespace Simulation.MonSysContext.AccessCoordinatorContext.ConflictDetectionContext
{

    public class UpdateFeedback : DP_Method, DP_IMethod
    {
        public ConflictDetection ConflictDetection;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
while (ConflictDetection.OutQueue.Count > 0)
{
	Simulation.MonSysContext.StatusArtifactContext.Update up = ConflictDetection.OutQueue.Dequeue();
	//up.WorkingOnUpdate.ReadFeedback(false); not working because LINK is null, not sure why, should not be.
	up.Responsible.ReadFeedback(false);
}
ConflictDetection.isIdle = true;
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
