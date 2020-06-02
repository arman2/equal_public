using System;
using System.IO;
using System.Xml.Serialization;
using DomainPro.Core.Types;
using DomainPro.Core.Interfaces;
using DomainPro.Designer.Types;
using DomainPro.Designer.Interfaces;
using Designer.Types;

namespace Designer.Factories
{
    public class CollaborationArchitectureModelFactory : DP_IModelFactory
    {
        public DP_AbstractModelType CreateModel()
        {
            return new CollaborationArchitectureModel("NewCollaborationArchitecture");
        }

        public void SaveModel(DP_AbstractModelType model, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CollaborationArchitectureModel));
            TextWriter textWriter = new StreamWriter(path);
            serializer.Serialize(textWriter, model);
            textWriter.Close();
        }

        public DP_AbstractModelType LoadModel(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(CollaborationArchitectureModel));
            TextReader textReader = new StreamReader(path);
            CollaborationArchitectureModel model = (CollaborationArchitectureModel)deserializer.Deserialize(textReader);
            textReader.Close();
            return model;
        }
    }
}
