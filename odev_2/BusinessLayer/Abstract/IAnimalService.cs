using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnimalService
    {
        List<Animals> GetList();

        void AnimalsAdd(Animals a);

        Animals GetByID(int id);

        void AnimalsDelete(Animals animals);

        void AnimalUpdate(Animals animals);
    }
}
