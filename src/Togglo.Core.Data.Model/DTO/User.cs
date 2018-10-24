namespace Togglo.Core.Data.Model.DTO
{
    using System;
    using System.ComponentModel;

    public class User
    {
        [DisplayName("User Id")]
        public int Id { get; set; }

        [DisplayName("Username")]
        public string UserName { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedOn { get; set; }
    }
}
