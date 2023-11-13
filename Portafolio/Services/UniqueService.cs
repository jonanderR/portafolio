namespace Portafolio.Services
{
    public class UniqueService
    {
        public UniqueService()
        {
            GetGuid = Guid.NewGuid();
        }
        public Guid GetGuid { get; private set; }
    }

    public class DelimitedService
    {
        public DelimitedService()
        {
            GetGuid = Guid.NewGuid();
        }
        public Guid GetGuid { get; private set; }
    }

    public class TransientService
    {
        public TransientService()
        {
            GetGuid = Guid.NewGuid();
        }
        public Guid GetGuid { get; private set; }
    }
}
