using Aggregates.CustomerAggregate.CustomerEntity;
using Aggregates.CustomerAggregate.PaymentMethods;
using Aggregates.OrderAggregate.OrderEntity;
using Aggregates.OrderAggregate.OrderParams;

namespace Aggregates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Хранилище (репозиторий) для управления списком покупателей
            var customerRepository = new CustomerRepository();
            //Фабрика для создания покупателей
            var customerFactory = new CustomerFactory();

            //Создание покупателя 1 с помощью фабрики (метод оплаты - cash)
            var customer1 = customerFactory.Create("Anna Swan",
                new CashPaymentMethod("dollar"));
            //Создание покупателя 2 с помощью фабрики (метод оплаты - card)
            var customer2 = customerFactory.Create("Mark Manson",
                new CardPaymentMethod(CardType.Mir, "7890345645676789", "Mark Manson", "01/2030"));
            
            //Добавление покупателя 1 в хранилище (в List репозитория)
            customerRepository.Add(customer1);
            //Добавление покупателя 2 в хранилище (в List репозитория)
            customerRepository.Add(customer2);

            Console.WriteLine(customer1);
            Console.WriteLine(customer2);

            //Хранилище (репозиторий) для управления списком заказов
            var orderRepository = new OrderRepository();
            //Фабрика для создания заказов
            var orderFactory = new OrderFactory();

            //Создание заказа 1 с помощью фабрики
            var order1 = orderFactory.Create(customer1);
            //Методы сущности Order (добавить в заказ продукт, установить адрес и статус)
            order1.AddProduct(new Product("First product", 40));
            order1.AddProduct(new Product("Second product", 80));
            order1.SetAddress(new Address("12", "Lenina lane", "Moscow", "Russia"));
            order1.SetStatus(OrderStatus.Paid);
            //Добавление заказа 1 в хранилище
            orderRepository.Add(order1);

            //Создание заказа 2 с помощью фабрики
            var order2 = orderFactory.Create(customer2);
            //Методы сущности Order (добавить в заказ продукт, установить адрес и статус)
            order2.AddProduct(new Product("Third product", 90));
            order2.AddProduct(new Product("Fourth product", 30));
            order2.SetAddress(new Address("34", "New lane", "Paris", "France"));
            order2.SetStatus(OrderStatus.Delivered);
            //Добавление заказа 2 в хранилище
            orderRepository.Add(order2);

            Console.WriteLine(order1);
            Console.WriteLine(order2);
        }
    }
}