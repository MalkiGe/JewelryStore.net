using DO;

namespace DalApi;
/// <summary>
/// 
/// </summary>
public interface ISale
{
    int Create(Sale item);
    Sale? Read(int id);
    List<Sale> ReadAll();
    void Update(Sale item);
    void Delete(int id);
}
