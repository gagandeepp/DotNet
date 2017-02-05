﻿<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;

public class ImageHandler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        //Whenever a request for *.image comes this will be send as response to the browser
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}