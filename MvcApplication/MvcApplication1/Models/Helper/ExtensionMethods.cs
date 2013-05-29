using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Collections.Specialized;

public static class ExtensionMethods
{
    public static void ToFillQueryStringToRouteValueDictionary(this RouteValueDictionary routeValueDictionary, NameValueCollection querystring)
    {
        for (int i = 0; i < querystring.Count; i++)
        {
            var value = querystring[i];
            var key = querystring.Keys[i];
            if (string.IsNullOrEmpty(value))
            {
                routeValueDictionary.Remove(key);
                continue;
            }

            routeValueDictionary[querystring.Keys[i]] = querystring[i];
        }
    }
}