using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class InputGenerator : DP_ComponentType
    {

        private int MyPropValue = 0;

        [DisplayNameAttribute("MyProp"),
        CategoryAttribute("NewPropertyGroup"),
        DefaultValueAttribute(0),
        DescriptionAttribute("")]
        public int MyProp
        {
            get { return MyPropValue; }
            set { MyPropValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
