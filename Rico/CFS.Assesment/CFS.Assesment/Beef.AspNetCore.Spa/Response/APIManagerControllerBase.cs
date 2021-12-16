using Beef;
using Beef.AspNetCore.Spa.Ref;
using Beef.Entities;
using Beef.RefData;
using Beef.WebApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beef.AspNetCore.Spa.Response
{
    public partial class Basecontroler<Y> : Controller where Y : Basecontroler<Y>
    {
        //Gets / Updates or Creates a single Object
        protected APIResponse<T> InvokeAPI<T>(Func<Task<WebApiAgentResult<T>>> apiCall, T defaultValue = default(T)) where T : new()
        {
            var response = new APIResponse<T>()
            {
                IsSuccessful = false,
                Data = defaultValue
            };

            try
            {
                var apiResult = apiCall.Invoke().Result;

                response.StatusCode = apiResult.StatusCode;

                if ((apiResult.Messages != null) && (apiResult.Messages.Count() > 0))
                    response.Errors.AddRange(apiResult.Messages.Select(m => m.Text).ToList());

                if (!string.IsNullOrEmpty(apiResult.ErrorMessage))
                    response.Errors.Add(apiResult.ErrorMessage);

                if (apiResult.ErrorType != null)
                    response.ErrorType = apiResult.ErrorType;

                if ((apiResult.IsSuccess) && (apiResult.HasValue))
                {
                    response.Data = apiResult.Value;
                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(ex.ToString());
                response.ErrorType = ErrorType.BusinessError;
            }

            return response;
        }

        // Gets a Colections of Objects
        protected APIResponse<TColl> InvokeAPICollResult<TCollResult, TColl, TEntity>(Func<Task<WebApiAgentResult<TCollResult>>> apiCall, TColl defaultValue = default(TColl))
            where TCollResult : EntityCollectionResult<TColl, TEntity>
            where TColl : EntityBaseCollection<TEntity>, new()
            where TEntity : EntityBase
        {
            var response = new APIResponse<TColl>()
            {
                IsSuccessful = false,
                Data = defaultValue
            };

            try
            {
                var apiResult = apiCall.Invoke().Result;
                response.StatusCode = apiResult.StatusCode;

                if ((apiResult.Messages != null) && (apiResult.Messages.Count() > 0))
                    response.Errors.AddRange(apiResult.Messages.Select(m => m.Text).ToList());

                if (!string.IsNullOrEmpty(apiResult.ErrorMessage))
                    response.Errors.Add(apiResult.ErrorMessage);

                if (apiResult.ErrorType != null)
                    response.ErrorType = apiResult.ErrorType;

                if ((apiResult.IsSuccess) && (apiResult.HasValue))
                {
                    response.Data = apiResult.Value.Result;
                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(ex.ToString());
                response.ErrorType = ErrorType.BusinessError;
            }

            return response;
        }

        //Returns an Empty Response. Appropiate for calls with no Responses such as Delete Operations
        protected APIResponse<EmptyResponse> InvokeAPI<T>(Func<Task<WebApiAgentResult>> apiCall)
            where T : EmptyResponse, new()
        {
            var response = new APIResponse<EmptyResponse>()
            {
                IsSuccessful = false,
                Data = new EmptyResponse { Content = "Empty Content" }
            };

            try
            {
                var apiResult = apiCall.Invoke().Result;
                response.StatusCode = apiResult.StatusCode;

                if ((apiResult.Messages != null) && (apiResult.Messages.Count() > 0))
                    response.Errors.AddRange(apiResult.Messages.Select(m => m.Text).ToList());

                if (!string.IsNullOrEmpty(apiResult.ErrorMessage))
                    response.Errors.Add(apiResult.ErrorMessage);

                if (apiResult.ErrorType != null)
                    response.ErrorType = apiResult.ErrorType;

                if (apiResult.IsSuccess)
                {
                    response.Data.Content = apiResult.Content;
                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(ex.ToString());
                response.ErrorType = ErrorType.BusinessError;
            }

            return response;
        }


        //Gets a list of Referece Data
        protected APIResponse<List<RefItem>> InvokeAPIRef<TColl, TEntity>(Func<Task<WebApiAgentResult<TColl>>> apiCall)
            where TColl : List<TEntity>, new()
            where TEntity : Beef.RefData.Model.ReferenceDataBaseInt32, new()
        {
            var response = new APIResponse<List<RefItem>>()
            {
                IsSuccessful = false,
            };

            try
            {
                var apiResult = apiCall.Invoke().Result;
                response.StatusCode = apiResult.StatusCode;

                if ((apiResult.Messages != null) && (apiResult.Messages.Count() > 0))
                    response.Errors.AddRange(apiResult.Messages.Select(m => m.Text).ToList());

                if (!string.IsNullOrEmpty(apiResult.ErrorMessage))
                    response.Errors.Add(apiResult.ErrorMessage);

                if (apiResult.ErrorType != null)
                    response.ErrorType = apiResult.ErrorType;

                if ((apiResult.IsSuccess) && (apiResult.HasValue))
                {
                    response.Data = apiResult
                        .Value
                        .Select(item => new RefItem(item))
                        .ToList();

                    response.IsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(ex.ToString());
                response.ErrorType = ErrorType.BusinessError;
            }

            return response;
        }

        //Gets a list of Referece Data
        protected List<RefItem> AppendAPIRef<TColl, TEntity>(Func<Task<WebApiAgentResult<TColl>>> apiCall)
            where TColl : List<TEntity>, new()
            where TEntity : Beef.RefData.Model.ReferenceDataBaseInt32, new()
        {
            var response = new List<RefItem>() { };

            try
            {
                var apiResult = apiCall.Invoke().Result;
                if ((apiResult.IsSuccess) && (apiResult.HasValue))
                {
                    response = apiResult
                        .Value
                        .Select(item => new RefItem(item))
                        .ToList();
                }
            }
            catch (Exception ex)
            {
            }
            return response;
        }
    }
}


