namespace Togglo.Core.Data.Model.DTO
{
    using System.ComponentModel;

    public class UserFlag
    {
        [DisplayName("User Id")]
        public int UserId { get; set; }

        [DisplayName("Flag Id")]
        public int FlagId { get; set; }
    }
}
