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
    public class Trigger : DP_Shape
    {


        private string resourceDependency = "";

        [DisplayName("Resource Dependency"),
        Category("Simulation"),
        DefaultValue(""),
        Description("Sets the resource on which the type depends.")]
        public string ResourceDependency
        {
            get { return resourceDependency; }
            set { resourceDependency = value; }
        }

        private string resourceRequest = "";

        [DisplayName("Resource Request"),
        Category("Simulation"),
        DefaultValue(""),
        Description("Sets the type of work requested of the resource.")]
        public string ResourceRequest
        {
            get { return resourceRequest; }
            set { resourceRequest = value; }
        }


        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Dot;
            ShapeProperties.BorderColor = Color.FromArgb(255, 128, 0, 128);
            ShapeProperties.BorderWidth = 2;
            ShapeProperties.FillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.MiddleCenter;
            ShapeProperties.Icon = "";

            Name = "NewTrigger";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Method;
            Size = new Size(110, 40);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public Trigger()
        {
        }

        public Trigger(Point startLocation) :
            base(startLocation)
        {
            Diagram = new TriggerStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction run = new DP_AbstractText.Instruction();
            run.Name = "Run";
            run.String = "";
            Text.Instructions.Add(run);

            DP_AbstractText.Instruction duration = new DP_AbstractText.Instruction();
            duration.Name = "Duration";
            duration.String = "return 0;\n";
            Text.Instructions.Add(duration);

        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
            Diagram.Initialize(this);
        }

        public override DP_ConcreteType Duplicate()
        {
            Trigger newType = new Trigger();
            newType.Diagram = new TriggerStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is Trigger)
            {
              base.Copy(source);
              Trigger srcTrigger = source as Trigger;
        ResourceDependency = srcTrigger.ResourceDependency;
        ResourceRequest = srcTrigger.ResourceRequest;
            }
        }
    }
}
