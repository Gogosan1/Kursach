using Newtonsoft.Json;
namespace ModelMainForm
{
    public class Service
    {
        [JsonConstructor]
        public Service (string name, int price)
        {
            Price = price;
            Name = name;
        }

        public Service( string name, int price, int time)
        {
            Price = price;
            Name = name;
            Time = time;
        }
        
        public int Price { get; }
        
        public string Name { get; }
        [JsonIgnore]
        public int Time { get; }
    }
}
