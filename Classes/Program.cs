namespace Classes
{
     class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();   
            productManager.Update();

            //Class içinde PROPERTY tanımlamak
            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";


            Customer customer2 = new Customer { 
            Id =2, City ="İstanbul" , FirstName = "Derin" ,LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName); //get(al) çalışıyor.


            Console.ReadLine();

        }
    }

    //Burada genel anlamda bir guruplama yapmış olduk.
    

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated");
        }
    }
}