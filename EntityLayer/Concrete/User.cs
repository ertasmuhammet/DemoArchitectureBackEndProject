using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string IMAGE_URL { get; set; }
        public byte[] PASSWORD_HASH { get; set; }
        public byte[] PASSWORD_SALT { get; set; }
    }
}
