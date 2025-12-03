using DO;
namespace DalApi;


public interface ICustomer
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    int Create(Customer item);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Customer? Read(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    List<Customer> ReadAll();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    void Update(Customer item);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    void Delete(int id);
}


