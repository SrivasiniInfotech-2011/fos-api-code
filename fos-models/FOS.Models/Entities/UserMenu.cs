namespace FOS.Models.Entities
{
    /// <summary>
    /// User Menu Object which contains the User Menu Details
    /// </summary>
    public class UserMenu
    {
        /// <summary>
        /// Module Name
        /// </summary>
        public string? ModuleName { get; set; }

        /// <summary>
        /// Menus.
        /// </summary>
        public List<string>? Menus { get; set; }
    }

    public class UserMenuItem
    {
        /// <summary>
        /// Module Name.
        /// </summary>
        public string ModuleName { get; set; }

        /// <summary>
        /// Program Code.
        /// </summary>
        public string ProgramCode { get; set; }
    }
}
