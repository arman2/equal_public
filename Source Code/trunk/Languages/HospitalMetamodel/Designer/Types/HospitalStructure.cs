using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class HospitalStructure : DP_Diagram
    {
        public HospitalStructure()
        {
            availableShapes.Add("Room");
            availableShapes.Add("Physician");
            availableShapes.Add("NursePractitioners");
            availableShapes.Add("Nurses");
            availableShapes.Add("ChargeNurses");

            availableLines.Add("Requires");
            availableLines.Add("StepSequence");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Room")
            {
                Room newShape = new Room(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Physician")
            {
                Physician newShape = new Physician(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "NursePractitioners")
            {
                NursePractitioners newShape = new NursePractitioners(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Nurses")
            {
                Nurses newShape = new Nurses(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "ChargeNurses")
            {
                ChargeNurses newShape = new ChargeNurses(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            return null;
        }

        public override DP_Line CreateLine(string lineType, DomainProDesigner.DP_ConnectionSpec src, DomainProDesigner.DP_ConnectionSpec dest)
        {
            if (lineType == "Requires")
            {
                if (Requires.ValidRoles(src.Attached, dest.Attached))
                {
                    Requires newLine = new Requires(src, dest);
                    newLine.Initialize(this);
                    return newLine;
                }
            }

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
