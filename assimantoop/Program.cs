namespace assimantoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            #region(a)
            ////class:Reference Type /stored in Heap/2ref=>same abject/complex/support All types of OOP
            ////Struct:Value Type/stored in stack/copies the value/simple/support Encapsulation
            #endregion
            #region(b)
            ////Classes support encapsulation, inheritance, and polymorphism, making them ideal for complex
            ////evolving systems with shared behavior.
            //// but struct support Encapsulation only
            #endregion
            #endregion

            #region Question02
            #region(a)
            //Shipment
            #endregion
            #region(b)
            //Expressshipmant
            #endregion
            #region(c)
            //TrackingCode
            #endregion
            #region(d)
            //don't repeat code
            //Maintainability
            #endregion
            #endregion


            #region Part02(5)
           
            
                //Console.Write("Enter Delivery Center Name: ");
                //string centerName = Console.ReadLine();

                //DeliveryCenter center = new DeliveryCenter(centerName);

                //StandardShipment standard = ReadStandardShipment();
                //ExpressShipment express = ReadExpressShipment();
                //InternationalShipment international = ReadInternationalShipment();

            //    Console.WriteLine(center.AddShipment(standard) ? "Shipment Added Successfully." : "Delivery center is full.");
            //    Console.WriteLine(center.AddShipment(express) ? "Shipment Added Successfully." : "Delivery center is full.");
            //    Console.WriteLine(center.AddShipment(international) ? "Shipment Added Successfully." : "Delivery center is full.");

            //    Console.WriteLine();
            //    center.PrintAllShipments();

            //    SearchShipment(center);
            //    RemoveShipmentFromCenter(center);

            //    Console.WriteLine();
            //    Console.WriteLine("--- Remaining Shipments ---");
            //    center.PrintAllShipments();
            //}
            #endregion

            #region Part02(5)
            ////static StandardShipment ReadStandardShipment()
            ////{
            ////    Console.Write("Standard - Tracking Code: ");
            ////    string code = Console.ReadLine();
            ////    Console.Write("Standard - Description: ");
            ////    string desc = Console.ReadLine();
            ////    Console.Write("Standard - Weight: ");
            ////    decimal weight = decimal.Parse(Console.ReadLine());
            ////    Console.Write("Standard - Delivery Fee: ");
            ////    decimal fee = decimal.Parse(Console.ReadLine());

            ////    return new StandardShipment(code, desc, weight, fee, new DeliveryAddress("Cairo", "Tahrir St", 1));
            ////}

            //static ExpressShipment ReadExpressShipment()
            //{
            //    Console.Write("Express - Tracking Code: ");
            //    string code = Console.ReadLine();
            //    Console.Write("Express - Description: ");
            //    string desc = Console.ReadLine();
            //    Console.Write("Express - Weight: ");
            //    decimal weight = decimal.Parse(Console.ReadLine());
            //    Console.Write("Express - Delivery Fee: ");
            //    decimal fee = decimal.Parse(Console.ReadLine());
            //    Console.Write("Express - Extra Fee: ");
            //    decimal extraFee = decimal.Parse(Console.ReadLine());

            //    return new ExpressShipment(code, desc, weight, fee, new DeliveryAddress("Giza", "Haram St", 5), extraFee);
            //}

            //static InternationalShipment ReadInternationalShipment()
            //{
            //    Console.Write("International - Tracking Code: ");
            //    string code = Console.ReadLine();
            //    Console.Write("International - Description: ");
            //    string desc = Console.ReadLine();
            //    Console.Write("International - Weight: ");
            //    decimal weight = decimal.Parse(Console.ReadLine());
            //    Console.Write("International - Delivery Fee: ");
            //    decimal fee = decimal.Parse(Console.ReadLine());
            //    Console.Write("International - Destination Country: ");
            //    string destCountry = Console.ReadLine();
            //    Console.Write("International - Customs Fee: ");
            //    decimal customsFee = decimal.Parse(Console.ReadLine());

            //    return new InternationalShipment(code, desc, weight, fee, new DeliveryAddress("Berlin", "Main St", 10), destCountry, customsFee);
            //}
            #endregion

            #region Part02(5)
            //static void SearchShipment(DeliveryCenter center)
            //{
            //    Console.Write("Enter a tracking code to search: ");
            //    string searchCode = Console.ReadLine();
            //    Shipment found = center[searchCode];
            //    Console.WriteLine(found != null ? $"Shipment found: {found.TrackingCode} - {found.Description}" : "Shipment not found.");
            //}

            //static void RemoveShipmentFromCenter(DeliveryCenter center)
            //{
            //    Console.Write("Enter a tracking code to remove: ");
            //    string removeCode = Console.ReadLine();
            //    Console.WriteLine(center.RemoveShipment(removeCode) ? "Shipment removed successfully." : "Shipment not found.");
            //}
            #endregion
        }
    }
    

