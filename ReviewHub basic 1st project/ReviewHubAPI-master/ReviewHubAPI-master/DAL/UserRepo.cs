using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class UserRepo
	{
        static ReviewHubEntities1 context;
        static UserRepo()
        {
            context = new ReviewHubEntities1();
        }
        public static void AddUser(user model)
        {
            context.users.Add(model);
            context.SaveChanges();
        }
        public static List<user> GetAllUsers()
        {
            var data = context.users.ToList();
            return data;
        }
        public static user GetUser(int id)
        {
            var data = context.users.FirstOrDefault(e => e.Id == id);
            return data;
        }

        public static List<string> GetUserNames()
        {
            var data = context.users.Select(e => e.Username).ToList();
            return data;
        }
    }
}
