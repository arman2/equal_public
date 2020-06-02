using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class MessageStructure : CollabObjectStructure
    {
        public MessageStructure()
        {
            availableShapes.Add("TrigCreated");


        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "TrigCreated")
            {
                TrigCreated newShape = new TrigCreated(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return base.CreateShape(shapeType, startLocation);
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            return base.CreateLine(lineType, src, dest);
        }

    }
}
