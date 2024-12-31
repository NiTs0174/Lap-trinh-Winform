using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CauThuBUS
    {
        public List<CAUTHU> GetAll()
        {
            Model1 context = new Model1();
            return context.CAUTHUs.ToList();
        }
    }
}
