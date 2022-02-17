using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace QRScan
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/PostQR",
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare)]
        //List<QR_data> GetJson();
        void SaveFile(UploadFile UploadFile);



        /*   [OperationContract]
          [WebInvoke(Method = "POST", UriTemplate = "add/{coden}/{name}")]
          void Add(string idAlbum, string name, Stream image);*/


        /* [WebGet(UriTemplate = "/GetScheduleJson",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare)]
         List<QR_data> GetScheduleJson();
         */

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
        public byte[] File;
    }
}
