using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class CONGTY
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        public tb_CONGTY getItem(int id)
        {
            return db.tb_CONGTY.FirstOrDefault(x => x.MACTY == id);
        }

        public List<tb_CONGTY> getList()
        {
            return db.tb_CONGTY.ToList();
        }

        public tb_CONGTY Add(tb_CONGTY cty)
        {
            try
            {
                db.tb_CONGTY.Add(cty);
                db.SaveChanges();
                return cty;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_CONGTY Update(tb_CONGTY cty)
        {
            try
            {
                var _cty = db.tb_CONGTY.FirstOrDefault(x => x.MACTY == cty.MACTY);
                _cty.TENCTY = cty.TENCTY;
                _cty.DIENTHOAI = cty.DIENTHOAI;
                _cty.EMAIL = cty.EMAIL;
                _cty.DIACHI = cty.DIACHI;
                db.SaveChanges();
                return cty;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var cty = db.tb_CONGTY.FirstOrDefault(x => x.MACTY == id);
                db.tb_CONGTY.Remove(cty);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
