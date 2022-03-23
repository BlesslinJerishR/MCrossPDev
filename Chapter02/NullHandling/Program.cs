#nullable enable
using System;

namespace NullHandling{

    class Address{
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine($"This program is working");
            
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; //compile error
            Console.WriteLine($"I am not null : {thisCannotBeNull}");
            
            int? thisCouldBeNull = null;
            Console.WriteLine($"I am Null : {thisCouldBeNull}");
            Console.WriteLine($"I am Null Value : {thisCouldBeNull.GetValueOrDefault()}");

            thisCouldBeNull = 7;
            Console.WriteLine($"I am ( Null ) Changed : {thisCouldBeNull}");
            Console.WriteLine($"I am ( Null ) Changed Value : {thisCouldBeNull.GetValueOrDefault()}");

            var address = new Address();
            address.Building = null;
            address.Street = "Saravana Street";
            address.City = "London";
            address.Region = "South";

            if(thisCouldBeNull != null){
                // int length = thisCouldBeNull.Length; 
            }

            //Errors
            
            // string authorName = null;
            // int x = authorName.Length;
            // int? y = authorName?.Length;

            // var result = authorName?.Length ?? 3;
            // Console.WriteLine($"Result : {result}");
            

        }
    }
}