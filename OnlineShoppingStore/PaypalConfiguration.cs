using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore
{
    public class PaypalConfiguration
    {
        //Variables for storing the clientID and clientSecret key
        public readonly static string ClientId;
        public readonly static string ClientSecret;
        //Constructor
        static PaypalConfiguration()
        {
           
                var config = GetConfig();
            ClientId = "ARTiQOA8ttLK8cQBMIxfnGl4WumRsGNblRPEFvTA6RFveifbS0l1EPV9iB-JgpRB8AeFZtHZ1AGKk5Y4";
            ClientSecret = "EDMNQL8xlGjAmq60OIedU07v3kZBOrNgXynGrgL-Ehp-UkGp2mxvOtHrQB1v0kubN8VfqYcWCMw_AMfY";
        }
        // getting properties from the web.config
        public static Dictionary<string, string> GetConfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }
        private static string GetAccessToken()
        {
            // getting accesstocken from paypal
            string accessToken = new OAuthTokenCredential(ClientId, ClientSecret, GetConfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            // return apicontext object by invoking it with the accesstoken
            APIContext apiContext = new APIContext(GetAccessToken());
            apiContext.Config = GetConfig();
            return apiContext;
        }
    }
}