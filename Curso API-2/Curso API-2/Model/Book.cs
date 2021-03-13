using Curso_API_2.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curso_API_2.Model
{
    [Table("Books")]
    public class Book : BaseEntity
    {
        public string author { get; set; }
        public DateTime launch_date { get; set; }
        public decimal price { get; set; }
        public string title { get; set; }
    }
}
