using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesMVVM
{
    class SuperheroeService
    {
        public ObservableCollection<Superheroe> ObtenerHeroes() 
        {
            return Superheroe.GetSamples();
        }
    }
}
