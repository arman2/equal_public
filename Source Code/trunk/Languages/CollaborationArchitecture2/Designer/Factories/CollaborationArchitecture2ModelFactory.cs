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
    public class CollaborationArchitecture2ModelFactory : DP_IModelFactory
    {
        public DP_AbstractModelType CreateModel()
        {
            return new CollaborationArchitecture2Model("NewCollaborationArchitecture2");
        }

        public void SaveModel(DP_AbstractModelType model, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CollaborationArchitecture2Model));
            TextWriter textWriter = new StreamWriter(path);
            serializer.Serialize(textWriter, model);
            textWriter.Close();
        }

        public DP_AbstractModelType LoadModel(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(CollaborationArchitecture2Model));
            TextReader textReader = new StreamReader(path);
            CollaborationArchitecture2Model model = (CollaborationArchitecture2Model)deserializer.Deserialize(textReader);
            textReader.Close();
            return model;
        }
    }
}
