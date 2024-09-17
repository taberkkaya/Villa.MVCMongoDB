﻿using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class QuestManager : GenericManager<Quest>
    {
        public QuestManager(IGenericDal<Quest> genericDal) : base(genericDal)
        {
        }
    }
}
