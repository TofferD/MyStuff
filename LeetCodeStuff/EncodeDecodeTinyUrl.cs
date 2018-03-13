using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeStuff
{
    public class EncodeDecodeTinyUrl
    {
        private string RandomChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public Dictionary<string, string> Urls = new Dictionary<string, string>();

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            string tinyKey = generateRndKey();
            Urls.Add(tinyKey, longUrl);
            return "http://tofferurl.com/" + tinyKey;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            string key = shortUrl.Replace("http://tofferurl.com/", "");
            return Urls[key];
        }

        private string generateRndKey()
        {
            Random rnd = new Random();
            string key = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                key += RandomChars[rnd.Next(0, RandomChars.Length - 1)];
            }

            if (Urls.Keys.Contains(key))
            {
                key = generateRndKey();
            }

            return key;
        }
    }
}
