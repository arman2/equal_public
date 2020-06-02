using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Analyst.Types;

namespace Analyst.Types
{
    [XmlInclude(typeof(HealthcareWorkers))]
    [XmlInclude(typeof(HealthcareWorkersStructure))]
    [XmlInclude(typeof(Patient))]
    [XmlInclude(typeof(PatientStructure))]
    [XmlInclude(typeof(Hospital))]
    [XmlInclude(typeof(HospitalStructure))]
    [XmlInclude(typeof(ProcedureStep))]
    [XmlInclude(typeof(ProcedureStepStructure))]
    [XmlInclude(typeof(Physician))]
    [XmlInclude(typeof(PhysicianStructure))]
    [XmlInclude(typeof(AllNurses))]
    [XmlInclude(typeof(AllNursesStructure))]
    [XmlInclude(typeof(NursePractitioners))]
    [XmlInclude(typeof(NursePractitionersStructure))]
    [XmlInclude(typeof(Nurses))]
    [XmlInclude(typeof(NursesStructure))]
    [XmlInclude(typeof(ChargeNurses))]
    [XmlInclude(typeof(ChargeNursesStructure))]
    [XmlInclude(typeof(Requires))]
    [XmlInclude(typeof(RequiresStructure))]
    [XmlInclude(typeof(Room))]
    [XmlInclude(typeof(RoomStructure))]
    [XmlInclude(typeof(StepSequence))]
    [XmlInclude(typeof(StepSequenceStructure))]
    [XmlInclude(typeof(MyQueueingModel))]
    [XmlInclude(typeof(MyQueueingModelStructure))]
    [XmlInclude(typeof(MyStep))]
    [XmlInclude(typeof(MyStepStructure))]
    [XmlInclude(typeof(MyFlow))]
    [XmlInclude(typeof(MyFlowStructure))]
    [XmlInclude(typeof(MySource))]
    [XmlInclude(typeof(MySourceStructure))]
    [XmlInclude(typeof(MyDestination))]
    [XmlInclude(typeof(MyDestinationStructure))]
    [XmlInclude(typeof(Variable))]
    [XmlInclude(typeof(VariableStructure))]
    [XmlInclude(typeof(HospitalMetamodelStructure))]

    public class HospitalMetamodelModel : DP_ModelType
    {

    }
}
