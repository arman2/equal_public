using System;
using System.IO;
using System.Xml.Serialization;
using DomainPro.Core.Types;
using DomainPro.Core.Interfaces;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Interfaces;
using Analyst.Types;

namespace Analyst.Factories
{
    public class HospitalMetamodelModelFactory : DP_IModelFactory
    {
        public DP_AbstractModelType CreateModel()
        {
            return new HospitalMetamodelModel();
        }

        public void SaveModel(DP_AbstractModelType model, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(HospitalMetamodelModel));
            TextWriter textWriter = new StreamWriter(path);
            serializer.Serialize(textWriter, model);
            textWriter.Close();
        }

        public DP_AbstractModelType LoadModel(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(HospitalMetamodelModel));
            TextReader textReader = new StreamReader(path);
            HospitalMetamodelModel model = (HospitalMetamodelModel)deserializer.Deserialize(textReader);
            textReader.Close();
            return model;
        }
    }
}
