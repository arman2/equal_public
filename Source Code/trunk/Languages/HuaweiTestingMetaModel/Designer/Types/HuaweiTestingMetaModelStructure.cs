using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class HuaweiTestingMetaModelStructure : DP_Diagram
    {
        public HuaweiTestingMetaModelStructure()
        {
            availableShapes.Add("HuaweiTestingSystem");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "HuaweiTestingSystem")
            {
                HuaweiTestingSystem newShape = new HuaweiTestingSystem(startLocation);
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
