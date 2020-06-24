using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Text;

namespace KatelleOnline.Helper
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

        public static T GetObjectFromJson2<T>(this ISession session, string key)
        {
            byte[] value = null;
            var bytesAsString = String.Empty;
            try
            {
                bytesAsString = session.GetString("basket");
                session.TryGetValue(key, out value);

               bytesAsString = Encoding.UTF8.GetString(value);
                return JsonConvert.DeserializeObject<T>(bytesAsString);
                
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return default;
        }
    }
}
