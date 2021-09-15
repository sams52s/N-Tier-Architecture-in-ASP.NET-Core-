using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
	public class UserModel
	{
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string About { get; set; }
        public Nullable<System.DateTime> Joined_at { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
    }
}
