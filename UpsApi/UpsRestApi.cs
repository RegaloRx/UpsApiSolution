using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using UpsRequestLib;
using UpsQVResponseLib;

namespace UpsRestApi
{
    public class UpsApi
    {
        public static QvRoot GetQuantumView(string username, string password, string key, string url)
        {
            try
            {
                Uri uri = new Uri(url);

                // Create the request
                QVRequest qvRequest = new QVRequest()
                {
                    AccessRequest = new AccessRequestClass()
                    {
                        AccessLicenseNumber = key,
                        UserId = username,
                        Password = password
                    },
                    QuantumViewRequest = new QuantumViewRequestClass()
                    {
                        Request = new RequestClass()
                        {
                            RequestAction = "QVEvents"
                        },
                        SubscriptionRequest = new SubscriptionRequestClass()
                        {
                            Name = "RegaloRXOutbound",
                            //FileName = "201210_170001001"
                            DateTimeRange = new SubscriptionRequestDateTimeRangeClass()
                            {
                                BeginDateTime = "20201214000000",
                                EndDateTime = "20201215000000"
                            }
                        }
                    }
                };

                string jsonQvRequest = JsonConvert.SerializeObject(qvRequest,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                // Prepare the WebRequest
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                byte[] contentQvRequest = System.Text.Encoding.UTF8.GetBytes(jsonQvRequest);
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(contentQvRequest, 0, contentQvRequest.Length);
                dataStream.Close();

                // Send the request, get the response
                HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(webResponse.GetResponseStream());
                string responseText = sr.ReadToEnd();

                // Load response object model
                QvRoot qvRoot = JsonConvert.DeserializeObject<QvRoot>(responseText);

                return qvRoot;
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    System.Exception exx = new System.Exception(errorText, ex);
                    throw exx;
                }
            } 
        }
    }
}