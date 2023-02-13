using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLopHoc
{
    public class QuanLiSinhVien
    {
        private List<SinhVien> ListSinhVien = null;
        public QuanLiSinhVien()
        {
            ListSinhVien = new List<SinhVien>();
        }
        private int generateID() // Hàm tạo id tự động, tăng dần từ 1
        {
            int max = 1;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                max = ListSinhVien[0].id;
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (max < sv.id)
                    {
                        max = sv.id;
                    }
                }
                max++;
            }
            return max;
        }
        public int SoLuongSinhVien()
        {
            int count = 0;
            if (ListSinhVien != null)
            {
                count = ListSinhVien.Count;
            }
            return count;
        }
        public void NhapThongTinSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.Id = generateID();
            Console.Write("Nhập tên sinh viên: ");
            sv.name = Console.ReadLine();
            do
            {
                Console.Write("Nhập tuổi sinh viên: ");
                sv.age = int.Parse(Console.ReadLine());
                if (sv.age < 17)
                {
                    Console.WriteLine("Tuổi chưa hợp lệ !");
                }
            } while (sv.age < 17);
            Console.Write("Nhập giới tính (Nam hoặc nữ): ");
            sv.gender = Console.ReadLine();
            do
            {
                Console.Write("Nhập điểm trung bình: ");
                sv.score = float.Parse(Console.ReadLine());
                if (sv.score < 0 || sv.score > 10)
                {
                    Console.WriteLine("Điểm chưa hợp lệ !");
                }
            } while (sv.score < 0 || sv.score > 10);

            ListSinhVien.Add(sv);   // Thêm thông tin của một sinh viên vào ListSinhVien
        }
        public void HienThiThongTin()
        {

            if (ListSinhVien != null)
            {
                Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4 5}", "ID", "Họ và Tên", "Tuổi", "Giới tính", "Điểm trung bình");
                if (ListSinhVien != null && ListSinhVien.Count > 0)
                {
                    foreach (SinhVien sv in ListSinhVien)
                    {

                        Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4 5}", sv.id, sv.name, sv.gender, sv.score);
                    }
                }
            }
        }
        public void HienThiThongTin(SinhVien sv) // Hiển thị thông tin của một sinh viên
        {
            Console.WriteLine("ID     Tên         Tuổi     Giới tính        Điểm trung bình");
            Console.WriteLine(sv.id + "     " + sv.name + "          " + sv.age + "       " + sv.gender + "                 " + sv.score);

        }
        public void HienThiThongTin(List<SinhVien> list) // Hiển thị thông tin của danh sách sinh viên
        {
            Console.WriteLine("ID     Tên         Tuổi     Giới tính        Điểm trung bình");
            if (list != null && list.Count > 0)
            {
                if (ListSinhVien != null && ListSinhVien.Count > 0)
                {
                    foreach (SinhVien sv in ListSinhVien)
                    {

                        Console.WriteLine(sv.id + "     " + sv.name + "          " + sv.age + "       " + sv.gender + "                 " + sv.score);
                    }
                }
            }
        }
        public List<SinhVien> getListSinhVien()
        {
            return ListSinhVien;
        }
        public SinhVien TimKiemTheoId(int id)
        {
            SinhVien SearchResult = null;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.id == id)
                    {
                        SearchResult = sv;
                    }
                }
            }
            return SearchResult;
        }
        public List<SinhVien> TimKiemTheoTen(string searchKey)
        {
            List<SinhVien> searchResult = new List<SinhVien>();
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.name.ToUpper().Contains(searchKey.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }
        public bool XoaSinhVienTheoId(int id)
        {
            bool isDelete = false;
            SinhVien sv = TimKiemTheoId(id);
            if (sv != null)
            {
                isDelete = ListSinhVien.Remove(sv);
            }
            return isDelete;

        }
        public void SapXepTheoTuoiTangDan()
        {
            ListSinhVien.Sort(delegate (SinhVien sv2, SinhVien sv1)
            {
                return sv2.age.CompareTo(sv1.age);
            });

        }
        public void SapXepTheoTuoiGiamDan()
        {
            ListSinhVien.Sort(delegate (SinhVien sv2, SinhVien sv1)
            {
                return sv1.age.CompareTo(sv2.age);
            });

        }
        public void SapXepTheoDiemTangDan()
        {
            ListSinhVien.Sort(delegate (SinhVien sv2, SinhVien sv1)
            {
                return sv2.score.CompareTo(sv1.score);
            });
        }
        public void SapXepTheoDiemGiamDan()
        {
            ListSinhVien.Sort(delegate (SinhVien sv2, SinhVien sv1)
            {
                return sv1.score.CompareTo(sv2.score);
            });
        }
        public SinhVien TimDiemLonNhat()
        {
            SinhVien result = null;
            SinhVien sv = ListSinhVien[0];
            double maxScore = ListSinhVien[0].score;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                for (int i = 0; i < ListSinhVien.Count; i++)
                {
                    if (maxScore < ListSinhVien[i].score)
                    {
                        maxScore = ListSinhVien[i].score;
                        sv = ListSinhVien[i];
                    }

                }
            }
            result = sv;
            return result;
        }
    }
}
