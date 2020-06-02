using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class PubSubEnvStructure : DP_Diagram
    {
        public PubSubEnvStructure()
        {
            availableShapes.Add("Group");
            availableShapes.Add("Subscriber");
            availableShapes.Add("Publisher");


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Group")
            {
                Group newShape = new Group(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Subscriber")
            {
                Subscriber newShape = new Subscriber(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Publisher")
            {
                Publisher newShape = new Publisher(startLocation);
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
