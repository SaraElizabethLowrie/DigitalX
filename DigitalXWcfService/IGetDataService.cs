using DigitalXEntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DigitalXWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetDataService" in both code and config file together.
    [ServiceContract]
    public interface IGetDataService
    {
        [OperationContract]
        void DoWork();

        // Product
        [OperationContract]
        IList<Product> ProductGetAll();

        [OperationContract]
        Product ProductGetDetails(int? id);

        [OperationContract]
        IList<Product> ProductGetTop(int count);

        // Customer
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        bool CreateCustomer(string UserName);

        [OperationContract]
        Customer GetCustomerId(int? id);

        [OperationContract]
        Customer CustomerLogin();

        [OperationContract]
        IList<Customer> GetCustomer();
    }
}
