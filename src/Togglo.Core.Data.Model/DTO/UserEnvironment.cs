namespace Togglo.Core.Data.Model.DTO
{
    using System.ComponentModel;

    public class UserEnvironment
    {
        [DisplayName("User Id")]
        public int UserId { get; set; }

        [DisplayName("Environment Id")]
        public int EnvId { get; set; }
    }
}
