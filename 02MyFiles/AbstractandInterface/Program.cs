#region Interface : Sözleşme () bir şeyin yapılıp yapılamaması (CanAbleTo)
//Interface'lerin içerisine kod yazamayız bunlar sözleşmeyi sağlar abstract class ile farkı budur


public interface IVehicle
{
    void Go();
    void Stop();
}
public interface IRideable
{
    void Ride();
}
public interface IFlyable
{
    void Soar();
}
class Car : IVehicle
{
    public void Go()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
class Bisiklet : IVehicle, IRideable
{
    public void Ride()
    {
        throw new NotImplementedException();
    }

    void IVehicle.Go()
    {
        throw new NotImplementedException();
    }

    void IVehicle.Stop()
    {
        throw new NotImplementedException();
    }
}
#endregion

#region : Abstract (Soyutlama) Class 
public class SqlServerDb
{
    public string GetDbVersion() => "Sql Server 2012";
    public string GenererateSql(int id)
    {
        return $"SELECT + FROM USERS WHERE ID = {id}";
    }
    public void ExecuteSql(string sql)
    {
        //generateSql
    }
}

#endregion


