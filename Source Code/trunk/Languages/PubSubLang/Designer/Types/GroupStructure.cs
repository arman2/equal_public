using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class GroupStructure : DP_Diagram
    {
        public GroupStructure()
        {
            availableShapes.Add("Forward");
            availableShapes.Add("Receive");


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Forward")
            {
                Forward newShape = new Forward(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Receive")
            {
                Receive newShape = new Receive(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            return null;
        }

    }
}
