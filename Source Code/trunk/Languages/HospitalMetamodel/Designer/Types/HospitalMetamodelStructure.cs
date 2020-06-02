using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Designer;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    public class HospitalMetamodelStructure : DP_Diagram
    {
        public HospitalMetamodelStructure()
        {
            availableShapes.Add("Patient");
            availableShapes.Add("Hospital");
            availableShapes.Add("Physician");
            availableShapes.Add("NursePractitioners");
            availableShapes.Add("Nurses");
            availableShapes.Add("ChargeNurses");
            availableShapes.Add("MyQueueingModel");
            availableLines.Add("Requires");

        }

        public override DP_Shape CreateShape(string shapeType, Point startLocation)
        {
            if (shapeType == "Patient")
            {
                Patient newShape = new Patient(startLocation);
                newShape.Initialize(this);
                return newShape;
            }

            if (shapeType == "Hospital")
            {
                Hospital newShape = new Hospital(startLocation);
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

            if (shapeType == "MyQueueingModel")
            {
                MyQueueingModel newShape = new MyQueueingModel(startLocation);
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


            return null;
        }

    }
}
