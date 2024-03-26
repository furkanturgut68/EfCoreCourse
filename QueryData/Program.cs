using System;
using System.Linq;
using QueryData.Data;
using QueryData.Entities;

namespace QueryData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new BlogContext();
            //context.Add(new Blog
            //{
            //    Title = "blog-1",
            //    Url = "ysk.com/blog-1"
            //});
            //context.Add(new Blog
            //{
            //    Title = "blog-2",
            //    Url = "ysk.com/blog-2"
            //});
            //context.Add(new Blog
            //{
            //    Title = "blog-3",
            //    Url = "ysk.com/blog-3"
            //});
            //context.Add(new Blog
            //{
            //    Title = "blog-4",
            //    Url = "ysk.com/blog-4"
            //});
             
            //context.SaveChanges();

            var query = context.Blogs.AsQueryable();

            var blog = query.Where(x => x.Title.Contains("blog-1") || x.Title.Contains("blog-2")).AsEnumerable();

            var blog2 = query.Where(x => x.Title == "blog-1");

            foreach (var item in blog2)
            {
                Console.WriteLine(item.Title);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
