
using System.Net;
using System.IO;

namespace EITParcelDelivery.Code
{
    public class webApiCall
    {
        public string getParcel()
        {
            WebClient client = new WebClient();
            Stream data = client.OpenRead("http://wa-eit-dk1.azurewebsites.net/api/parcelinformation?source=test&destination=test&type=1&token=hej");
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return s;
        }
    }
}
