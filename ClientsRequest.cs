
namespace ModelMainForm
{

    public class ClientsRequest
    {
        private int time; 
        public int GetTime() => time;
        public Service Service { get; set; } 

        public ClientsRequest(int time, Service service)
        {
            this.time = time;
            Service = service;
        }

        public void IncreaseTime(int time)
        {
            this.time += time;
        }
    }
}
