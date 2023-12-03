using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Laba1.Extensions
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T item)
        {
            var serializedItem = JsonConvert.SerializeObject(item);
            session.SetString(key, serializedItem);
        }
        public static T Get<T>(this ISession session, string key)
        {
            var item = session.GetString(key);
            return item == null ? Activator.CreateInstance<T>() : JsonConvert.DeserializeObject<T>(item);
        }
    }
}
