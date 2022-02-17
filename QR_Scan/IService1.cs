using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace QR_Scan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GetJSonString", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare)]
        string GetJSonString(UploadFile jsonData);


    }

   
    [DataContract]
    public class UploadFile
    {
       [DataMember]
        public int codev { get; set; }

       [DataMember]
       public DateTime time { get; set; }
        [DataMember]
        public string filename { get; set; }
        [DataMember]
       public int coden { get; set; }
        [DataMember]
        public int typedov { get; set; }

       [DataMember]
       public string File;
    }
}
