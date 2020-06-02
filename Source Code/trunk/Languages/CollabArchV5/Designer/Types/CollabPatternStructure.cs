using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class CollabPatternStructure : DP_Diagram
    {
        public CollabPatternStructure()
        {
            availableShapes.Add("Collaborator");
            availableShapes.Add("CollabObject");
            availableShapes.Add("Crowd");
            availableShapes.Add("Icon");
            availableShapes.Add("MessageIcon");
            availableShapes.Add("StreamIcon");
            availableShapes.Add("ArtifactIcon");
            availableShapes.Add("Variable");

            availableLines.Add("TriggerFlow");
            availableLines.Add("ObjectRefConnection");
            availableLines.Add("FocusOnObjConn");
            availableLines.Add("TriggerRefConn");
            availableLines.Add("CollabSequence");
            availableLines.Add("KnowsConn");
            availableLines.Add("CrowdDep");
            availableLines.Add("IntraTriggerFlow");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Collaborator")
            {
                Collaborator newShape = new Collaborator(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "CollabObject")
            {
                CollabObject newShape = new CollabObject(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Crowd")
            {
                Crowd newShape = new Crowd(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Icon")
            {
                Icon newShape = new Icon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "MessageIcon")
            {
                MessageIcon newShape = new MessageIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "StreamIcon")
            {
                StreamIcon newShape = new StreamIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ArtifactIcon")
            {
                ArtifactIcon newShape = new ArtifactIcon(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Variable")
            {
                Variable newShape = new Variable(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "TriggerFlow")
            {
                if (TriggerFlow.ValidRoles(src.Attached, dest.Attached))
                {
                    TriggerFlow newLine = new TriggerFlow(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "ObjectRefConnection")
            {
                if (ObjectRefConnection.ValidRoles(src.Attached, dest.Attached))
                {
                    ObjectRefConnection newLine = new ObjectRefConnection(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "FocusOnObjConn")
            {
                if (FocusOnObjConn.ValidRoles(src.Attached, dest.Attached))
                {
                    FocusOnObjConn newLine = new FocusOnObjConn(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "TriggerRefConn")
            {
                if (TriggerRefConn.ValidRoles(src.Attached, dest.Attached))
                {
                    TriggerRefConn newLine = new TriggerRefConn(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "CollabSequence")
            {
                if (CollabSequence.ValidRoles(src.Attached, dest.Attached))
                {
                    CollabSequence newLine = new CollabSequence(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "KnowsConn")
            {
                if (KnowsConn.ValidRoles(src.Attached, dest.Attached))
                {
                    KnowsConn newLine = new KnowsConn(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "CrowdDep")
            {
                if (CrowdDep.ValidRoles(src.Attached, dest.Attached))
                {
                    CrowdDep newLine = new CrowdDep(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            if (lineType == "IntraTriggerFlow")
            {
                if (IntraTriggerFlow.ValidRoles(src.Attached, dest.Attached))
                {
                    IntraTriggerFlow newLine = new IntraTriggerFlow(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

            return null;
        }

    }
}
