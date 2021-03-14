using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_API_2.Data.VO
{
    public class BookVO
    {
        public long Id { get; set; }
        public string author { get; set; }
        public DateTime launch_date { get; set; }
        public decimal price { get; set; }
        public string title { get; set; }
    }
}
