﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OgamaDao.Model.Rta;

namespace OgamaDao.Dao.Rta
{
    public class RtaEventDao : OgamaDao.Dao.BaseDaoHibernate<RtaEvent>
    {
        public List<RtaEvent> findAll()
        {
            List<RtaEvent> list = new List<RtaEvent>();
            IList<RtaEvent> findings = find(new RtaEvent());
            foreach (RtaEvent item in findings)
            {
                list.Add(item);
            }

            return list;
        }
    }


}