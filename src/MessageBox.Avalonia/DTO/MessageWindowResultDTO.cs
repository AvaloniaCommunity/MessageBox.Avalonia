namespace MessageBox.Avalonia.DTO
{
    public class MessageWindowResultDTO
    {
        /// <summary>
        /// Result text
        /// </summary>
        public string Message { get; }
        
        /// <summary>
        /// Clicked button
        /// </summary>
        public string Button { get; }

        public MessageWindowResultDTO(string message, string button)
        {
            Message = message;
            Button = button;
        }
    }
}