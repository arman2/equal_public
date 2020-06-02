using System;
using System.Drawing;
using System.Xml.Serialization;
using System.Windows.Forms;
using DomainPro.Core.Types;
using DomainPro.Designer.Types;

namespace Designer.Types
{
    [XmlInclude(typeof(JobServer))]
    [XmlInclude(typeof(JobServerStructure))]
    [XmlInclude(typeof(ProblemSubmission))]
    [XmlInclude(typeof(ProblemSubmissionStructure))]
    [XmlInclude(typeof(ProblemSpec))]
    [XmlInclude(typeof(ProblemSpecStructure))]
    [XmlInclude(typeof(Network))]
    [XmlInclude(typeof(NetworkStructure))]
    [XmlInclude(typeof(VolunteerPool))]
    [XmlInclude(typeof(VolunteerPoolStructure))]
    [XmlInclude(typeof(JobDefinition))]
    [XmlInclude(typeof(JobDefinitionStructure))]
    [XmlInclude(typeof(DecisionCriteria))]
    [XmlInclude(typeof(DecisionCriteriaStructure))]
    [XmlInclude(typeof(DecisionVariable))]
    [XmlInclude(typeof(DecisionVariableStructure))]
    [XmlInclude(typeof(JobData))]
    [XmlInclude(typeof(JobDataStructure))]
    [XmlInclude(typeof(LocalVariable))]
    [XmlInclude(typeof(LocalVariableStructure))]
    [XmlInclude(typeof(ServerFunction))]
    [XmlInclude(typeof(ServerFunctionStructure))]
    [XmlInclude(typeof(NextFunction))]
    [XmlInclude(typeof(NextFunctionStructure))]
    [XmlInclude(typeof(ResultData))]
    [XmlInclude(typeof(ResultDataStructure))]
    [XmlInclude(typeof(JobQueue))]
    [XmlInclude(typeof(JobQueueStructure))]
    [XmlInclude(typeof(VolunteerComputingSystem))]
    [XmlInclude(typeof(VolunteerComputingSystemStructure))]
    [XmlInclude(typeof(JobFlow))]
    [XmlInclude(typeof(JobFlowStructure))]
    [XmlInclude(typeof(VolunteerComputingStructure))]

    public class VolunteerComputingModel : DP_ModelType
    {
        public VolunteerComputingModel()
        {
        }

        public VolunteerComputingModel(string newName)
        {
            name = newName;
            Diagram = new VolunteerComputingStructure();
            Text = new DP_Text();
            DP_AbstractText.Instruction init = new DP_AbstractText.Instruction();
            init.Name = "Initialize";
            init.String = "";
            Text.Instructions.Add(init);

        }

    }
}
