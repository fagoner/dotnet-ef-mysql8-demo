using System;

namespace mysqlefcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertData();
            PrintData();
        }

        private static void InsertData()
        {
            using (var context = new UserContext())
            {
                context.Database.EnsureCreated();

                var firstUser = new User
                {
                    Name = "Alfa Beta"
                };
                context.User.Add(firstUser);
                context.SaveChanges();
            }
        }


        private static void PrintData()
        {
            using (var context = new UserContext())
            {

                var users = context.User;

                foreach (var user in users)
                {
                    Console.WriteLine("{0} - {1}", user.ID, user.Name);
                }
            }
        }
    }
}
