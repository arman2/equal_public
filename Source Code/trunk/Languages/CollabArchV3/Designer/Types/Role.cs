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
    public class Role : DP_Shape
    {

        private double CreatePValue = 0.0;

        [DisplayName("CreateP"),
        Category("ActionProbabilities"),
        DefaultValue(0.0),
        Description("")]
        public double CreateP
        {
            get { return CreatePValue; }
            set { CreatePValue = value; }
        }

        private double ReadPValue = 0.0;

        [DisplayName("ReadP"),
        Category("ActionProbabilities"),
        DefaultValue(0.0),
        Description("")]
        public double ReadP
        {
            get { return ReadPValue; }
            set { ReadPValue = value; }
        }

        private double UpdatePValue = 0.0;

        [DisplayName("UpdateP"),
        Category("ActionProbabilities"),
        DefaultValue(0.0),
        Description("")]
        public double UpdateP
        {
            get { return UpdatePValue; }
            set { UpdatePValue = value; }
        }

        private double DeletePValue = 0.0;

        [DisplayName("DeleteP"),
        Category("ActionProbabilities"),
        DefaultValue(0.0),
        Description("")]
        public double DeleteP
        {
            get { return DeletePValue; }
            set { DeletePValue = value; }
        }

        private double IdlePValue = 0.0;

        [DisplayName("IdleP"),
        Category("ActionProbabilities"),
        DefaultValue(0.0),
        Description("")]
        public double IdleP
        {
            get { return IdlePValue; }
            set { IdlePValue = value; }
        }



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 2;
            ShapeProperties.FillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopCenter;
            ShapeProperties.Icon = "";

            Name = "NewRole";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(160, 80);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public Role()
        {
        }

        public Role(Point startLocation) :
            base(startLocation)
        {
            Diagram = new RoleStructure();
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
            Role newType = new Role();
            newType.Diagram = new RoleStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is Role)
            {
              base.Copy(source);
              Role srcRole = source as Role;
              CreateP = srcRole.CreateP;
              ReadP = srcRole.ReadP;
              UpdateP = srcRole.UpdateP;
              DeleteP = srcRole.DeleteP;
              IdleP = srcRole.IdleP;
            }
        }
    }
}
