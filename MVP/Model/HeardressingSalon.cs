using ModelMainForm.MVP.Model.Data_Layer;
using System;
using System.Collections.Generic;

namespace ModelMainForm.MVP.Model
{
     public class HeardressingSalon
    {        
        public HeardressingSalon ()
        {
            // TODO: паттерн всетаки MVP или MVVM
            dataManager = new DataManager ();    
            claimWorkers = dataManager.GetClaimWorkers();
            services = dataManager.GetServices();
        }
        
        public void RecruitWorker(ClaimWorker newWorker)
        {
                claimWorkers.Add(newWorker);
        }
        public void AddService (Service service)
        {
            services.Add(service);
        }
        public void DeleteWorker(string name)
        {
            foreach (var worker in claimWorkers)
                if (worker.Name == name)
                {
                    claimWorkers.Remove(worker);
                    break;
                }
        }

        public bool IsWorkerExisting(string name)
        {
            foreach (var worker in claimWorkers)
            {
                if (String.Compare(worker.Name, name) == 0)
                    return true;
            }
            return false;
        }
        public bool IsServiceExisting(string name)
        {
            foreach (var service in services)
            {
                if (String.Compare(service.Name, name) == 0)
                    return true;
            }
            return false;
        }

        public List<ClaimWorker> GetClaimWorkers()
        {
            return claimWorkers;
        }
        public List<Service> GetServices()
        {
            return services;
        }


        public void StartSimulation(InputData inputData)
        {
            int nowTime = 0;

            while (nowTime < inputData.EndTime)
            {
                nowTime++;

                if (inputData.WillBeANewRequest(nowTime))
                {

                    var request = new ClientsRequest(nowTime, new Service(Constants.START_SERVICE, 0));
                    Queue.AddAnRequest(request);
                }

                // обработка заявки
                //TODO: использовать инекцию зависимостей для очереди
                for (int id = 0; id < Queue.ClientsRequests().Count; id++)
                {
                    foreach (var claimWorker in claimWorkers)
                        claimWorker.ChangeStatus(nowTime);

                    if (Queue.ClientsRequests()[id].GetTime() == nowTime)
                    {
                        bool IsWorkerDoingWork = false;
                        const int waitingTime = 1;

                        foreach (var claimWorker in claimWorkers)
                        {
                            if (claimWorker.GetStatus() == WorkerStatus.free)
                            {
                                if (claimWorker.IsWorkerHaveServiceThanWork(Queue.ClientsRequests()[id]))
                                {
                                    IsWorkerDoingWork = true;
                                    break;
                                }
                            }
                        }

                        if (!IsWorkerDoingWork)
                            Queue.ClientsRequests()[id].IncreaseTime(waitingTime);
                    }
                }

                foreach (var claimWorker in claimWorkers)
                    claimWorker.CalculateDowntime();
                //удаление
                foreach (var client in Queue.ClientsRequests())// ENDSERVISE
                    if (client.Service.Name == Constants.END_SERVICE)
                    {
                        Queue.ClientsRequests().Remove(client);
                        break;
                    }
            }
        }

        
        public void Serialization()
        {
            dataManager.Serialization(services);
        }
        public void ClearServices()
        {
            dataManager.ClearTheFile();
        }
        
        public void ClearModel()
        {
            Queue.ClientsRequests().Clear();
            foreach (var worker in claimWorkers)
                worker.ClearStatictic();
        }

        private List<ClaimWorker> claimWorkers;
        private List<Service> services;
        private DataManager dataManager;

    }
}
