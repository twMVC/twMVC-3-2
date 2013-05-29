using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCValidate
{
    public class RemotePlus : RemoteAttribute
    {
        public RemotePlus(string action, string controller, string area)
            : base(action, controller, area)
        {
            this.RouteData["area"] = area;
        }
    }
}