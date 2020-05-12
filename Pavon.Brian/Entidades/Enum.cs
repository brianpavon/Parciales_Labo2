using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Enumerado con los tipos de cargos
    /// </summary>
    public enum ECargo
    {
        Porteria = 100,
        Cocina = 110,
        Secretaria = 140,
        Tesoreria = 240,
        Direccion = 180

    }

    /// <summary>
    /// Enumerado con los parentezco entre personas
    /// </summary>
    public enum EParentezco
    {
        Madre,
        Padre,
        Tia,
        Tio,
        Abuela,
        Abuelo,
        Otro
    }

    /// <summary>
    /// Enumerado con los colores que se usaran para aulas y alumnos
    /// </summary>
    public enum EColores
    {
        Naranja,
        Rojo,
        Amarillo,
        Verde
    }

    /// <summary>
    /// Enumerado con los turnos disponibles
    /// </summary>
    public enum ETurno
    {
        Mañana,
        Tarde
    }
    
    
}
