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
    public class Collaborator : DP_Shape
    {

        private double WorkExeDurationValue = 5;

        [DisplayName("WorkExeDuration"),
        Category("Config"),
        DefaultValue(5),
        Description("")]
        public double WorkExeDuration
        {
            get { return WorkExeDurationValue; }
            set { WorkExeDurationValue = value; }
        }

        private double EWMAalphaValue = 0.5;

        [DisplayName("EWMAalpha"),
        Category("Config"),
        DefaultValue(0.5),
        Description("")]
        public double EWMAalpha
        {
            get { return EWMAalphaValue; }
            set { EWMAalphaValue = value; }
        }



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 3;
            ShapeProperties.FillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopLeft;
            ShapeProperties.Icon = "";

            Name = "NewCollaborator";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(250, 350);
            NameFont = new Font("Segoe UI", (float)10, FontStyle.Bold);
        }

        public Collaborator()
        {
        }

        public Collaborator(Point startLocation) :
            base(startLocation)
        {
            Diagram = new CollaboratorStructure();
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
            Collaborator newType = new Collaborator();
            newType.Diagram = new CollaboratorStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is Collaborator)
            {
              base.Copy(source);
              Collaborator srcCollaborator = source as Collaborator;
              WorkExeDuration = srcCollaborator.WorkExeDuration;
              EWMAalpha = srcCollaborator.EWMAalpha;
            }
        }
    }
}
