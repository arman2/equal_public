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

namespace Simulation.MonSysContext.StatusArtifactContext
{

    public class Updated : DP_Method, DP_IMethod
    {
        public StatusArtifact StatusArtifact;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
StatusArtifact.MonSys.AccessCoordinatorList[0].ConflictDetectionList[0].InQueue.Enqueue(StatusArtifact);
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
