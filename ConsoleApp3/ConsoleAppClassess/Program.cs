using System;

namespace ConsoleAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Jane","Manson","12.11.1990","asdf@mail.com","married");
            Console.WriteLine(user.name);
            Console.WriteLine(user.surname);
            Console.WriteLine(user.DateOfBirth);
            Console.WriteLine(user.email);
            Console.WriteLine(user.isSingle);
            Post post = new Post();
            post.CommentCount = 3;
            post.LikeCount = 123;
            post.SharedDate = "1 march";
            string[] Post= { "post1", "post2", "post3" };
            foreach (var posts in Post)
            {
                Console.WriteLine(posts);
            }
            string[] Comment = { "comment1", "comment2", "comment3" };
            foreach (var comments in Comment)
            {
                Console.WriteLine(comments);
            }
            


        }
    }
}
