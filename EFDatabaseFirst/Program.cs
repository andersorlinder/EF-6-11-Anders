using System;
using System.Globalization;
using System.Linq;

namespace EFDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using var bikeStores = new BikeStoresContext();
            // UPPGIFT 6
            //var dLetterCustomers = bikeStores.Customers.Where(c => c.FirstName.Substring(0) == "D").ToList();

            //    foreach (Customers c in dLetterCustomers)
            //    {
            //        Console.WriteLine(c.FirstName + " " + c.LastName);
            //    }

            //var domains = bikeStores.Customers.AsEnumerable().GroupBy(c => c.Email.Substring(c.Email.IndexOf('@') + 1)).Select(s => new { domain = s.Key, noOfUse = s.Count() });
            //var domains = (from c in bikeStores.Customers.AsEnumerable()
            //               group c by c.Email.Substring(c.Email.IndexOf('@') + 1) into u
            //               select new { domain = u.Key, noOfUse = u.Count() });

            //Console.WriteLine("Domain".PadRight(15) + "NoOfUse");
            //foreach (var d in domains)
            //{
            //    Console.WriteLine(d.domain.PadRight(15) + d.noOfUse);
            //}

            //var CustomersAndOrders = bikeStores.Customers.Select(c => new { name = c.FirstName + " " + c.LastName, noOfOrders = c.Orders.Count() }); ;
            //var CustomersAndOrders = (from c in bikeStores.Customers
            //                          select new { name = c.FirstName + " " + c.LastName, noOfOrders = c.Orders.Count() });

            //Console.WriteLine("Customer".PadRight(20) + "NoOfOrders");
            //foreach (var c in CustomersAndOrders)
            //{
            //    Console.WriteLine(c.name.PadRight(20) + c.noOfOrders);
            //}

            // UPPGIFT 7
            //Console.WriteLine(bikeStores.Products.Where(product => product.Active == false).Count() == 118);
            //Console.WriteLine(bikeStores.Products.Where(product => product.Active == false).Count() == 203);

            // UPPGIFT 8
            //Jannette fick sparken för hon tog bort Electraprodukterna ur sortementet
            //Affärsägaren tyckte inte om Jannettes val av att ta bort Electraprodukterna ut sortementet.
            //Sätt alla Electra cyklarna till active igen.Sätt Jannette till inaktiv i Staff tabellen och
            //sätt Marcelenes chef till Fabiola och Venitas chef till Marcelene.
            //Lägg också till det nya stjärnskottet Kalle Svensson.
            //Han tar över Jannettes telefonnummer jobbar i samma butik som Jannette gjorde och har Marcelene som chef.
            //Höj också alla Electracyklars kvantitet i stock tabellen med 10 % avrundat.
            //Använd EF för att göra samtliga operationer.

            //bikeStores.Staffs.Add(new Staffs { FirstName = "Kalle", LastName = "Svensson", Email = "kalle.svensson@bikes.shop", Phone = bikeStores.Staffs.Where(s => s.StaffId == 5).Single().Phone, Active = 1, StoreId = bikeStores.Staffs.Where(s => s.StaffId == 5).Single().StoreId, ManagerId = 6 });
            //bikeStores.Staffs.Where(s => s.StaffId == 5).Single().Phone = null;
            //foreach (var stock in bikeStores.Stocks.ToList())
            //{
            //    if (stock.Product.BrandId == 1)
            //    {
            //        stock.Quantity = (int)(Math.Round(1.1 * (double)stock.Quantity, 0, MidpointRounding.AwayFromZero));
            //    }
            //}
            //bikeStores.SaveChanges();


            // UPPGIFT 9
            //Console.Write("Bike Stores\n\nVälj storeID (1-3): ");
            //var store = Console.ReadLine();
            //Console.Write("Välj personalID: ");
            //var staffID = Console.ReadLine();
            //Console.Clear();

            //Console.Write("*** Ny kund ***\n\nFörnamn: ");
            //var firstname = Console.ReadLine();
            //Console.Write("Efternamn: ");
            //var lastname = Console.ReadLine();
            //Console.Write("Telefon: ");
            //var phone = Console.ReadLine();
            //Console.Write("Epost: ");
            //var email = Console.ReadLine();
            //Console.Write("Adress: ");
            //var street = Console.ReadLine();
            //Console.Write("Region (ej nödvändigt): ");
            //var state = Console.ReadLine();
            //Console.Write("Postnummer: ");
            //var zip = Console.ReadLine();
            //Console.Write("Postadress: ");
            //var city = Console.ReadLine();

            //var customer = new Customers
            //{
            //FirstName = firstname,
            //LastName = lastname,
            //Phone = phone,
            //Email = email,
            //Street = street,
            //State = state,
            //ZipCode = zip,
            //City = city
            //};
            //bikeStores.Customers.Add(customer);

            //Console.WriteLine($"Välkommen {firstname}!\n\nVilken cykel vill du köpa?");

            //var storestock = bikeStores.Stocks.Where(s => s.StoreId == int.Parse(store) && s.Quantity > 0);
            //var bikes = (from p in bikeStores.Products
            //join stocks in bikeStores.Stocks on
            //  new { p.ProductId, p.Stocks.Single(s => s.StoreId == int.Parse(store)).StoreId } equals new { stocks.ProductId, stocks.StoreId}
            //where stocks.Quantity > 0 && p.Active == true
            //select new { p.ProductId, p.ProductName, stocks.Quantity});

            //Console.WriteLine("ID  " + "Modell".PadRight(55) + " " + "Lagersaldo");
            //foreach (var bike in bikes)
            //{
            //Console.WriteLine(bike.ProductId.ToString().PadRight(4) + bike.ProductName.PadRight(55) + " " + bike.Quantity);
            //}

            //Console.Write("\nVälj cykelns ID: ");
            //var bikeToBy = bikeStores.Products.Single(b => b.ProductId == int.Parse(Console.ReadLine()));
            //bikeStores.Stocks.Single(b => b.ProductId == bikeToBy.ProductId && b.StoreId == int.Parse(store)).Quantity -= 1;

            //var date = DateTime.Now;
            //var order = new Orders { OrderStatus = 4, OrderDate = date, RequiredDate = date, StoreId = int.Parse(store), StaffId = int.Parse(staffID) };
            //customer.Orders.Add(order);
            //order.OrderItems.Add(new OrderItems { ItemId = 1, ProductId = bikeToBy.ProductId, Quantity = 1, ListPrice = bikeToBy.ListPrice, Discount = 0 });
            //bikeStores.SaveChanges();

            // UPPGIFT 10
            //Console.WriteLine($"ID  " + "Namn");
            //foreach (var s in bikeStores.Staffs)
            //{
            //Console.WriteLine(s.StaffId.ToString().PadRight(4) + s.FirstName + " " + s.LastName);
            //}

            //Console.Write("Välj personal-ID: ");
            //var staff = bikeStores.Staffs.Single(s => s.StaffId == int.Parse(Console.ReadLine()));
            //Console.Clear();
            //Console.WriteLine("Personalstatistik\n" + staff.FirstName + " " + staff.LastName + " " + staff.Store.StoreName);

            //Console.WriteLine();

            //var brandsSold = (from o in staff.Orders
            //join i in bikeStores.OrderItems on
            //o.OrderId equals i.OrderId
            //group i by i.Product.BrandId into brandgroup
            //select new { brandID = brandgroup.Key, quantity = brandgroup.Sum(x => x.Quantity) });
            //var bestsellingBrandID = brandsSold.Single(p => p.quantity == brandsSold.Max(q => q.quantity));
            //Console.WriteLine("Säljarens mest sålda märke: " + bikeStores.Brands.Single(p => p.BrandId == bestsellingBrandID.brandID).BrandName);

            //var productsSold = (from o in staff.Orders
            //join i in bikeStores.OrderItems on
            //o.OrderId equals i.OrderId
            //group i by i.ProductId into productgroup
            //select new { productID = productgroup.Key, quantity = productgroup.Sum(x => x.Quantity) });
            //var bestsellingProductID = productsSold.Single(p => p.quantity == productsSold.Max(q => q.quantity));
            //Console.WriteLine("Säljarens mest sålda cykel: " + bikeStores.Products.Single(p => p.ProductId == bestsellingProductID.productID).ProductName);

            //var toplistCustomers = (from o in staff.Orders
            //join i in bikeStores.OrderItems on
            //o.OrderId equals i.OrderId
            //group o by o.CustomerId into customergroup
            //select new 
            //{
            //CustomerID = customergroup.Key,
            //customerBillSum = customergroup.Sum(
            //order => order.OrderItems.Sum(
            //item => item.Quantity * item.ListPrice * (1 - item.Discount)
            //)
            //)
            //});
            //var tenTopCustomerID = toplistCustomers.OrderByDescending(c => c.customerBillSum).Take(10);
            //Console.WriteLine("Säljarens 10 bästa kunder:");
            //foreach (var c in tenTopCustomerID)
            //{
            //var customer = bikeStores.Customers.Single(x => x.CustomerId == c.CustomerID);
            //Console.WriteLine(" - " + customer.FirstName + " " + customer.LastName);
            //}

            //var numberOfCustomers = (from o in staff.Orders
            //select o.CustomerId).Distinct().Count();
            //Console.WriteLine("Säljarens antal kunder: " + numberOfCustomers);

            //var customersDiscount = (from o in staff.Orders
            //join i in bikeStores.OrderItems on
            //o.OrderId equals i.OrderId
            //group o by o.CustomerId into customergroup
            //select new 
            //{
            //CustomerID = customergroup.Key, 
            //customerDiscount = customergroup.Sum(
            //order => order.OrderItems.Sum(
            //item => item.Quantity * item.ListPrice * item.Discount)
            //) 
            //});
            //var sumOfDiscount = Math.Round(customersDiscount.Sum(x => x.customerDiscount), 0);
            //Console.WriteLine("Säljarens summerade rabatt: $" + sumOfDiscount);

            // UPPGIFT 11
            //ConsoleKey quit = ConsoleKey.Spacebar;
            //while (quit != ConsoleKey.Escape)
            //{
                //Console.Clear();
                //Console.Write("BikeStores statistik\n" +
                    //"1. Säljarnas rabatt\n" +
                    //"2. Butikernas intäkter\n" +
                    //"3. Butikernas antal kunder\n" +
                    //"4. Butikernas antal ordrar\n\n" +
                    //"Välj nummer: ");

                //switch (Console.ReadKey().Key)
                //{
                    //case ConsoleKey.D1:
                        //DiscountFromStaffs(bikeStores);
                        //break;
                    //case ConsoleKey.D2:
                        //RevenueFromStores(bikeStores);
                        //break;
                    //case ConsoleKey.D3:
                        //CustomersInStores(bikeStores);
                        //break;
                    //case ConsoleKey.D4:
                        //OrdersInStores(bikeStores);
                        //break;
                    //default:
                        //Console.WriteLine("\nFelaktigt menyval");
                        //break;
                //}
                //Console.WriteLine("\nTryck esc för att avsluta, annan knapp för meny.");
                //quit = Console.ReadKey().Key;
            //}

        }

        private static void OrdersInStores(BikeStoresContext bikeStores)
        {
            Console.Clear();
            var ordersInStores = (from o in bikeStores.Orders.ToList()
                                  group o by o.StoreId into storegroup
                                  select new
                                  {
                                      storeID = storegroup.Key,
                                      noOfOrders = storegroup.Select(o => o.OrderId).Count()
                                  } 
                                 );
            var ordersInStoresSorted = ordersInStores.OrderByDescending(s => s.noOfOrders);

            Console.WriteLine("Topplista  " + "Butik".PadRight(20) + " " + "Antal ordrar");
            int num = 1;
            foreach (var st in ordersInStoresSorted)
            {
                var store = bikeStores.Stores.Single(s => s.StoreId == st.storeID);
                Console.WriteLine(
                                     num.ToString().PadRight(11) 
                                     + bikeStores.Stores.Single(s => s.StoreId == st.storeID).StoreName.PadRight(20) 
                                     + " " + st.noOfOrders
                                 );
                num++;
            }
        }

        private static void CustomersInStores(BikeStoresContext bikeStores)
        {
            Console.Clear();
            var customersInStores = (from o in bikeStores.Orders.ToList()
                                     group o by o.StoreId into storegroup
                                     select new 
                                     {
                                         storeID = storegroup.Key, 
                                         noOfCustomers = storegroup.Select(c => c.CustomerId).Distinct().Count() 
                                     }
                                    );
            var customersInStoresSorted = customersInStores.OrderByDescending(s => s.noOfCustomers);

            Console.WriteLine("Topplista  " + "Butik".PadRight(20) + " " + "Antal unika kunder");
            int num = 1;
            foreach (var st in customersInStoresSorted)
            {
                Console.WriteLine(
                                     num.ToString().PadRight(11) 
                                     + bikeStores.Stores.Single(s => s.StoreId == st.storeID).StoreName.PadRight(20) 
                                     + " " + st.noOfCustomers
                                 );
                num++;
            }
        }

        private static void RevenueFromStores(BikeStoresContext bikeStores)
        {
            Console.Clear();
            var revenueFromStores = (from o in bikeStores.Orders.ToList()
                                     join i in bikeStores.OrderItems on
                                          o.OrderId equals i.OrderId
                                     group o by o.StoreId into storegroup
                                     select new
                                     {
                                         storeID = storegroup.Key,
                                         revenue = Math.Round(
                                                      storegroup.Sum(
                                                          order => order.OrderItems.Sum(
                                                              item => item.Quantity * item.ListPrice * (1-item.Discount)
                                                          )
                                                      )
                                                   )
                                     }
                                    );
            var revenueFromStoresSorted = revenueFromStores.OrderByDescending(s => s.revenue);

            Console.WriteLine("Topplista  " + "Butik".PadRight(20) + " " + "Summa intäkter");
            int num = 1;
            foreach (var st in revenueFromStoresSorted)
            {
                Console.WriteLine(
                                     num.ToString().PadRight(11) 
                                     + bikeStores.Stores.Single(s => s.StoreId == st.storeID).StoreName.PadRight(20) 
                                     + " " + string.Format(new CultureInfo("en-US"), "{0:C0}", st.revenue)
                                 );
                num++;
            }
        }

        private static void DiscountFromStaffs(BikeStoresContext bikeStores)
        {
            Console.Clear();
            var discountFromStaffs = (from o in bikeStores.Orders.ToList()
                                      join i in bikeStores.OrderItems on
                                           o.OrderId equals i.OrderId
                                      group o by o.StaffId into staffgroup
                                      select new 
                                      {
                                          staffID = staffgroup.Key, 
                                          discount = staffgroup.Sum(
                                                        order => order.OrderItems.Sum(
                                                            item => item.Quantity * item.ListPrice * item.Discount
                                                        )
                                                     )
                                                      
                                      }
                                     );
            var discountFromStaffsSorted = discountFromStaffs.OrderByDescending(s => s.discount);

            Console.WriteLine("Topplista  " + "Säljare".PadRight(20) + " " + "Summa rabatt");
            int num = 1;
            foreach (var st in discountFromStaffsSorted)
            {
                var staff = bikeStores.Staffs.Single(s => s.StaffId == st.staffID);
                Console.WriteLine(num.ToString().PadRight(11) 
                    + (staff.FirstName + " " 
                    + staff.LastName).PadRight(20) 
                    + " " + string.Format(new CultureInfo("en-US"), "{0:C0}", st.discount)
                    );
                num++;
            }
            Console.WriteLine("\nSäljare utan sålda ordrar ingår inte.");
        }
    }
}
