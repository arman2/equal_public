using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class CollaborationArchitectureStructure : DP_Diagram
    {
        public CollaborationArchitectureStructure()
        {
            availableShapes.Add("CollabPattern");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "CollabPattern")
            {
                CollabPattern newShape = new CollabPattern(startLocation);
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
