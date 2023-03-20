//bu yapıyla beraber örneğin mailsender yapısı artık ImailServer'a bağımlı hale gelmiştir bu yapı birden fazla mail sunucusuna sahip olduğumuz için her biri için
//ayrı ayrı nesneler oluşturmak yerine bir interface (sözleşme) aracılığıyla bu nesneleri yönetmekte ve bu sayede hangi mail server yapısını kullandığımızın bir önemi kalmamaktadır

class MailSender
{
    public void Send(IMailServer mailServer)
    {
        mailServer.Send("Ahmet", "Veli");
    }

}
class Main
{
    void Gonder()
    {
        MailSender sender = new();
        sender.Send(new Gmail());
    }

}
interface IMailServer
{
    void Send(string to, string body);
}
class Gmail : IMailServer
{
    public void Send(string to, string body)
    {
        throw new NotImplementedException();
    }
}
class Hotmail : IMailServer
{
    public void Send(string to, string body)
    {
        throw new NotImplementedException();
    }
}
