using System;
using System.Collections.Generic;

namespace ModelMainForm.MVP.Model
{
    public class Master : ClaimWorker
    {

        public Master(string name, List<Service> services) : base(name, services)
        {}

        public override bool IsWorkerHaveServiceThanWork(ClientsRequest request)
        {
            foreach (var service in servicesThatWorkerHas)
            {
                if (String.Equals(request.Service.Name,service.Name))
                {
                    Work(request);
                    return true;
                }
}
        return false;
        }
        public override void Work(ClientsRequest request)
        {
            statistics.UpdateNumberOfClientsServed();
            statistics.UpdateAmountOfMoneyEarned(request.Service.Price);
           
            foreach(var service in servicesThatWorkerHas)
                if (service.Name == request.Service.Name)
                    request.IncreaseTime(service.Time);
                
            timeWhenMasterWillBeFree = request.GetTime();
            status = WorkerStatus.busy;

            request.Service = new Service(Constants.END_SERVICE, 0,0);
        }
    }
}