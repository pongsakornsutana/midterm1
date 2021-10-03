using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Getdata {
        public string name;
        public int password;
        public string bookid;
        public string bookname;

        public Getdata(string valueName, int valuePassword,string valueBookLD,string valueBookname){

            name = valueName;
            password = valuePassword;
            bookid = valueBookLD;
            bookname = valueBookname;
        }
    }
}
