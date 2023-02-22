namespace Retail.Utilities
{
    [Serializable]
    public class InvalidIdException : Exception
    {
        public InvalidIdException(string message) : base(String.Format("Invalid ID ",message)) { }
    }
}