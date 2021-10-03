using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class InputTodata
    {
        //สร้างลิสเก็บค่า
        List<Getdata> data = new List<Getdata>();

        Getdata kittinun = new Getdata("kittinun",1234);

        public void addToData()
        {

            data.Add(kittinun);
            
            foreach (Getdata getdata in data){

            Console.WriteLine(getdata.name);

            }

        }

        

    }
}
