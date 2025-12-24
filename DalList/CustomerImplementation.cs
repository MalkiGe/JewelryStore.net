using DO;
using DalApi;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        /// <summary>
        /// פונקציה להוספת לקוח 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Create(Customer item)
        {
            DataSource.customers.Add(item);
            return item.Id;


        }
        /// <summary>
        /// /פונקציה למחיקת לקוח
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            foreach (Customer customer in DataSource.customers)
            {
                if (customer.Id == id)
                    DataSource.customers.Remove(customer);
            }

        }
        /// <summary>
        /// פונקציה שמחזירה לקוח על פי id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer? Read(int id)
        {
            foreach (Customer customer in DataSource.customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;
        }
        /// <summary>
        /// פונקציה שמחזירה את מערך הלקוחות
        /// </summary>
        /// <returns></returns>
        public List<Customer> ReadAll()
        {
            return DataSource.customers == null ? null : DataSource.customers;
        }
        /// <summary>
        /// פונקציה לעדכון פרטי לקוח 
        /// </summary>
        /// <param name="item"></param>
        public void Update(Customer item)
        {
            foreach (Customer customer in DataSource.customers)
            {
                if (customer.Id == item.Id)
                {
                    DataSource.customers.Remove(customer);
                    DataSource.customers.Add(item);
                }

            }
        }
    }
}

