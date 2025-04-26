namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message)
            : base(data, true, message) { }

        public SuccessDataResult(T data)
            : base(data, true) { }

        public SuccessDataResult(string message)
            : base(default, true, message) { }

        public SuccessDataResult()
            : base(default, true) { }
    }
}


// farklı versiyonlar yazmış olduk

/*
    istersen data ve mesaj ver
    istersen sadece data ver
    istersen sadece mesaj ver
    istersen hiçbir şey verme


 */
