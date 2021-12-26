using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnimalsManager : IAnimalService
    {

        IAnimalsDal _animalsDal;

        public AnimalsManager(IAnimalsDal animalsDal)
        {
            this._animalsDal = animalsDal;
        }

        public void AnimalsAdd(Animals a)
        {
            _animalsDal.Insert(a);
        }

        public void AnimalsDelete(Animals animals)
        {
            _animalsDal.Delete(animals);
        }

    

        public void AnimalUpdate(Animals animals)
        {
            _animalsDal.Update(animals);
        }

        public Animals GetByID(int id)
        {
            return _animalsDal.Get(x => x.AnimalID == id);
        }

        public List<Animals> GetList()
        {
            return _animalsDal.list();
        }



    }
}
//ctrl + k + d