using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Xml.Serialization;
using DomainPro.Core.Types;
using DomainPro.Designer;
using DomainPro.Designer.Types;
using DomainPro.Designer.Controls;

namespace Designer.Types
{
    public class VolunteerPool : DP_Shape
    {

        private int PoolSizeValue = 1;

        [DisplayName("PoolSize"),
        Category("Parameters"),
        DefaultValue(1),
        Description("")]
        public int PoolSize
        {
            get { return PoolSizeValue; }
            set { PoolSizeValue = value; }
        }

        private double VolunteerReliabilityValue = 1;

        [DisplayName("VolunteerReliability"),
        Category("Parameters"),
        DefaultValue(1),
        Description("")]
        public double VolunteerReliability
        {
            get { return VolunteerReliabilityValue; }
            set { VolunteerReliabilityValue = value; }
        }

        private double ProcessingPowerValue = 1;

        [DisplayName("ProcessingPower"),
        Category("Parameters"),
        DefaultValue(1),
        Description("")]
        public double ProcessingPower
        {
            get { return ProcessingPowerValue; }
            set { ProcessingPowerValue = value; }
        }


        private List<DP_Worker> workers = new List<DP_Worker>();

        [DisplayName("Workers"),
        Category("Simulation"),
        Description("A list of workers provided by the resource.")]
        public List<DP_Worker> Workers
        {
            get { return workers; }
            set { workers = value; }
        }

        private List<DP_Queue> queues = new List<DP_Queue>();

        [DisplayName("Queues"),
        Category("Simulation"),
        Description("A list of job categories handled by the resource.")]
        public List<DP_Queue> Queues
        {
            get { return queues; }
            set { queues = value; }
        }


        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Icon;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 2;
            ShapeProperties.FillColor = Color.FromArgb(255, 255, 255, 255);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(255, 224, 224, 224);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopCenter;
            ShapeProperties.Icon = "VolunteerPool.png";

            Name = "NewVolunteerPool";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Resource;
            Size = new Size(180, 215);
            NameFont = new Font("Segoe UI", (float)11, FontStyle.Bold);
        }

        public VolunteerPool()
        {
        }

        public VolunteerPool(Point startLocation) :
            base(startLocation)
        {
            Diagram = new VolunteerPoolStructure();
            Text = new DP_Text();
        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
            Diagram.Initialize(this);
        }

        public override DP_ConcreteType Duplicate()
        {
            VolunteerPool newType = new VolunteerPool();
            newType.Diagram = new VolunteerPoolStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is VolunteerPool)
            {
              base.Copy(source);
              VolunteerPool srcVolunteerPool = source as VolunteerPool;
              PoolSize = srcVolunteerPool.PoolSize;
              VolunteerReliability = srcVolunteerPool.VolunteerReliability;
              ProcessingPower = srcVolunteerPool.ProcessingPower;
        Workers = srcVolunteerPool.Workers;
        Queues = srcVolunteerPool.Queues;
            }
        }
    }
}
