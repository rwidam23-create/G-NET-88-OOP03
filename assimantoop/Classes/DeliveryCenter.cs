using System;
using System.Collections.Generic;
using System.Text;

namespace assimantoop.Classes
{
   

    //public class DeliveryCenter
    //{
    //    private Shipment[] shipments;

        #region Part02(3)
      //public string CenterName { get; set; }

        //public DeliveryCenter(string centerName)
        //{
        //    CenterName = centerName;
        //    shipments = new Shipment[20];
        //}

        //public Shipment this[int index]
        //{
        //    get
        //    {
        //        if (index < 0 || index >= shipments.Length)
        //            return null;
        //        return shipments[index];
        //    }
        //    set
        //    {
        //        if (index < 0 || index >= shipments.Length)
        //            return;
        //        shipments[index] = value;
        //    }
        //}

        //public Shipment this[string trackingCode]
        //{
        //    get
        //    {
        //        foreach (var shipment in shipments)
        //        {
        //            if (shipment != null && shipment.TrackingCode == trackingCode)
        //                return shipment;
        //        }
        //        return null;
        //    }
        //}

        //public bool AddShipment(Shipment shipment)
        //{
        //    for (int i = 0; i < shipments.Length; i++)
        //    {
        //        if (shipments[i] == null)
        //        {
        //            shipments[i] = shipment;
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        #endregion

        #region Part02(3)
        //public bool RemoveShipment(string trackingCode)
        //{
        //    for (int i = 0; i < shipments.Length; i++)
        //    {
        //        if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
        //        {
        //            shipments[i] = null;
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        #endregion

        #region Part02(3)
        //public void PrintAllShipments()
        //{
        //    Console.WriteLine("=====================================");
        //    Console.WriteLine($"Delivery Center : {CenterName}");
        //    Console.WriteLine("=====================================");

        //    foreach (var shipment in shipments)
        //    {
        //        if (shipment != null)
        //        {
        //            shipment.PrintShipment();
        //            Console.WriteLine("-------------------------------------");
        //        }
        //    }
        //}
        #endregion
    }
}
