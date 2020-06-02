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
            availableShapes.Add("Create");
            availableShapes.Add("Read");
            availableShapes.Add("Update");
            availableShapes.Add("Delete");
            availableShapes.Add("Work");
            availableShapes.Add("Decison");
            availableShapes.Add("CollabMetric");
            availableShapes.Add("ActorPool");

            availableLines.Add("CollabSequence");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Create")
            {
                Create newShape = new Create(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Read")
            {
                Read newShape = new Read(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Update")
            {
                Update newShape = new Update(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Delete")
            {
                Delete newShape = new Delete(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Work")
            {
                Work newShape = new Work(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Decison")
            {
                Decison newShape = new Decison(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "CollabMetric")
            {
                CollabMetric newShape = new CollabMetric(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ActorPool")
            {
                ActorPool newShape = new ActorPool(startLocation);
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
