namespace MessageBox.Avalonia.DTO
{
    public class MessageWindowResultDTO
    {
        public MessageWindowResultDTO(string message, string button)
        {
            Message = message;
            Button = button;
        }

        /// <summary>
        /// Result text
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Clicked button
        /// </summary>
        public string Button { get; }
    }
}