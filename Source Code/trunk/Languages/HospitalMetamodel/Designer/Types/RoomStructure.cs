using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class RoomStructure : DP_Diagram
    {
        public RoomStructure()
        {
            availableShapes.Add("ProcedureStep");

            availableLines.Add("StepSequence");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "ProcedureStep")
            {
                ProcedureStep newShape = new ProcedureStep(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "StepSequence")
            {
                if (StepSequence.ValidRoles(src.Attached, dest.Attached))
                {
                    StepSequence newLine = new StepSequence(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
