using System.ServiceModel;

namespace PDFService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPdfService" in both code and config file together.
    [ServiceContract]
    public interface IPdfService
    {
        [OperationContract]
        void Import();
    }
}
