﻿namespace MagicVilla_Utility
{
    public class SD
    {
        public enum ApiType
        {
            GET,
            POST, 
            PUT, 
            DELETE
        }
        public static string AccessToken = "JWTToken";
        public static string CurrentAPIVersion = "V2";
        public const string Admin = "admin";
        public static string Customer = "customer";
        public enum ContentType
        {
            Json,
            MultipartFormData
        }
    }
}
