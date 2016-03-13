using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndTask
{
    public class ConcurrentCollectionsDemo
    {
        /// <summary>
        /// 使用一般List會造成資料遺漏問題
        /// </summary>
        public void Run() 
        {
            var products = GetProducts();
            List<NewProduct> newProducts = new List<NewProduct>();

            Console.WriteLine("來源資料筆數:{0}", products.Count());
            Console.WriteLine("執行前結果資料筆數:{0}", newProducts.Count());

            Parallel.ForEach(products, x =>
            {
                int id = x.Id;
                string name = x.Name;
                int stock = 100 + x.Id;

                var newProduct = new NewProduct()
                {
                    Id = id,
                    Name = name,
                    Stock = stock
                };

                newProducts.Add(newProduct);
            });

            Console.WriteLine("執行後結果資料筆數:{0}", newProducts.Count());            
        }

        private object _obj = new object();

        /// <summary>
        /// use object lock
        /// </summary>
        public void Run2() 
        {
            var products = GetProducts();
            List<NewProduct> newProducts = new List<NewProduct>();

            Console.WriteLine("來源資料筆數:{0}", products.Count());
            Console.WriteLine("執行前結果資料筆數:{0}", newProducts.Count());

            var watch = new Stopwatch();

            watch.Start();

            Parallel.ForEach(products, x =>
            {
                int id = x.Id;
                string name = x.Name;
                int stock = 100 + x.Id;

                var newProduct = new NewProduct()
                {
                    Id = id,
                    Name = name,
                    Stock = stock
                };
                lock(_obj)
                {
                    newProducts.Add(newProduct);
                
                }                
            });

            watch.Stop();

            Console.WriteLine("Consume Time: {0} ms", watch.ElapsedMilliseconds);


            Console.WriteLine("執行後結果資料筆數:{0}", newProducts.Count());            
        }

        /// <summary>
        /// use ConcurrectCollection
        /// </summary>
        public void Run3()
        {
            var products = GetProducts();
            BlockingCollection<NewProduct> newProducts = new BlockingCollection<NewProduct>();            

            Console.WriteLine("來源資料筆數:{0}", products.Count());
            Console.WriteLine("執行前結果資料筆數:{0}", newProducts.Count());

            var watch = new Stopwatch();

            watch.Start();

            Parallel.ForEach(products, x =>
            {
                int id = x.Id;
                string name = x.Name;
                int stock = 100 + x.Id;

                var newProduct = new NewProduct()
                {
                    Id = id,
                    Name = name,
                    Stock = stock
                };
                newProducts.Add(newProduct);
            });

            watch.Stop();            

            Console.WriteLine("Consume Time: {0} ms", watch.ElapsedMilliseconds);
            
            Console.WriteLine("執行後結果資料筆數:{0}", newProducts.Count());
        }

        /// <summary>
        /// use ConcurrectCollection
        /// </summary>
        public void Run4()
        {
            var products = GetProducts();
            ConcurrentBag<NewProduct> newProducts = new ConcurrentBag<NewProduct>();

            Console.WriteLine("來源資料筆數:{0}", products.Count());
            Console.WriteLine("執行前結果資料筆數:{0}", newProducts.Count());

            Parallel.ForEach(products, x =>
            {
                int id = x.Id;
                string name = x.Name;
                int stock = 100 + x.Id;

                var newProduct = new NewProduct()
                {
                    Id = id,
                    Name = name,
                    Stock = stock
                };
                newProducts.Add(newProduct);
            });

            Console.WriteLine("執行後結果資料筆數:{0}", newProducts.Count());
        }
        
        /// <summary>
        /// List with EntitFramework
        /// </summary>
        public void Run5()
        {
            LinqDemoEntities db = new LinqDemoEntities();
            var products = GetProducts();            

            Console.WriteLine("來源資料筆數:{0}", products.Count());
            Console.WriteLine("執行前結果資料筆數:{0}", db.Order.Count());

            var watch = new Stopwatch();

            watch.Start();

            Parallel.ForEach(products, x =>
            {
                int id = x.Id;
                string name = x.Name;
                int stock = 100 + x.Id;

                var order = new Order()
                {
                    Id = id,
                    OrderName = name                    
                };

                db.Order.Add(order);
            });

            watch.Stop();

            Console.WriteLine("Consume Time: {0} ms", watch.ElapsedMilliseconds);
            db.SaveChanges();

            Console.WriteLine("執行後結果資料筆數:{0}", db.Order.Count());
        }

        /// <summary>
        /// ConcurrentCollections with EntitFramework
        /// </summary>
        public void Run6()
        {
            LinqDemoEntities db = new LinqDemoEntities();
            var products = GetProducts();
            ConcurrentBag<Order> cb = new ConcurrentBag<Order>();

            Console.WriteLine("來源資料筆數:{0}", products.Count());
            Console.WriteLine("執行前結果資料筆數:{0}", db.Order.Count());

            Parallel.ForEach(products, x =>
            {
                int id = x.Id;
                string name = x.Name;
                int stock = 100 + x.Id;

                var order = new Order()
                {
                    Id = id,
                    OrderName = name
                };

                cb.Add(order);
            });

            db.Order.AddRange(cb);

            db.SaveChanges();

            Console.WriteLine("執行後結果資料筆數:{0}", db.Order.Count());
        }

        private IEnumerable<Product> GetProducts() 
        {            
            for (int i = 0; i < 10000000; i++)
            {
                yield return new Product() { Id = i, Name = "Miles" + i };
            }
        }
    }



    class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }


    class NewProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
