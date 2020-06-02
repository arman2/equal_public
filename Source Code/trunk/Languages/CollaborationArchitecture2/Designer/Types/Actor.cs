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
    public class Actor : Collaborator
    {

        private double UpdateFrequencyValue = 0;

        [DisplayName("UpdateFrequency"),
        Category("ActionFrequencies"),
        DefaultValue(0),
        Description("")]
        public double UpdateFrequency
        {
            get { return UpdateFrequencyValue; }
            set { UpdateFrequencyValue = value; }
        }

        private double ReadFrequencyValue = 1;

        [DisplayName("ReadFrequency"),
        Category("ActionFrequencies"),
        DefaultValue(1),
        Description("")]
        public double ReadFrequency
        {
            get { return ReadFrequencyValue; }
            set { ReadFrequencyValue = value; }
        }

        private double CreateFrequencyValue = 0;

        [DisplayName("CreateFrequency"),
        Category("ActionFrequencies"),
        DefaultValue(0),
        Description("")]
        public double CreateFrequency
        {
            get { return CreateFrequencyValue; }
            set { CreateFrequencyValue = value; }
        }

        private double DeleteFrequencyValue = 0;

        [DisplayName("DeleteFrequency"),
        Category("ActionFrequencies"),
        DefaultValue(0),
        Description("")]
        public double DeleteFrequency
        {
            get { return DeleteFrequencyValue; }
            set { DeleteFrequencyValue = value; }
        }



        protected override void SetParams()
        {
            ShapeProperties.Shape = DP_ShapeType.Rectangle;
            ShapeProperties.DefaultSize = new Size(100, 60);
            ShapeProperties.IsResizable = true;
            ShapeProperties.BorderStyle = DashStyle.Solid;
            ShapeProperties.BorderColor = Color.FromArgb(255, 0, 0, 0);
            ShapeProperties.BorderWidth = 3;
            ShapeProperties.FillColor = Color.FromArgb(255, 255, 255, 235);
            ShapeProperties.GradientFill = true;
            ShapeProperties.GradientFillColor = Color.FromArgb(0, 0, 0, 0);
            ShapeProperties.CornerRounding = 1;
            ShapeProperties.DockStyle = DockStyle.None;
            ShapeProperties.Alignment = ContentAlignment.TopCenter;
            ShapeProperties.Icon = "";

            Name = "NewActor";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(200, 300);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Bold);
        }

        public Actor()
        {
        }

        public Actor(Point startLocation) :
            base(startLocation)
        {
            Diagram = new ActorStructure();
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
            Actor newType = new Actor();
            newType.Diagram = new ActorStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is Actor)
            {
              base.Copy(source);
              Actor srcActor = source as Actor;
              UpdateFrequency = srcActor.UpdateFrequency;
              ReadFrequency = srcActor.ReadFrequency;
              CreateFrequency = srcActor.CreateFrequency;
              DeleteFrequency = srcActor.DeleteFrequency;
            }
        }
    }
}
