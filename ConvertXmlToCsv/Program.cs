using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Program
{
    static void Main()
    {
        string xmlFilePath1 = "C:\\Users\\User\\Desktop\\Files\\123061314";
        string csvFilePath = "C:\\Users\\User\\Desktop\\Files\\output.csv";

        // Deserialize the XML file
        StudyAudit_json clinicalData1 = DeserializeXmlFile<StudyAudit_json>(xmlFilePath1);

        // Create or overwrite the CSV file
        using (StreamWriter sw = new StreamWriter(csvFilePath))
        {
            // Write CSV header
            sw.WriteLine("StudyOID,SubjectKey,SubjectKeyType,SubjectName,LocationOID,StudyEnvSiteNumber,StudyEventOID,FormOID,FormRepeatKey,ItemGroupOID,ItemOID,TransactionType,Value");

            // Process the XML data
            WriteDataToCsv(clinicalData1, sw);
        }

        Console.WriteLine("Data has been written to the CSV file.");
    }

    static T DeserializeXmlFile<T>(string xmlFilePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
        {
            return (T)serializer.Deserialize(fs);
        }
    }

    static void WriteDataToCsv(StudyAudit_json studyAudit, StreamWriter sw)
    {
        foreach (var clinicalData in studyAudit.ClinicalData)
        {
            //foreach (var subjectData in clinicalData.SubjectDat)
            //{
            //    foreach (var studyEventData in subjectData.StudyEventData)
            //    {
            //        foreach (var formData in studyEventData.FormData)
            //        {
            //            foreach (var itemGroupData in formData.ItemGroupData)
            //            {
            //                foreach (var itemData in itemGroupData.ItemData)
            //                {
            // Write data to CSV

            sw.WriteLine($"{(clinicalData.StudyOID ?? "")}," +
                   $"{(clinicalData.SubjectData?.SubjectKey ?? "")}," +
                   $"{(clinicalData.SubjectData?.SubjectKeyType ?? "")}," +
                   $"{(clinicalData.SubjectData?.SubjectName ?? "")}," +
                   $"{(clinicalData.SubjectData?.SiteRef?.LocationOID ?? 0)}," +
                   $"{(clinicalData.SubjectData?.SiteRef?.StudyEnvSiteNumber ?? 0)}," +
                   $"{(clinicalData.SubjectData?.StudyEventData?.StudyEventOID ?? "")}," +
                   $"{(clinicalData.SubjectData?.StudyEventData?.FormData?.FormOID ?? "")}," +
                   $"{(clinicalData.SubjectData?.StudyEventData?.FormData?.FormRepeatKey ?? 0)}," +
                   //$"{(clinicalData.SubjectData?.StudyEventData?.FormData?.DataPageId ?? 0)}," +
                   $"{(clinicalData.SubjectData?.StudyEventData?.FormData?.ItemGroupData?.ItemGroupOID ?? "")}," +
                   //$"{(clinicalData.SubjectData?.StudyEventData?.FormData?.ItemGroupData?.RecordId ?? 0)}," +
                   $"{(clinicalData.SubjectData?.StudyEventData?.FormData?.ItemGroupData?.ItemData?.ItemOID ?? "")}," +
                   $"{(clinicalData.SubjectData?.StudyEventData?.FormData?.ItemGroupData?.ItemData?.TransactionType ?? "")}," +
                   $"{(clinicalData.SubjectData?.StudyEventData?.FormData?.ItemGroupData?.ItemData?.Value ?? "")}");
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
        }
    }
}