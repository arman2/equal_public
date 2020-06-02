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
    public class TriggerRefConn : DP_Line
    {



        public static new bool ValidRoles(DP_ConcreteType newSource, DP_ConcreteType newDest)
        {
            if (newSource == null || CanBeRole1(newSource))
            {
                if (newDest == null || CanBeRole2(newDest))
                    return true;
            }
            if (newDest == null || CanBeRole1(newDest))
            {
                if (newSource == null || CanBeRole2(newSource))
                    return true;
            }
            return false;
        }

        private static bool CanBeRole1(DP_ConcreteType endpoint)
        {
            if (endpoint is CollabAction)
            {
                return true;
            }
            if (endpoint is Role)
            {
                return true;
            }
            return false;
        }

        private static bool CanBeRole2(DP_ConcreteType endpoint)
        {
            if (endpoint is TriggerDataSet)
            {
                return true;
            }
            if (endpoint is CollabObject)
            {
                return true;
            }
            return false;
        }

        protected override void SetParams()
        {
            LineProperties.Form = DP_LineForm.Line;
            LineProperties.LineWidth = 2;
            LineProperties.BorderStyle = DashStyle.Solid;
            LineProperties.BorderColor = Color.FromArgb(255, 0, 0, 255);
            LineProperties.BorderWidth = 0;
            LineProperties.FillStyle = DashStyle.Dot;
            LineProperties.FillColor = Color.FromArgb(255, 0, 0, 255);
            LineProperties.Role1.NameVisible = true;
            LineProperties.Role1.Font = new Font("Segoe UI", (float)9, FontStyle.Regular);
            LineProperties.Role1.Icon = "";
            LineProperties.Role2.NameVisible = true;
            LineProperties.Role2.Font = new Font("Segoe UI", (float)9, FontStyle.Regular);
            LineProperties.Role2.Icon = "..\\..\\Icons\\triangle.gif";

            Name = "NewTriggerRefConn";
            DisplayName = Name;
            ShowName = false;
            NameFont = new Font("Segoe UI", (float)9, FontStyle.Regular);
            PresentationType = DP_PresentationType.Line;
            SimulationType = DP_SimulationType.Link;
            role1Name = "Dst";
            role2Name = "Src";
        }

        public TriggerRefConn()
        {
        }

        public TriggerRefConn(DomainProDesigner.DP_ConnectionSpec newRole1, DomainProDesigner.DP_ConnectionSpec newRole2) :
            base(newRole1, newRole2)
        {
            Diagram = new TriggerRefConnStructure();
            Text = new DP_Text();
        }

        public override void Initialize(DP_AbstractStructure parentDiagram)
        {
            base.Initialize(parentDiagram);
            Diagram.Initialize(this);
        }

        public override DP_ConcreteType Duplicate()
        {
            TriggerRefConn newType = new TriggerRefConn();
            newType.Diagram = new TriggerRefConnStructure();
            newType.Text = new DP_Text();
            newType.Copy(this);
            return newType;
        }

        protected override void Copy(DP_ConcreteType source)
        {
            if (source is TriggerRefConn)
            {
              base.Copy(source);
              TriggerRefConn srcTriggerRefConn = source as TriggerRefConn;
            }
        }
    }
}
