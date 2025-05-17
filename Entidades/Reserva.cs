using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reserva
    {
         public int Id { get; set; }
            public string NombreCliente { get; set; }
            public DateTime FechaEntrada { get; set; }
            public DateTime FechaSalida { get; set; }
            public int HabitacionId { get; set; }
            public int CantidadPersonas { get; set; }
        }
    }

