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
    public class Subscriber : Component
    {

        private int NrEventSourcesValue = 1;

        [DisplayName("NrEventSources"),
        Category("Config"),
        DefaultValue(1),
        Description("")]
        public int NrEventSources
        {
            get { return NrEventSourcesValue; }
            set { NrEventSourcesValue = value; }
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

            Name = "NewSubscriber";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(200, 300);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public Subscriber()
        {
        }

        public Subscriber(Point startLocation) :
            base(startLocation)
        {
            Diagram = new SubscriberStructure();
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
            Subscriber newType = new Subscriber();
            newType.Diagram = new SubscriberStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is Subscriber)
            {
              base.Copy(source);
              Subscriber srcSubscriber = source as Subscriber;
              NrEventSources = srcSubscriber.NrEventSources;
            }
        }
    }
}
