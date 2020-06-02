using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class ContainerStructure : DP_Diagram
    {
        public ContainerStructure()
        {
            availableShapes.Add("Processor");
            availableShapes.Add("InputGenerator");

            availableLines.Add("RunsOn");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Processor")
            {
                Processor newShape = new Processor(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "InputGenerator")
            {
                InputGenerator newShape = new InputGenerator(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "RunsOn")
            {
                if (RunsOn.ValidRoles(src.Attached, dest.Attached))
                {
                    RunsOn newLine = new RunsOn(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
