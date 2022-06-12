using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservateAPI.Models
{
    public class Repository : IRepository
    {
        private Dictionary<int, Resrvation> AllReservation;

        public Repository()
        {
            AllReservation = new Dictionary<int, Resrvation>();
            new List<Resrvation>{
            
                new Resrvation{ AutoNumber = "A288AA99",ClientName = "Sasha"},
                new Resrvation{ AutoNumber = "A919AA77",ClientName = "Maks"},
                new Resrvation{ AutoNumber = "A123AA55",ClientName="Misha"}
            }.ForEach(o => AddReservation(o));
         
        }

        public Resrvation this[int id] => AllReservation.ContainsKey(id)? AllReservation[id] : null;
        

        public IEnumerable<Resrvation> GetResrvations => AllReservation.Values;

        public Resrvation AddReservation(Resrvation resrvation)
        {
            if (resrvation.ReservationId==0)
            {
                var id = AllReservation.Count();
                while (AllReservation.ContainsKey(id))
                {
                    id++;
                }
                resrvation.ReservationId = id;
                AllReservation[id] = resrvation;
            }
             
            AllReservation[resrvation.ReservationId] = resrvation;
            return resrvation;
        }

        public Resrvation UpdeteReservation(Resrvation resrvation) => AddReservation(resrvation);
            

        public void Delet(int id) => AllReservation.Remove(id);
    
      
    }
}
