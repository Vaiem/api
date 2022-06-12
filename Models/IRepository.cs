using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservateAPI.Models
{
    public interface IRepository
    {
        IEnumerable<Resrvation> GetResrvations { get; }

         Resrvation this[ int id] { get; }

        Resrvation AddReservation(Resrvation resrvation);

        Resrvation UpdeteReservation(Resrvation resrvation);

        void Delet(int id);
    }
}
