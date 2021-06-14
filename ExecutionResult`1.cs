using System;

namespace raminrahimzada
{
    public class ExecutionResult<TResponse> : ExecutionResult
    {
        public TResponse Response { get; set; }

        protected ExecutionResult(bool isSuccess, string errorCode, TResponse response) : base(isSuccess, errorCode)
        {
            Response = response;
        }

        public static ExecutionResult<TResponse> Success(TResponse response)
        {
            return new ExecutionResult<TResponse>(true, null, response);
        }

        public new static ExecutionResult<TResponse> Fail(string errorCode)
        {
            return new ExecutionResult<TResponse>(false, errorCode, default);
        }
    }
}
