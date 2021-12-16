using Beef;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Beef.AspNetCore.Spa.Response
{
    public class EmptyResponse
    {
        public string Content { get; set; }
    }

    public class APIResponse<T> where T : new()
    {
        public APIResponse(params string[] errors)
        {
            this.Errors.AddRange(errors);
            this.IsSuccessful = false;
        }

        public T Data { get; set; } = new T();

        public bool IsSuccessful { get; set; } = true;
        public ErrorType? ErrorType { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
