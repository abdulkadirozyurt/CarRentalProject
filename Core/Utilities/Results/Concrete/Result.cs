using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        // readonly properties can be set only in the constructor.
        public Result(bool success)
        {
            Success = success;
        }

        public Result(bool success, string message)
            : this(success)
        {
            Message = message;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
