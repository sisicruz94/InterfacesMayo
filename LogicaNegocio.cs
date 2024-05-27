using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen5BPJ
{
    public class LogicaNegocio
    {

        /// <summary>
        /// Obtiene una lista completa de contenedores
        /// </summary>
        /// <returns>Devuelve una lista con todos los contenedores</returns>
        public static ObservableCollection<Contenedor> GetAllContenedores()
        {
            ObservableCollection<Contenedor> retValue = new ObservableCollection<Contenedor>();
            retValue.Add(new Contenedor("D0976", 72, 53, "IND"));
            retValue.Add(new Contenedor("X9769", 52, 67, "IND"));
            retValue.Add(new Contenedor("P0966", 74, 75, "FRA"));
            retValue.Add(new Contenedor("D0980", 51, 15, "LIQ"));
            retValue.Add(new Contenedor("F76435", 56, 27, "SOL"));
            retValue.Add(new Contenedor("L7272", 77, 35, "FRA"));
            retValue.Add(new Contenedor("K0962", 153, 46, "LIQ"));
            retValue.Add(new Contenedor("J1021", 12, 46, "SOL"));
            retValue.Add(new Contenedor("A4501", 24, 65, "IND"));
            return retValue;
        }
    }
}
