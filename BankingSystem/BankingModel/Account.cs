using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class Account
    {
        //variables de instancia
        private string _name;
        //creacion de los metodos set y get
        public string getName()
        {
            return _name;
        }
        public void setName(string name)
        {
            //_ como el this pero no es this
            _name = name;
        }
    }
}
