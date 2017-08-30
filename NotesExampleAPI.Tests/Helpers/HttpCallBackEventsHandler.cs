/*
 * NotesExampleAPI.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using NotesExampleAPI.PCL.Http.Client;
using NotesExampleAPI.PCL.Http.Request;
using NotesExampleAPI.PCL.Http.Response;

namespace NotesExampleAPI.Tests.Helpers
{
    public class HttpCallBackEventsHandler
    {
        public HttpRequest Request { get; private set; }

        public HttpResponse Response { get; private set; }

        public void OnBeforeHttpRequestEventHandler(IHttpClient source, HttpRequest request)
        {
            this.Request = request;
        }

        public void OnAfterHttpResponseEventHandler(IHttpClient source, HttpResponse response)
        {
            this.Response = response;
        }
    }
}
