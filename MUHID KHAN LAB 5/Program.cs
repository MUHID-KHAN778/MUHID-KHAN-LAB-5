using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUHID_KHAN_LAB_5
{
    public class ShoppingCart
    {
        public int cartID;
        public string customername;
        public double totalprice;
        public Product[] products;
        public int count;
        public ShoppingCart()
        {
            cartID = 1;
            customername = " ";
            totalprice = 0;
            products = new Product[20];
            count = 0;
        }
        
        public void addproduct(Product product)
        {
            products[count] = product;
            count++;
            totalprice += product.price;
        }
        
        public void displayProducts()
        {
            for (int i = 0; i < count; i++)
            {
                if (products[i] != null)
                {


                    Console.WriteLine("the product ID is {0}", products[i].productid);
                    Console.WriteLine("the product name is {0}", products[i].name);
                    Console.WriteLine("the product's price is {0}", products[i].price);
                    Console.WriteLine("-------------------------");
                }
                else {
                    continue;    }

            }
            Console.WriteLine("the total Bill is : {0}",totalprice);

        }
        public void removeProduct(int key) 
        {
            for (int i = 0; i < count; i++) 
            {
                if (products[i].productid == key)
                {
                    totalprice -= products[i].price;
                    products[i]= null;
                    
                }
            }

        }
    }
        public class Product
        {
            public int productid;
            public string name;
            public double price;
            public Product(int productid, string name, double price)
            {
                this.productid = productid;
                this.name = name;
                this.price = price;
            }
        public void display()
        {
            Console.WriteLine("the product ID is {0}", productid);
            Console.WriteLine("the product name is {0}", name);
            Console.WriteLine("the product's price is {0}", price);
        }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
            Product product1 = new Product(1, "Laptop", 90000);
            Product product2 = new Product(2, "Gamepad", 4500);
            Product product3 = new Product(3, "Phone", 45000);
            Product product4 = new Product(4, "Ipad", 50000);
            ShoppingCart cart = new ShoppingCart();
            
            Console.WriteLine("enter your name: ");
            cart.customername= Console.ReadLine();
           
            int choice = 0;
         
            while (choice!=-1)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("|Choose a product: |");
                Console.WriteLine("-------------------");
                product1.display();
                Console.WriteLine("-------------------------");
                product2.display();
                Console.WriteLine("-------------------------");
                product3.display();
                Console.WriteLine("-------------------------");
                product4.display();
                Console.WriteLine("-------------------------");
                Console.WriteLine("enter the ID of the desired product(-1 to exit): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)

                {
                    case 1:
                        cart.addproduct(product1);
                        break;
                    case 2:
                        cart.addproduct(product2);
                        break;
                    case 3:
                        cart.addproduct(product3);
                        break;
                    case 4:
                        cart.addproduct(product4);
                        break;
                    default:
                        break;

                }
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("now your cart have following products");
            cart.displayProducts();
            Console.WriteLine("do you want to remove a products");
            string choice_rem= Console.ReadLine();
            Console.Clear();
            if (choice_rem == "yes")
            {
                Console.WriteLine("enter the ID of the product you want to remove: ");
                int key= int.Parse(Console.ReadLine());
                cart.removeProduct(key);
            }
            Console.WriteLine("now your cart have following products");
            cart.displayProducts();




        }
        }
    }

