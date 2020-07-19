namespace MessageBox.Avalonia.DTO
{
    public class MessageWindowResultDTO
    {
        public string Message { get; }
        public string Button { get; }

        public MessageWindowResultDTO(string message, string button)
        {
            Message = message;
            Button = button;
        }
    }
}