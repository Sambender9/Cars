using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsDotNet.Models
{
    public abstract class Cars
    {
        int speed = 0;
        public string Company { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }

        public Cars (string company, string type, string color, string wheels) 
        {
            this.Company = company;
            this.Type = type;
            this.Color = color;
            this.Wheels = 4;
        }
        protected Cars()
        {

        }
        public int accelerate() 
        {
            return speed += 5;
        }
        public int decelerate()
        {
            return speed -= 5;
        }
        public string turnLeft()
        {
            return "turn left";
        }
        public string turnRight()
        {
            return "turn right";
        }
    }
    public class BMW : Cars
    {
        int speed = 60;
        public string Company{get; set;}
        public string Type {get; set;}
        public string Color {get; set;}
        //public int Speed {get; set;}

        public BMW (string company, string type, string color)//,int speed
        {
            this.Company = "BMW";
            this.Type = type;
            this.Color = color;
            //this.Speed = 60;
        }
        protected virtual string sportMode() 
        {
            return "You're now in Sport Mode";
        }
        //public static whosFaster() 
        //{
        //    if (BMW.speed > Mercedes.speed) 
        //    {
        //        return BMW.speed;
        //    }
        //    else 
        //    {
        //        return Mercedes.speed;
        //    }
        //}
    }
    public class Mercedes : Cars
    {
        //int speed = 65;
        public string Company { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        //public int Speed {get; set;}

        public Mercedes(string company, string type, string color)//,int speed
        {
            this.Company = "Mercedes";
            this.Type = type;
            this.Color = color;
            //this.Speed = 65;
        }
        public string v12()
        {
            return "My engine is a V12!!!";
        }
    }
    public class Lexus : Cars
    {
        int speed = 45;
        public string Company { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Lexus(string company, string type, string color)
        {
            this.Company = "Lexus";
            this.Type = type;
            this.Color = color;
        }
        public string bio()
        {
            return "Im a nice car but not as a nice as a Mercedes!!";
        }
    }
    public class Maybach : Cars
    {
        int speed = 85;
        public string Company { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Maybach(string company, string type, string color)
        {
            this.Company = "Maybach";
            this.Type = type;
            this.Color = color;
        }
        public string luxury()
        {
            return "I'm the nicest car money can buy!!!";
        }
    }
    public class Audi : Cars
    {
        int speed = 45;
        public string Company { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Audi(string company, string type, string color)
        {
            this.Company = "Audi";
            this.Type = type;
            this.Color = color;
        }
        public string audiBio()
        {
            return "Vroom Vroom party starter!!!";
        }
    }
}