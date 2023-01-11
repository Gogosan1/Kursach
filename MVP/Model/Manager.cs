using System;
using System.Collections.Generic;

namespace ModelMainForm.MVP.Model
{
    public class Manager : ClaimWorker
    {
  
        public Manager(string name, List<Service> services) : base(name, services)
        {}

        public override bool IsWorkerHaveServiceThanWork(ClientsRequest request)
        {
            if (String.Equals(request.Service.Name,Constants.START_SERVICE))
            {
                Work(request);
                return true;
            }
            else
                return false;
        }
        public override void Work(ClientsRequest request)
        {
            statistics.UpdateNumberOfClientsServed();
            statistics.UpdateAmountOfMoneyEarned(request.Service.Price);

            foreach (var servise in servicesThatWorkerHas)
                if (servise.Name == request.Service.Name)
                    request.IncreaseTime(servise.Time);

            
            Service start = new Service(" ", 0);

            foreach (var service in servicesThatWorkerHas)
                if (service.Name == Constants.START_SERVICE)
                {
                    start = new Service(service.Name, service.Price, service.Time);
                    servicesThatWorkerHas.Remove(service);
                    break;
                }


            foreach (var service in servicesThatWorkerHas)
                if (service.Name == Constants.END_SERVICE)
                {
                    servicesThatWorkerHas.Remove(service);
                    break;
                }
            request.Service = servicesThatWorkerHas[new Random().Next(servicesThatWorkerHas.Count)];

            servicesThatWorkerHas.Add(new Service(start.Name, start.Price, start.Time));
            servicesThatWorkerHas.Add(new Service(Constants.END_SERVICE, 0));

            timeWhenMasterWillBeFree = request.GetTime();
            status = WorkerStatus.busy;
        }

        
    }
}
