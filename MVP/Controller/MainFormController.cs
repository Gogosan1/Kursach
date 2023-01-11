using ModelMainForm.MVP.Model;
using System;
using System.Collections.Generic;

namespace ModelMainForm.MVP.Controller
{
    public class MainFormController
    {
        public MainFormController(HeardressingSalon salon)
        {
            this.salon = salon;
            workerServices = new List<Service>();
        }
        

        public void AddService (string name, string price)
        {
            var service = new Service(name, Convert.ToInt32(price));

            if (Convert.ToInt32(price) < 0)
                throw new ArgumentException("Цена должна быть больше 0");
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Не введен вид услуги");

            if (salon.IsServiceExisting(name))
                throw new Exception("Ошибка такая услуга существует");
            salon.AddService(service);  
        }

        public void AddServiceToWorker (string name, int price, int time)
        {
            bool serviceExist = false;
            foreach (Service service in workerServices)
                if (service.Name == name)
                    serviceExist = true;
            
            if (!serviceExist)
                workerServices.Add(new Service(name, price, time));
        }

        public void RemoveServiceOfWorker(string name)
        {
            foreach (Service service in workerServices)
                if (service.Name == name)
                {
                    workerServices.Remove(service);
                    break;
                }
        }

        public void AddWorker(string name, string type)
        {
            if (salon.IsWorkerExisting(name))
                throw new Exception("Ошибка такой работник уже существует");
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Не введено имя работника");
            else
            {
                workerServices.Add(new Service(Constants.END_SERVICE, 0, 0));

                if (type == Constants.MASTER_TYPE)
                    salon.RecruitWorker(new Master(name, workerServices));
                if (type == Constants.MANAGER_TYPE)
                {
                    foreach (var service in salon.GetServices())
                        if (!String.Equals(service.Name, Constants.START_SERVICE))
                            workerServices.Add( new Service (service.Name,service.Price));
                 //   добавлять только те сервисы которые есть у работников, или обязывать использовать все сервисы
                    salon.RecruitWorker(new Manager(name, workerServices));
                }
            }
            workerServices.Clear();
        }

        public List<ClaimWorker> ReturnListOfWorkers()
        {
            return salon.GetClaimWorkers();
        }

        public List<Service> ReturnListOfServices()
        {
            return salon.GetServices();
        }

        public List<Service> DynamicRenderingOfDataGrid(string type)
        {
            List<Service> servicesForWorker = new List<Service>();
            var serv = salon.GetServices();

            if (type == Constants.MASTER_TYPE)
                foreach(var service in serv)
                    if(service.Name != Constants.START_SERVICE && service.Name != Constants.END_SERVICE) 
                        servicesForWorker.Add(service);

            if (type == Constants.MANAGER_TYPE)
                foreach (var service in serv)
                    if (service.Name == Constants.START_SERVICE)
                        servicesForWorker.Add(service);

            return servicesForWorker;
        }

        public void StartModel(int time, int amountOfRequestOnHour)
        {
            if (time <= 0)
                throw new Exception("время должно быть больше нуля");
            if (amountOfRequestOnHour <= 0 || amountOfRequestOnHour > 60)
                throw new Exception("задайте количество заявок больше нуля и меньше 60");
            var data = new InputData(time, amountOfRequestOnHour);
            salon.StartSimulation(data);
        }

        public void Serialization()
        {
            salon.Serialization();
        }

        public void ClearServices()
        {
            salon.ClearServices();
        }

        public void DeleteWorker(string name)
        {
            salon.DeleteWorker(name);
        }

        public void ClearSatistics()
        {
            salon.ClearModel();
        }

        private HeardressingSalon salon;
        private List<Service> workerServices;
    }
}
