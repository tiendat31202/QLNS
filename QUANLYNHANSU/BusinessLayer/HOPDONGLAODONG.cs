﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class HOPDONGLAODONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        public tb_HOPDONG getItem(String sohd)
        {
            return db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
        }

        public List<HOPDONG_DTO> getItemFull(String sohd)
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.Where(x => x.SOHD == sohd).ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                string NgayBD = item.NGAYBATDAU.Value.ToString("dd/MM/yyyy");
                hd.NGAYBATDAU = "ngày " + NgayBD.Substring(0, 2) + " tháng " + NgayBD.Substring(3, 2) + " năm " + NgayBD.Substring(6);
                string NgayKT = item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");
                hd.NGAYKETTHUC = "ngày " + NgayKT.Substring(0, 2) + " tháng " + NgayKT.Substring(3, 2) + " năm " + NgayKT.Substring(6);
                string NgayKy = item.NGAYKY.Value.ToString("dd/MM/yyyy");
                hd.NGAYKY = "ngày " + NgayKy.Substring(0, 2) + " tháng " + NgayKy.Substring(3, 2) + " năm " + NgayKy.Substring(6);
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.NOIDUNG = item.NOIDUNG;
                hd.THOIHAN = item.THOIHAN;
                hd.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;

                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.MACTY = item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }

        public List<tb_HOPDONG> getList()
        {
            return db.tb_HOPDONG.ToList();
        }

        public List<HOPDONG_DTO> getListFull()
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = item.NGAYBATDAU.Value.ToString("dd/MM/yyyy");
                hd.NGAYKETTHUC = item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");
                hd.NGAYKY = item.NGAYKY.Value.ToString("dd/MM/yyyy");
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.NOIDUNG = item.NOIDUNG;
                hd.THOIHAN = item.THOIHAN;
                hd.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;

                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATED_BY = item.UPDATED_BY;
                hd.UPDATED_DATE = item.UPDATED_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.MACTY = item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }

        public tb_HOPDONG Add(tb_HOPDONG hd)
        {
            try
            {
                db.tb_HOPDONG.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public tb_HOPDONG Update(tb_HOPDONG hd)
        {
            try
            {
                var _hd = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == hd.SOHD);
                _hd.NGAYBATDAU = hd.NGAYBATDAU;
                _hd.NGAYKETTHUC = hd.NGAYKETTHUC;
                _hd.MANV = hd.MANV;
                _hd.NGAYKY = hd.NGAYKY;
                _hd.LANKY = hd.LANKY;
                _hd.HESOLUONG = hd.HESOLUONG;
                _hd.NOIDUNG = hd.NOIDUNG;
                _hd.THOIHAN = hd.THOIHAN;
                _hd.SOHD = hd.SOHD;
                _hd.MACTY = hd.MACTY;
                _hd.UPDATED_BY = hd.UPDATED_BY;
                _hd.UPDATED_DATE = hd.UPDATED_DATE;

                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(String sohd, int manv)
        {
            var _hd = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
            _hd.DELETED_BY = manv;
            _hd.DELETED_DATE = DateTime.Now;
            db.SaveChanges();
        }

        public string MaxSoHopDong()
        {
            var _hd = db.tb_HOPDONG.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOHD;
            }
            else
            {
                return "00000";
            }
        }
    }
}
