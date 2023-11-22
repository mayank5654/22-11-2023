using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment18
{

    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ConnectionStatus { get; set; }
        public string ChargingStatus { get; set; }
        public string DisplayInfo { get; set; }

        public Laptop(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public bool Connect()
        {
            ConnectionStatus = "Connected";
            return true;
        }

        public void Recharge(int minutes)
        {
            ChargingStatus = $"Charging for {minutes} minutes";
        }

        public string Display()
        {
            DisplayInfo = $"Brand: {Brand}, Model: {Model}, Connection: {ConnectionStatus}, Charging: {ChargingStatus}";
            return DisplayInfo;
        }
    }
}
    

