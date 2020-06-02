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
    public class ProblemSpec : DP_Shape
    {

        private int ComputationSizeValue = 1;

        [DisplayName("ComputationSize"),
        Category("Parameters"),
        DefaultValue(1),
        Description("")]
        public int ComputationSize
        {
            get { return ComputationSizeValue; }
            set { ComputationSizeValue = value; }
        }

        private int RequiredConfidenceValue = 3;

        [DisplayName("RequiredConfidence"),
        Category("Parameters"),
        DefaultValue(3),
        Description("")]
        public int RequiredConfidence
        {
            get { return RequiredConfidenceValue; }
            set { RequiredConfidenceValue = value; }
        }



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Ellipse;
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
            ShapeProperties.Alignment = ContentAlignment.MiddleCenter;
            ShapeProperties.Icon = "";

            Name = "NewProblemSpec";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(100, 100);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public ProblemSpec()
        {
        }

        public ProblemSpec(Point startLocation) :
            base(startLocation)
        {
            Diagram = new ProblemSpecStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction startup = new DP_AbstractText.Instruction();
            startup.Name = "Startup";
            startup.String = "";
            Text.Instructions.Add(startup);

        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
            Diagram.Initialize(this);
        }

        public override DP_ConcreteType Duplicate()
        {
            ProblemSpec newType = new ProblemSpec();
            newType.Diagram = new ProblemSpecStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is ProblemSpec)
            {
              base.Copy(source);
              ProblemSpec srcProblemSpec = source as ProblemSpec;
              ComputationSize = srcProblemSpec.ComputationSize;
              RequiredConfidence = srcProblemSpec.RequiredConfidence;
            }
        }
    }
}
