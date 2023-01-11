using System.Collections.Generic;

namespace ModelMainForm.MVP.Model
{
    public enum WorkerStatus
    {
        free = 0,
        busy
    }
    public  abstract class ClaimWorker
    {

        public ClaimWorker(string name, List<Service> services)
        {
            statistics = new StatisticsOfWorkers();
            servicesThatWorkerHas = new List<Service>();
            foreach(Service service in services)
                servicesThatWorkerHas.Add(service);
            status = WorkerStatus.free;
            Name = name;
        /*    for (int i = 0; i < servicesThatWorkerHas.Count; i++)
                statistics.AddNewService();
        */}

        public abstract bool IsWorkerHaveServiceThanWork(ClientsRequest request);

        public abstract void Work(ClientsRequest request);

        public WorkerStatus GetStatus()
        {
            return status;
        }

        public void ChangeStatus(int nowTime)
        {
            if (timeWhenMasterWillBeFree == nowTime)
                status = WorkerStatus.free;
        }

        public string Name { get; }

        public StatisticsOfWorkers ReturnStatistics() => statistics;
        
        public void ClearStatictic ()
        { 
            statistics = null;
            statistics = new StatisticsOfWorkers();
            timeWhenMasterWillBeFree = 0;
            status = WorkerStatus.free;
        }

        public void CalculateDowntime()
        {
            if (status == WorkerStatus.free)
                statistics.UpdateDownTime();
        }

        protected List<Service> servicesThatWorkerHas;
        protected StatisticsOfWorkers statistics;
        protected WorkerStatus status;
        protected int timeWhenMasterWillBeFree;

    }
}
