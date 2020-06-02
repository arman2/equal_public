using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public abstract class Role : DP_ComponentType
    {

        private double CreatePValue = 0.0;

        [DisplayNameAttribute("CreateP"),
        CategoryAttribute("ActionProbabilities"),
        DefaultValueAttribute(0.0),
        DescriptionAttribute("")]
        public double CreateP
        {
            get { return CreatePValue; }
            set { CreatePValue = value; }
        }

        private double ReadPValue = 0.0;

        [DisplayNameAttribute("ReadP"),
        CategoryAttribute("ActionProbabilities"),
        DefaultValueAttribute(0.0),
        DescriptionAttribute("")]
        public double ReadP
        {
            get { return ReadPValue; }
            set { ReadPValue = value; }
        }

        private double UpdatePValue = 0.0;

        [DisplayNameAttribute("UpdateP"),
        CategoryAttribute("ActionProbabilities"),
        DefaultValueAttribute(0.0),
        DescriptionAttribute("")]
        public double UpdateP
        {
            get { return UpdatePValue; }
            set { UpdatePValue = value; }
        }

        private double DeletePValue = 0.0;

        [DisplayNameAttribute("DeleteP"),
        CategoryAttribute("ActionProbabilities"),
        DefaultValueAttribute(0.0),
        DescriptionAttribute("")]
        public double DeleteP
        {
            get { return DeletePValue; }
            set { DeletePValue = value; }
        }

        private double IdlePValue = 0.0;

        [DisplayNameAttribute("IdleP"),
        CategoryAttribute("ActionProbabilities"),
        DefaultValueAttribute(0.0),
        DescriptionAttribute("")]
        public double IdleP
        {
            get { return IdlePValue; }
            set { IdlePValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
