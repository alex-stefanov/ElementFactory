using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementFactory.Data.Models
{
    public class Test
    {
        public ICollection<Question> Questions { get; set; } = null!;
    }
}
