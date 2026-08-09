using System;
using System.Collections.Generic;
using System.Text;

namespace assimantoop.Classes
{
   

  #region Part02(1)
//public class Shipment
//    {
//        private string trackingCode;
//        private string description;
//        private decimal weight;
//        private decimal deliveryFee;

//        public DeliveryAddress Destination { get; set; }

//        public string TrackingCode
//        {
//            get { return trackingCode; }
//        }

//        public string Description
//        {
//            get { return description; }
//            set
//            {
//                if (!string.IsNullOrWhiteSpace(value))
//                    description = value;
//            }
//        }

//        public decimal Weight
//        {
//            get { return weight; }
//            set
//            {
//                if (value > 0)
//                    weight = value;
//            }
//        }

//        public decimal DeliveryFee
//        {
//            get { return deliveryFee; }
//            private set
//            {
//                if (value > 0)
//                    deliveryFee = value;
//            }
//        }

//        public virtual decimal EstimatedCost
//        {
//            get { return DeliveryFee + (Weight * 5); }
//        }

//        public Shipment(string trackingCode)
//        {
//            this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNKNOWN" : trackingCode;
//            description = "Unknown";
//            weight = 1;
//            deliveryFee = 50;
//            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
//        }

//        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
//        {
//            this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNKNOWN" : trackingCode;
//            this.description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
//            this.weight = weight > 0 ? weight : 1;
//            this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
//            Destination = destination;
//        }

//        public void UpdateDeliveryFee(decimal newFee)
//        {
//            if (newFee > 0)
//                deliveryFee = newFee;
//        }

//        public virtual void PrintShipment()
//        {
//            Console.WriteLine($"Tracking Code : {TrackingCode}");
//            Console.WriteLine($"Description   : {Description}");
//            Console.WriteLine($"Weight        : {Weight} KG");
//            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
//            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
//        }
//    }
        #endregion
}

