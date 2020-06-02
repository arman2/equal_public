using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class VolunteerComputingSystemStructure : DP_Diagram
    {
        public VolunteerComputingSystemStructure()
        {
            availableShapes.Add("ProblemSpec");
            availableShapes.Add("JobServer");
            availableShapes.Add("VolunteerPool");

            availableLines.Add("ProblemSubmission");
            availableLines.Add("Network");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "ProblemSpec")
            {
                ProblemSpec newShape = new ProblemSpec(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "JobServer")
            {
                JobServer newShape = new JobServer(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "VolunteerPool")
            {
                VolunteerPool newShape = new VolunteerPool(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "ProblemSubmission")
            {
                if (ProblemSubmission.ValidRoles(src.Attached, dest.Attached))
                {
                    ProblemSubmission newLine = new ProblemSubmission(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "Network")
            {
                if (Network.ValidRoles(src.Attached, dest.Attached))
                {
                    Network newLine = new Network(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
