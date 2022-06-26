using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Car{
    public string name;
    public int price;
    public string color;

    public Car(string name, string color, int price){
        this.color = color;
        this.name = name;
        this.price = price;
    }
    }

class LaptopBase
    {        
        public const string i3 = "i3";
        public const string i5 = "i5";
        public const string i7 = "i7";
        
        public const string Ram4GB = "4GB";
        public const string Ram8GB = "8GB";
 
        public const string HD500GB = "500GB";
        public const string HD1TB = "1TB";
 
        public const string Price1000 = "$1000";
        public const string Price1500 = "$1500";
        public const string Price2000 = "$2000";
 
        public const string Lenove = "Lenovo";
        public const string Sony = "Sony";
        public const string Dell = "Dell";
    }


class laptop{
    // write your method here
}
public class Assignment : MonoBehaviour
{
        // task 1
        string[] names = {"Honda civic","Nano","Tesla Model 3", "Auto"};
        string[] colors = {"yellow","blue","red","grey"};
        int[] prices = {100000, 200000, 2345616, 937392};
        // you have to make list of different objects of the car class and print out each property using foreach loop

        // desired output 
        /*
        Honda civic , yellow, 100000
        Nano, blue, 200000
        Tesla Model 3, red, 2345616
        Auto, grey, 937392
        */
        
        //task2

        //create a laptop class which inherits from LaptopBaseclass and make a method to print several combinations of laptop configurations. A template for the laptop class is given as hint 

        /* sample output : 
            Name : Lenovo
            Price : $1000
            Processor : i3
            Ram : 2GB
            HDD : 500GB
        */
        
    void Start()
    {
        /* write your code between the lines for task1
        -------------------------------------------------------------------------------------------------


        -------------------------------------------------------------------------------------------------
        */

        /*write your code in between the lines and complete the class also for task2
        -------------------------------------------------------------------------------------------------------


        -------------------------------------------------------------------------------------------------------
        */
       
    }

    
}
