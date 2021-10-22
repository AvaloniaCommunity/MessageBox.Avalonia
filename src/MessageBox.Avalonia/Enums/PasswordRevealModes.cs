namespace MessageBox.Avalonia.Enums
{
    public enum PasswordRevealModes : byte
    {
        /// <summary>
        /// Don't show the reveal button
        /// </summary>
        None,

        /// <summary>
        /// Left click to toggle the reveal password
        /// </summary>
        Toggle,

        /// <summary>
        /// Left or right click and hold to temporary reveal the password
        /// </summary>
        Hold,

        /// <summary>
        /// Left click to toggle the reveal password | Right click and hold will temporary reveal password
        /// </summary>
        Both,
    }
}