
namespace FormulaAirline.API.Models.Services
{
    public interface IMessageProducer
    {
        public void SendingMessage<T>(T message);
    }
}