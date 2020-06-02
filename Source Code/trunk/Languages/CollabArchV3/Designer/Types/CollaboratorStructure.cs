using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class CollaboratorStructure : DP_Diagram
    {
        public CollaboratorStructure()
        {
            availableShapes.Add("Role");
            availableShapes.Add("Metric");

            availableLines.Add("CollabSequence");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Role")
            {
                Role newShape = new Role(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Metric")
            {
                Metric newShape = new Metric(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "CollabSequence")
            {
                if (CollabSequence.ValidRoles(src.Attached, dest.Attached))
                {
                    CollabSequence newLine = new CollabSequence(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
