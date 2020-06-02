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
    public class ResourceStock : DP_Shape
    {


        private List<DP_Worker> workers = new List<DP_Worker>();

        [DisplayName("Workers"),
        Category("Simulation"),
        Description("A list of workers provided by the resource.")]
        public List<DP_Worker> Workers
        {
            get { return workers; }
            set { workers = value; }
        }

        private List<DP_Queue> queues = new List<DP_Queue>();

        [DisplayName("Queues"),
        Category("Simulation"),
        Description("A list of job categories handled by the resource.")]
        public List<DP_Queue> Queues
        {
            get { return queues; }
            set { queues = value; }
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

            Name = "NewResourceStock";
            DisplayName = Name;
            ShowName = true;
            Hidden = false;
            PresentationType = DP_PresentationType.Shape;
            SimulationType = DP_SimulationType.Resource;
            Size = new Size(100, 100);
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
        }

        public ResourceStock()
        {
        }

        public ResourceStock(Point startLocation) :
            base(startLocation)
        {
            Diagram = new ResourceStockStructure();
            Text = new DP_Text();
        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
            Diagram.Initialize(this);
        }

        public override DP_ConcreteType Duplicate()
        {
            ResourceStock newType = new ResourceStock();
            newType.Diagram = new ResourceStockStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is ResourceStock)
            {
              base.Copy(source);
              ResourceStock srcResourceStock = source as ResourceStock;
        Workers = srcResourceStock.Workers;
        Queues = srcResourceStock.Queues;
            }
        }
    }
}
