using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class UserTypeRepo
	{
        static ReviewHubEntities1 context;
        static UserTypeRepo()
        {
            context = new ReviewHubEntities1();
 
        }
        public static List<string> GetUserTypeNames()
        {
            var data = context.user_types.Select(e => e.Name).ToList();
            return data;
        }
        public static List<user_types> GetUserTypes()
        {
            return context.user_types.ToList();
        }
    }
}
