using System.IO;
using System.Runtime.Serialization;

namespace PDFService.DataContainer
{
    [DataContract]
    public class DCPdfFile
    {
        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public FileStream File { get; set; }  
    }
}