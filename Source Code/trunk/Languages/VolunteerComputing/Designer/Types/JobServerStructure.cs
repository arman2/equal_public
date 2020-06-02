using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class JobServerStructure : DP_Diagram
    {
        public JobServerStructure()
        {
            availableShapes.Add("JobDefinition");
            availableShapes.Add("DecisionCriteria");
            availableShapes.Add("DecisionVariable");
            availableShapes.Add("ServerFunction");
            availableShapes.Add("JobQueue");

            availableLines.Add("NextFunction");
            availableLines.Add("JobFlow");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "JobDefinition")
            {
                JobDefinition newShape = new JobDefinition(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "DecisionCriteria")
            {
                DecisionCriteria newShape = new DecisionCriteria(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "DecisionVariable")
            {
                DecisionVariable newShape = new DecisionVariable(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ServerFunction")
            {
                ServerFunction newShape = new ServerFunction(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "JobQueue")
            {
                JobQueue newShape = new JobQueue(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "NextFunction")
            {
                if (NextFunction.ValidRoles(src.Attached, dest.Attached))
                {
                    NextFunction newLine = new NextFunction(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "JobFlow")
            {
                if (JobFlow.ValidRoles(src.Attached, dest.Attached))
                {
                    JobFlow newLine = new JobFlow(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
