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
    using PatientFlowContext;

    public class TestModel : DP_Model, DP_IModel
    {
        private List<PatientFlow> PatientFlowInstances = new List<PatientFlow>();

        public List<PatientFlow> PatientFlowList
        {
          get
          {
            return PatientFlowInstances;
          }
          set
          {
            PatientFlowInstances = value;
          }
        }

        public void Initialize()
        {


        }

    }
}
