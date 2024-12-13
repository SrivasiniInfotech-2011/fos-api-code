namespace FOS.Models.Responses
{
    public class FOSResponse
    {
        public Status ?Status { get; set; }
        public Error? Error { get; set; }

        public object? Message { get; set; }
        public int? Id { get; set; }
    }

    public class Error
    {
        public string? ErrorMessage { get; set; }
    }
    public enum Status
    {
        Success,
        Error
    }
}
