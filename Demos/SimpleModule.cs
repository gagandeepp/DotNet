using System;
using System.Web;
public class SimpleModule : IHttpModule
{
    private HttpApplication _application = null;
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void Init(HttpApplication context)
    {
        _application = context;
        context.EndRequest += context_EndRequest;
    }
    void context_EndRequest(object sender, EventArgs e)
    {
        string message = string.Format("processed on {0}",
        System.DateTime.Now.ToString());
        _application.Context.Response.Write(message);
    }
}
