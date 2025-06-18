using System;
using System.Collections.Generic;
using System.Linq;

namespace HDH
{
    internal class ChuoiCylinder
    {
        private List<int> danhSachYeuCau;
        private int cylinderHienTai;
        private int tongCylinderDaDoc;
        private List<int> tongTungBuoc;


        #region get, set, khoi tao
        public ChuoiCylinder()
        {
            danhSachYeuCau = new List<int>();
            cylinderHienTai = 0;
            tongCylinderDaDoc = 0;
            tongTungBuoc = new List<int>();
        }

        public List<int> GetDanhSachYeuCau()
        {
            return danhSachYeuCau;
        }

        public void SetDanhSachYeuCau(List<int> value)
        {
            danhSachYeuCau = value;
        }

        public int GetCylinderHienTai()
        {
            return cylinderHienTai;
        }

        public void SetCylinderHienTai(int value)
        {
            cylinderHienTai = value;
        }

        public int GetTongCylinderDaDoc()
        {
            return tongCylinderDaDoc;
        }

        public void SetTongCylinderDaDoc(int value)
        {
            tongCylinderDaDoc = value;
        }

        public List<int> GetTongTungBuoc()
        {
            return tongTungBuoc;
        }
        #endregion

        public List<int> RunFCFS()
        {
            List<int> thuTuDoc = new List<int>();
            List<int> cloneList = new List<int>(danhSachYeuCau);
            int viTriHienTai = cylinderHienTai;
            int tong = 0;
            tongTungBuoc.Clear();
            thuTuDoc.Add(viTriHienTai);

            foreach (int yeuCau in cloneList)
            {
                thuTuDoc.Add(yeuCau);
                tong += Math.Abs(yeuCau - viTriHienTai);
                tongTungBuoc.Add(tong);
                viTriHienTai = yeuCau;
            }

            tongCylinderDaDoc = tong;
            return thuTuDoc;
        }

        public List<int> RunSSTF()
        {
            List<int> thuTuDoc = new List<int>();
            List<int> cloneList = new List<int>(danhSachYeuCau);
            int viTriHienTai = cylinderHienTai;
            int tong = 0;
            tongTungBuoc.Clear();
            thuTuDoc.Add(viTriHienTai);

            while (cloneList.Count > 0)
            {
                int ganNhat = cloneList[0];
                int khoangCachNhoNhat = Math.Abs(ganNhat - viTriHienTai);

                for (int i = 1; i < cloneList.Count; i++)
                {
                    int khoangCach = Math.Abs(cloneList[i] - viTriHienTai);
                    if (khoangCach < khoangCachNhoNhat)
                    {
                        ganNhat = cloneList[i];
                        khoangCachNhoNhat = khoangCach;
                    }
                }

                thuTuDoc.Add(ganNhat);
                tong += khoangCachNhoNhat;
                tongTungBuoc.Add(tong);
                viTriHienTai = ganNhat;
                cloneList.Remove(ganNhat);
            }

            tongCylinderDaDoc = tong;
            return thuTuDoc;
        }

        public List<int> RunSCAN(bool huongVe0, int gioiHan)
        {
            List<int> thuTuDoc = new List<int>();
            List<int> clone = new List<int>(danhSachYeuCau);
            clone.Sort();

            int viTri = cylinderHienTai;
            int tong = 0;
            tongTungBuoc.Clear();
            thuTuDoc.Add(viTri);

            List<int> trai = clone.FindAll(x => x < viTri);
            trai.Reverse(); 
            List<int> phai = clone.FindAll(x => x >= viTri);

            if (huongVe0)
            {
                foreach (int x in trai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }

                if (viTri > 0)
                {
                    thuTuDoc.Add(0);
                    tong += viTri;
                    tongTungBuoc.Add(tong);
                    viTri = 0;
                }

                foreach (int x in phai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }
            }
            else
            {
                foreach (int x in phai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }

                if (viTri < gioiHan)
                {
                    thuTuDoc.Add(gioiHan);
                    tong += Math.Abs(gioiHan - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = gioiHan;
                }

                foreach (int x in trai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }
            }

            tongCylinderDaDoc = tong;
            return thuTuDoc;
        }

        public List<int> RunC_SCAN(bool huongVe0, int gioiHan)
        {
            List<int> thuTuDoc = new List<int>();
            List<int> clone = new List<int>(danhSachYeuCau);
            clone.Sort();

            int viTri = cylinderHienTai;
            int tong = 0;
            tongTungBuoc.Clear();
            thuTuDoc.Add(viTri);

            List<int> trai = clone.FindAll(x => x < viTri);
            trai.Sort(); 
            List<int> phai = clone.FindAll(x => x >= viTri);
            phai.Sort();

            if (!huongVe0)
            {
                foreach (int x in phai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }

                if (viTri < gioiHan)
                {
                    thuTuDoc.Add(gioiHan);
                    tong += Math.Abs(gioiHan - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = gioiHan;
                }

                if (trai.Count > 0)
                {
                    thuTuDoc.Add(0);
                    tongTungBuoc.Add(tong);
                    viTri = 0;

                    foreach (int x in trai)
                    {
                        thuTuDoc.Add(x);
                        tong += Math.Abs(x - viTri);
                        tongTungBuoc.Add(tong);
                        viTri = x;
                    }
                }
            }
            else
            {
                trai.Reverse(); 
                phai.Reverse();
                foreach (int x in trai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }

                if (viTri > 0)
                {
                    thuTuDoc.Add(0);
                    tong += viTri;
                    tongTungBuoc.Add(tong);
                    viTri = 0;
                }

                if (phai.Count > 0)
                {
                    thuTuDoc.Add(gioiHan);
                    tongTungBuoc.Add(tong);
                    viTri = gioiHan;

                    foreach (int x in phai)
                    {
                        thuTuDoc.Add(x);
                        tong += Math.Abs(x - viTri);
                        tongTungBuoc.Add(tong);
                        viTri = x;
                    }
                }
            }

            tongCylinderDaDoc = tong;
            return thuTuDoc;
        }

        public List<int> RunLOOK(bool huongVe0)
        {
            List<int> thuTuDoc = new List<int>();
            List<int> clone = new List<int>(danhSachYeuCau);
            clone.Sort();

            int viTri = cylinderHienTai;
            int tong = 0;
            tongTungBuoc.Clear();
            thuTuDoc.Add(viTri);

            List<int> trai = clone.FindAll(x => x < viTri);
            trai.Reverse();
            List<int> phai = clone.FindAll(x => x >= viTri);

            if (huongVe0)
            {
                foreach (int x in trai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }

                foreach (int x in phai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }
            }
            else
            {
                foreach (int x in phai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }

                foreach (int x in trai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }
            }

            tongCylinderDaDoc = tong;
            return thuTuDoc;
        }

        public List<int> RunC_LOOK(bool huongVe0)
        {
            List<int> thuTuDoc = new List<int>();
            List<int> clone = new List<int>(danhSachYeuCau);
            clone.Sort();

            int viTri = cylinderHienTai;
            int tong = 0;
            tongTungBuoc.Clear();
            thuTuDoc.Add(viTri);

            List<int> trai = clone.FindAll(x => x < viTri);
            trai.Sort();
            List<int> phai = clone.FindAll(x => x >= viTri);
            phai.Sort();

            if (!huongVe0)
            {
                foreach (int x in phai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }

                if (trai.Count > 0)
                {
                    viTri = phai.Last();
                    int quayLai = trai.First();

                    viTri = quayLai;
                    thuTuDoc.Add(viTri);
                    tongTungBuoc.Add(tong);

                    for (int i = 1; i < trai.Count; ++i)
                    {
                        int x = trai[i];
                        thuTuDoc.Add(x);
                        tong += Math.Abs(x - viTri);
                        tongTungBuoc.Add(tong);
                        viTri = x;
                    }
                }
            }
            else
            {
                trai.Reverse();
                phai.Reverse();

                foreach (int x in trai)
                {
                    thuTuDoc.Add(x);
                    tong += Math.Abs(x - viTri);
                    tongTungBuoc.Add(tong);
                    viTri = x;
                }

                if (phai.Count > 0)
                {
                    int quayLai = phai.First();

                    viTri = quayLai;
                    thuTuDoc.Add(viTri);
                    tongTungBuoc.Add(tong);

                    for (int i = 1; i < phai.Count; ++i)
                    {
                        int x = phai[i];
                        thuTuDoc.Add(x);
                        tong += Math.Abs(x - viTri);
                        tongTungBuoc.Add(tong);
                        viTri = x;
                    }
                }
            }

            tongCylinderDaDoc = tong;
            return thuTuDoc;
        }

    }
}