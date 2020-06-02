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
    public class MySource : DP_Shape
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
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 1;
            ShapeProperties.FillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopLeft;
            ShapeProperties.Icon = "";

            Name = "NewMySource";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Method;
            Size = new Size(100, 100);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public MySource()
        {
        }

        public MySource(Point startLocation) :
            base(startLocation)
        {
            Diagram = new MySourceStructure();
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
            MySource newType = new MySource();
            newType.Diagram = new MySourceStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is MySource)
            {
              base.Copy(source);
              MySource srcMySource = source as MySource;
        ResourceDependency = srcMySource.ResourceDependency;
        ResourceRequest = srcMySource.ResourceRequest;
            }
        }
    }
}
