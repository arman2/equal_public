using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class FocusedOnStructure : DP_Diagram
    {
        public FocusedOnStructure()
        {
            availableShapes.Add("ConnProperty");


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "ConnProperty")
            {
                ConnProperty newShape = new ConnProperty(startLocation);
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
