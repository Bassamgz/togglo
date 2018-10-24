namespace Togglo.Core.Data.Model.DTO
{

    using System;
    using System.ComponentModel;

    public class Feature
    {
        [DisplayName("Feature Id")]
        public int Id { get; set; }

        [DisplayName("Feature Name")]
        public string UserName { get; set; }

        [DisplayName("Feature Description")]
        public string Description { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Modified Date")]
        public DateTime ModifiedOn { get; set; }
    }
}
