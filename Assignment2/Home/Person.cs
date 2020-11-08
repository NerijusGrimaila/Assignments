using System;
using System.Collections.Generic;
using System.Text;

namespace Home
{
    class Person
    {
        public string person;
        public Person(string personName)
        {
            person = personName;
        }
        public void ShowData()
        {
            var house = new House(200);
            var door = new Door("brown");
            var sub = new SubApart(50);

            Console.WriteLine("my name is {0} and i have:", person);
            house.ShowData();
            door.GetDoor();
            sub.ShowData();
            

        }
    }
}
