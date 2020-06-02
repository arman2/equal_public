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

    public class CheckUpdate : DP_Method, DP_IMethod
    {
        public ConflictDetection ConflictDetection;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
ConflictDetection.isIdle = false;
if (!ConflictDetection.isIdleInternal)
	return;
ConflictDetection.isIdleInternal = false;

while (ConflictDetection.InQueue.Count > 0)
{	
	StatusArtifact sa = ConflictDetection.InQueue.Dequeue();	
			
	while ((sa.UpdateList == null || sa.UpdateList.Count == 0)&& ConflictDetection.InQueue.Count > 0)
	{
		sa = ConflictDetection.InQueue.Dequeue();
	}
	Simulation.MonSysContext.StatusArtifactContext.Update up = sa.UpdateList[0];	
	// each change results in the SA to be placed in the ChangedCode queue, 
	// so we only observe the first UPDATE list item, and remove it after processing.
	if (up.UpdateOnVersion == sa.Version && sa.Version == 0) 
	{			
		// new Code
		sa.Version++;
		up.isUpdateSuccess = true;
	}	
	else
	{	
		if (up.UpdateOnVersion != sa.Version) 
		{			
			sa.NrConflicts++;
			up.isUpdateSuccess = false;
			ConflictDetection.AccessCoordinator.UpdateConflict++;
		}
		else
		{
			up.isUpdateSuccess = true;
			sa.Version++;
			ConflictDetection.AccessCoordinator.UpdateSuccess++;
			// set the Link to the Update object that contains the right update, 
			// other updates afterwards are bound to fail
			// set the link in any case, as both success and failure cases need it
		}					
	}
	sa.UpdateList.RemoveAt(0);
	ConflictDetection.OutQueue.Enqueue(up);
}
ConflictDetection.isIdleInternal = true;	
        }

        public override double Duration
        {
          get
          {
return ConflictDetection.AccessCoordinator.WorkExeDuration;
          }
        }

    }
}
