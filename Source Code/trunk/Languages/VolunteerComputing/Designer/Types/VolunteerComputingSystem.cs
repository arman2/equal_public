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
    public class VolunteerComputingSystem : DP_Shape
    {



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Dash;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 2;
            ShapeProperties.FillColor = Color.FromArgb(255, 255, 255, 255);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(255, 224, 224, 224);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopLeft;
            ShapeProperties.Icon = "";

            Name = "NewVolunteerComputingSystem";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(400, 200);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public VolunteerComputingSystem()
        {
        }

        public VolunteerComputingSystem(Point startLocation) :
            base(startLocation)
        {
            Diagram = new VolunteerComputingSystemStructure();
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
            VolunteerComputingSystem newType = new VolunteerComputingSystem();
            newType.Diagram = new VolunteerComputingSystemStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is VolunteerComputingSystem)
            {
              base.Copy(source);
              VolunteerComputingSystem srcVolunteerComputingSystem = source as VolunteerComputingSystem;
            }
        }
    }
}
