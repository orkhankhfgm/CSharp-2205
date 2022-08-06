namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is abstract and interface?
            //BaseClass bc = new BaseClass(); //You can't create an instance of abstract class
            Customer customer = new Customer();

            customer.Test();
            customer.ShowTime();

            VipCustomer vip = new VipCustomer();
            //vip.ShowTime();
            #endregion


            #region Interface

            #endregion
        }
    }
}
