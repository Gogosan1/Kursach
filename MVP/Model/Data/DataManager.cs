using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ModelMainForm.MVP.Model.Data_Layer
{
    public class DataManager
    {
        public List<Service> GetServices() => services;
        public List<ClaimWorker> GetClaimWorkers() => claimWorkers;

        public DataManager()
        {
            services = new List<Service>();
            List<Service> servic = JsonDeserialize(pathJSON);
            if (servic != null)
                foreach (Service s in servic)
                {
                    services.Add(s);
                }
            claimWorkers = new List<ClaimWorker>();
        }

        public void Serialization(List<Service> s)
        {
            JsonSerialize(pathJSON, s);
        }

        public static void JsonSerialize(string path, object savedObject)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var json = JsonConvert.SerializeObject(savedObject, settings);

            using (var fs = new FileStream(path, FileMode.Create))
            {
                byte[] array = System.Text.Encoding.UTF8.GetBytes(json);
                fs.Write(array, 0, array.Length);
            }
        }
        public List<Service> JsonDeserialize(string path)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string json = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<List<Service>>(json, settings);
            
        }

        public void ClearTheFile()
        {
            services.Clear();
            services.Add(new Service(Constants.START_SERVICE, 0));
            JsonSerialize(pathJSON, services);
        }

        public void AddWorker(ClaimWorker newWorker)
        {
            claimWorkers.Add(newWorker);
        }

        private string pathJSON = @"services.json";
        private List<ClaimWorker> claimWorkers;
        private List<Service> services;
    }
}
