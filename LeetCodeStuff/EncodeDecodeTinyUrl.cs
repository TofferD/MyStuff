using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeStuff
{
    public class EncodeDecodeTinyUrl
    {
        private string RandomChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private string BaseUrl = @"http://tofferurl.com/";

        public Dictionary<string, string> Urls = new Dictionary<string, string>();

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            if (string.IsNullOrEmpty(longUrl))
            {
                return string.Empty;
            }

            string tinyKey = GenerateRndKey();

            if ((BaseUrl.Length + tinyKey.Length) >= longUrl.Length)
            {
                return longUrl;
            }
            else
            {
                Urls.Add(tinyKey, longUrl);
            }

            return BaseUrl + tinyKey;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            if (string.IsNullOrEmpty(shortUrl))
            {
                return string.Empty;
            }

            string key = shortUrl.Replace("http://tofferurl.com/", "");

            if (Urls.Keys.Contains(key))
            {
                return Urls[key];
            }
            else
            {
                return string.Empty;
            }
        }

        private string GenerateRndKey()
        {
            Random rnd = new Random();
            string key = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                key += RandomChars[rnd.Next(0, RandomChars.Length - 1)];
            }

            if (Urls.Keys.Contains(key))
            {
                key = GenerateRndKey();
            }

            return key;
        }
    }
}
