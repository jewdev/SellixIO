using System;
using System.IO;
using System.Net;

namespace SellixIO
{
    public class Sellix
    {
        // Instance Variable
        private string token;

        // Constructor
        public Sellix(string token)
        {
            this.token = token;
        }

        // Get

        // Blacklist
        public string GetAllBlacklist()
        {
            return Get("blacklists");
        }

        public string GetBlacklist(string uniqid)
        {
            return Get($"blacklists/{uniqid}");
        }

        // Category
        public string GetAllCategories()
        {
            return Get("categories");
        }

        public string GetCategory(string uniqid)
        {
            return Get($"categories/{uniqid}");
        }

        // Coupon
        public string GetAllCoupons()
        {
            return Get("coupons");
        }

        public string GetCoupon(string uniqid)
        {
            return Get($"coupons/{uniqid}");
        }

        // Feedback
        public string GetAllFeedbacks()
        {
            return Get("feedback");
        }

        public string GetFeedback(string uniqid)
        {
            return Get($"feedback/{uniqid}");
        }

        // Order
        public string GetAllOrders()
        {
            return Get("orders");
        }

        public string GetOrder(string uniqid)
        {
            return Get($"orders/{uniqid}");
        }

        // Product
        public string GetAllProducts()
        {
            return Get("products");
        }

        public string GetProduct(string uniqid)
        {
            return Get($"products/{uniqid}");
        }

        // Query
        public string GetAllQueries()
        {
            return Get("queries");
        }

        public string GetQuery(string uniqid)
        {
            return Get($"queries/{uniqid}");
        }

        // Private Functions
        private string Get(string url)
        {
            WebRequest request = WebRequest.Create($"https://dev.sellix.io/v1/{url}");
            request.Method = "GET";
            request.Headers.Add("Authorization", $"Bearer {token}");

            WebResponse response = request.GetResponse();

            string responseFromServer;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream ?? throw new InvalidOperationException());
                responseFromServer = reader.ReadToEnd();
            }
            response.Close();

            return responseFromServer;
        }
    }
}