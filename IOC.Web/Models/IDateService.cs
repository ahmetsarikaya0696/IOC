namespace IOC.Web.Models
{
    public interface IDateService
    {
        public DateTime GetCurrentDate { get; }
    }

    public interface ISingletonDateService : IDateService
    {

    }

    public interface IScopedDateService : IDateService
    {

    }

    public interface ITransientDateService : IDateService
    {

    }
}
