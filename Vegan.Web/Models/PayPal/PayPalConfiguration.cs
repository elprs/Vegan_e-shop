using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using PayPal.Api;

namespace Vegan.Web.Models.PayPal
{
    //Get configuration from web.config file
    public class PayPalConfiguration
    {
        // =============================== Fields ========================================
        public readonly static string ClientId;
        public readonly static string ClientSecret;

        // =============================== constructor ===================================

        static PayPalConfiguration()
        {
            var config = GetConfig();
            ClientId = config["clientId"];
            ClientSecret = config["clientSecret"];
        }

        public static Dictionary<string, string> GetConfig()
        {
            return ConfigManager.Instance.GetProperties();
        }

        //Create access Token
        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(ClientId, ClientSecret, GetConfig()).GetAccessToken();
            return accessToken;
        }

        //This will return API contect Object
        public static APIContext GetAPIContext()
        {
            APIContext aPIContext = new APIContext(GetAccessToken());
            aPIContext.Config = GetConfig();
            return aPIContext;
        }
    }
}