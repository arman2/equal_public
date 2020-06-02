using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using DomainPro.Core.Types;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;

namespace Analyst.Types
{
    public class Crowd : DP_ResourceType
    {

        private int ImageWorkerPoolSizeValue = 50;

        [DisplayNameAttribute("ImageWorkerPoolSize"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(50),
        DescriptionAttribute("")]
        public int ImageWorkerPoolSize
        {
            get { return ImageWorkerPoolSizeValue; }
            set { ImageWorkerPoolSizeValue = value; }
        }

        private int AudioWorkerPoolSizeValue = 30;

        [DisplayNameAttribute("AudioWorkerPoolSize"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(30),
        DescriptionAttribute("")]
        public int AudioWorkerPoolSize
        {
            get { return AudioWorkerPoolSizeValue; }
            set { AudioWorkerPoolSizeValue = value; }
        }

        private int VideoWorkerPoolSizeValue = 20;

        [DisplayNameAttribute("VideoWorkerPoolSize"),
        CategoryAttribute("Config"),
        DefaultValueAttribute(20),
        DescriptionAttribute("")]
        public int VideoWorkerPoolSize
        {
            get { return VideoWorkerPoolSizeValue; }
            set { VideoWorkerPoolSizeValue = value; }
        }


        public override void Initialize(DP_AbstractStructure parentStructure)
        {
            SimulationType = DP_SimulationType.Resource;
            base.Initialize(parentStructure);
        }

    }
}
