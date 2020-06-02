using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class UpdateIconStructure : ActionIconStructure
    {
        public UpdateIconStructure()
        {


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            return base.CreateShape(shapeType, startLocation);
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            return base.CreateLine(lineType, src, dest);
        }

    }
}
