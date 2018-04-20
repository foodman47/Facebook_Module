#region Imports

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

#endregion

namespace Facebook.Helpers {
    public static class JsonHelper {
        #region Public Methods

        /// <summary>
        /// Deserializes the specified json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        public static T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
            ms.Close();
            return obj;
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static TItem GetItem<TItem>(string url)
                where TItem : class, new() {
            return Deserialize<TItem>(GetJson(url));
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static TItem[] GetItems<TItem>(string url)
                where TItem : class {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            try {
                HttpWebResponse response;
                Debug.Assert(request != null, "request != null");
                using(response = request.GetResponse() as HttpWebResponse) {
                    Debug.Assert(response != null, "response != null");

                    using(Stream stream = response.GetResponseStream()) {
                        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TItem[]));

                        // ReSharper disable once AssignNullToNotNullAttribute
                        return (TItem[]) ser.ReadObject(stream);
                    }
                }
            } catch {
                return null;
            }
        }

        /// <summary>
        /// Gets the json.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static string GetJson(string url) {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            try {
                HttpWebResponse response;
                Debug.Assert(request != null, "request != null");
                using(response = request.GetResponse() as HttpWebResponse) {
                    Debug.Assert(response != null, "response != null");

                    // ReSharper disable once AssignNullToNotNullAttribute
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string value = reader.ReadToEnd();
                    return value;
                }
            } catch {
                return null;
            }
        }

        /// <summary>
        /// Gets the json stream.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static Stream GetJsonStream(string url) {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            try {
                Debug.Assert(request != null, "request != null");
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Debug.Assert(response != null, "response != null");
                return response.GetResponseStream();
            } catch {
                return null;
            }
        }

        #endregion

        ///// <typeparam name="TItem">The type of the item.</typeparam>
        ///// </summary>
        ///// Gets the item.

        ///// <summary>

        ///// <param name="url">The URL.</param>
        ///// <returns></returns>
        //public static TItem GetItem<TItem>(string url)
        //        where TItem : class, new() {
        //    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
        //    try {
        //        HttpWebResponse response;
        //        Debug.Assert(request != null, "request != null");
        //        using(response = request.GetResponse() as HttpWebResponse) {
        //            Debug.Assert(response != null, "response != null");

        //            using (Stream stream = response.GetResponseStream()) {
        //                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TItem));

        //                    return (TItem) ser.ReadObject(stream) ;
        //            }
        //        }
        //    } catch {
        //        return default(TItem);
        //    }
        //}
    }
}