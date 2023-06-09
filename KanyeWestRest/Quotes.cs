﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeWestRest
{
    public static class Quotes
    {

        public static string KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;

        }

        public static string RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronReply = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronReply).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronQuote;
        }


    }
}
