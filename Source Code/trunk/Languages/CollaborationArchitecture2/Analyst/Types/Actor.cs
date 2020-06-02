using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class Actor : Collaborator
    {

        private double UpdateFrequencyValue = 0;

        [DisplayNameAttribute("UpdateFrequency"),
        CategoryAttribute("ActionFrequencies"),
        DefaultValueAttribute(0),
        DescriptionAttribute("")]
        public double UpdateFrequency
        {
            get { return UpdateFrequencyValue; }
            set { UpdateFrequencyValue = value; }
        }

        private double ReadFrequencyValue = 1;

        [DisplayNameAttribute("ReadFrequency"),
        CategoryAttribute("ActionFrequencies"),
        DefaultValueAttribute(1),
        DescriptionAttribute("")]
        public double ReadFrequency
        {
            get { return ReadFrequencyValue; }
            set { ReadFrequencyValue = value; }
        }

        private double CreateFrequencyValue = 0;

        [DisplayNameAttribute("CreateFrequency"),
        CategoryAttribute("ActionFrequencies"),
        DefaultValueAttribute(0),
        DescriptionAttribute("")]
        public double CreateFrequency
        {
            get { return CreateFrequencyValue; }
            set { CreateFrequencyValue = value; }
        }

        private double DeleteFrequencyValue = 0;

        [DisplayNameAttribute("DeleteFrequency"),
        CategoryAttribute("ActionFrequencies"),
        DefaultValueAttribute(0),
        DescriptionAttribute("")]
        public double DeleteFrequency
        {
            get { return DeleteFrequencyValue; }
            set { DeleteFrequencyValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Component;
            base.Initialize(parentStructure);
        }

    }
}
