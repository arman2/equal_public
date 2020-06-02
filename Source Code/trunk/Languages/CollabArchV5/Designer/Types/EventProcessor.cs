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
    public class EventProcessor : Component
    {

        private double CapacityValue = 1;

        [DisplayName("Capacity"),
        Category("Config"),
        DefaultValue(1),
        Description("")]
        public double Capacity
        {
            get { return CapacityValue; }
            set { CapacityValue = value; }
        }

        private double ExeDurationValue = 1;

        [DisplayName("ExeDuration"),
        Category("Config"),
        DefaultValue(1),
        Description("")]
        public double ExeDuration
        {
            get { return ExeDurationValue; }
            set { ExeDurationValue = value; }
        }



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 3;
            ShapeProperties.FillColor = Color.FromArgb(255, 255, 255, 192);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopLeft;
            ShapeProperties.Icon = "";

            Name = "NewEventProcessor";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(200, 300);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public EventProcessor()
        {
        }

        public EventProcessor(Point startLocation) :
            base(startLocation)
        {
            Diagram = new EventProcessorStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction startup = new DP_AbstractText.Instruction();
            startup.Name = "Startup";
            startup.String = "";
            Text.Instructions.Add(startup);

        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
        }

        public override DP_ConcreteType Duplicate()
        {
            EventProcessor newType = new EventProcessor();
            newType.Diagram = new EventProcessorStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is EventProcessor)
            {
              base.Copy(source);
              EventProcessor srcEventProcessor = source as EventProcessor;
              Capacity = srcEventProcessor.Capacity;
              ExeDuration = srcEventProcessor.ExeDuration;
            }
        }
    }
}
