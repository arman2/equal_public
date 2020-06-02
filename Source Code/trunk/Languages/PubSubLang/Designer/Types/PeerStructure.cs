using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class PeerStructure : DP_Diagram
    {
        public PeerStructure()
        {
            availableShapes.Add("Publisher");
            availableShapes.Add("Subscriber");


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Publisher")
            {
                Publisher newShape = new Publisher(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Subscriber")
            {
                Subscriber newShape = new Subscriber(startLocation);
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
