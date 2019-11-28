using AutoFixture;
using MessagePack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Hotels.ApiClient
{
    public class CustomClient
    {
        public void Test()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:63489");

                var rqHC = new Fixture().Create<RqHotelComission>();

                var content = new ByteArrayContent(MessagePackSerializer.Serialize(rqHC));
                content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/x-msgpack");

                var result = httpClient.PostAsync("api/Hotels/HotelRetention", content).Result;
                
                var bytes = result.Content.ReadAsByteArrayAsync().Result;
                var data = MessagePackSerializer.Deserialize<RqHotelComission>(bytes);
            }
        }
    }
}
