using System;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using ConvertXmlToCsv;

public class Program
{
    static void Main()
    {
        string xmlFilePath1 = "C:\\Users\\User\\Desktop\\Files\\124119221";

        // Deserialize the XML file
        StudyAudit_json clinicalData1 = DeserializeXmlFile<StudyAudit_json>(xmlFilePath1);

        // Insert data into SQL Server using Entity Framework
        InsertDataIntoSqlServer(clinicalData1);

        Console.WriteLine("Data has been inserted into SQL Server.");
    }

    static T DeserializeXmlFile<T>(string xmlFilePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
        {
            return (T)serializer.Deserialize(fs);
        }
    }

    static void InsertDataIntoSqlServer(StudyAudit_json studyAudit)
    {
        using (var context = new ApplicationDbContext())
        {
            foreach (var clinicalData in studyAudit.ClinicalData)
            {
                var data = new StudyAuditData
                {
                    StudyOID = clinicalData.StudyOID,
                    SubjectKey = clinicalData.SubjectData?.SubjectKey,
                    SubjectKeyType = clinicalData.SubjectData?.SubjectKeyType,
                    SubjectName = clinicalData.SubjectData?.SubjectName,
                    LocationOID = (int?)(clinicalData.SubjectData?.SiteRef?.LocationOID),
                    StudyEnvSiteNumber = (int?)(clinicalData.SubjectData?.SiteRef?.StudyEnvSiteNumber),
                    StudyEventOID = clinicalData.SubjectData?.StudyEventData?.StudyEventOID,
                    FormOID = clinicalData.SubjectData?.StudyEventData?.FormData?.FormOID,
                    FormRepeatKey = clinicalData.SubjectData?.StudyEventData?.FormData?.FormRepeatKey,
                    ItemGroupOID = clinicalData.SubjectData?.StudyEventData?.FormData?.ItemGroupData?.ItemGroupOID,
                    ItemOID = clinicalData.SubjectData?.StudyEventData?.FormData?.ItemGroupData?.ItemData?.ItemOID,
                    TransactionType = clinicalData.SubjectData?.StudyEventData?.FormData?.ItemGroupData?.ItemData?.TransactionType,
                    Value = clinicalData.SubjectData?.StudyEventData?.FormData?.ItemGroupData?.ItemData?.Value
                };

                context.StudyAuditData.Add(data);
            }

            context.SaveChanges();
        }
    }
}
