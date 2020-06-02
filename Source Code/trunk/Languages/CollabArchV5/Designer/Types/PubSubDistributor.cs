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
    public class PubSubDistributor : Connector
    {

        private double FwdDelayValue = 1;

        [DisplayName("FwdDelay"),
        Category("Config"),
        DefaultValue(1),
        Description("")]
        public double FwdDelay
        {
            get { return FwdDelayValue; }
            set { FwdDelayValue = value; }
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

            Name = "NewPubSubDistributor";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Component;
            Size = new Size(100, 100);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public PubSubDistributor()
        {
        }

        public PubSubDistributor(Point startLocation) :
            base(startLocation)
        {
            Diagram = new PubSubDistributorStructure();
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
            PubSubDistributor newType = new PubSubDistributor();
            newType.Diagram = new PubSubDistributorStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is PubSubDistributor)
            {
              base.Copy(source);
              PubSubDistributor srcPubSubDistributor = source as PubSubDistributor;
              FwdDelay = srcPubSubDistributor.FwdDelay;
            }
        }
    }
}
