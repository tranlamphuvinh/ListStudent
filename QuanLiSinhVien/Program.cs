using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLiLopHoc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QuanLiSinhVien quanLiSinhVien = new QuanLiSinhVien();
            Console.WriteLine("===============================================================");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|            CHƯƠNG TRÌNH QUẢN LÍ SINH VIÊN                   |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|      - Danh sách các chức năng:                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|      1. Nhập thông tin sinh viên                            |");
            Console.WriteLine("|      2. Xem thông tin sinh viên                             |");
            Console.WriteLine("|      3. Xóa thông tin sinh viên theo id                     |");
            Console.WriteLine("|      4. Tìm sinh viên theo tên                              |");
            Console.WriteLine("|      5. Sắp xếp danh sách sinh viên theo tuổi (Tăng dần)    |");
            Console.WriteLine("|      6. Sắp xếp danh sách sinh viên theo tuổi (Giảm dần)    |");
            Console.WriteLine("|      7. Sắp xếp danh sách sinh viên theo điểm (Tăng dần)    |");
            Console.WriteLine("|      8. Sắp xếp danh sách sinh viên theo điểm (Giảm dần)    |");
            Console.WriteLine("|      9. Tìm sinh viên có điểm trung bình lớn nhất           |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("===============================================================");
            Console.Write("Chọn chức năng bạn muốn thực hiện: ");
            int chucnang = int.Parse(Console.ReadLine());
            char turn;
            do
            {
                switch (chucnang)
                {
                    case 1: // Chức năng nhập thông tin sinh viên
                        Console.WriteLine();
                        Console.Write("Nhập số lượng sinh viên: ");
                        int soSV = int.Parse(Console.ReadLine());
                        for (int i = 0; i < soSV; i++)
                        {
                            Console.WriteLine("Thông tin sinh viên số " + (i + 1));
                            quanLiSinhVien.NhapThongTinSinhVien();
                            Console.WriteLine();
                        }
                        break;
                    case 2: // Chức năng kiểm tra số lượng sinh viên
                        Console.WriteLine();
                        if (quanLiSinhVien.SoLuongSinhVien() > 0)
                        {
                            quanLiSinhVien.HienThiThongTin(quanLiSinhVien.getListSinhVien());
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Danh sách không có sinh viên");
                        }
                        break;
                    case 3: // Chức năng xóa thông tin của 1 sinh viên theo id
                        Console.WriteLine();
                        if (quanLiSinhVien.SoLuongSinhVien() > 0)
                        {
                            int idDelete;
                            Console.Write("Nhập id cần xóa: ");
                            idDelete = int.Parse(Console.ReadLine());
                            if (quanLiSinhVien.XoaSinhVienTheoId(idDelete) == true)
                            {
                                Console.WriteLine("Đã xóa thành công");
                            }
                            else
                            {
                                Console.WriteLine("Không có id để xóa");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sách không có sinh viên");
                        }
; break;
                    case 4: // Chức năng tìm kiếm sinh viên theo tên
                        Console.WriteLine();
                        if (quanLiSinhVien.SoLuongSinhVien() > 0)
                        {
                            string word;
                            Console.Write("Nhập tên cần tìm kiếm");
                            word = Console.ReadLine();
                            List<SinhVien> search = quanLiSinhVien.TimKiemTheoTen(word);
                            quanLiSinhVien.HienThiThongTin(search);
                        }
                        else
                        {
                            Console.WriteLine("Không có sinh viên trong danh sách");
                        }
                        break;
                    case 5: // Chức năng sắp xếp danh sách sinh viên theo tên tăng dần
                        Console.WriteLine();
                        if (quanLiSinhVien.SoLuongSinhVien() > 0)
                        {
                            quanLiSinhVien.SapXepTheoTuoiTangDan();
                            Console.WriteLine("Sắp xếp thành công");
                        }
                        else
                        {
                            Console.WriteLine("Không có sinh viên trong danh sách");
                        }
                        break;
                    case 6: // Chức năng sắp xếp danh sách sinh viên theo tên giảm dần
                        Console.WriteLine();
                        if (quanLiSinhVien.SoLuongSinhVien() > 0)
                        {
                            quanLiSinhVien.SapXepTheoTuoiGiamDan();
                            Console.WriteLine("Sắp xếp thành công");
                        }
                        else
                        {
                            Console.WriteLine("Không có sinh viên trong danh sách");
                        }
                        break;
                    case 7: // Chức năng sắp xếp danh sách sinh viên theo điểm trung bình tăng dần
                        Console.WriteLine();
                        if (quanLiSinhVien.SoLuongSinhVien() > 0)
                        {
                            quanLiSinhVien.SapXepTheoDiemTangDan();
                            Console.WriteLine("Sắp xếp thành công");
                        }
                        else
                        {
                            Console.WriteLine("Không có sinh viên trong danh sách");
                        }
                        break;
                    case 8: // Chức năng sắp xếp danh sách sinh viên theo điểm trung bình giảm dần
                        Console.WriteLine();
                        if (quanLiSinhVien.SoLuongSinhVien() > 0)
                        {
                            quanLiSinhVien.SapXepTheoDiemGiamDan();
                            Console.WriteLine("Sắp xếp thành công");
                        }
                        else
                        {
                            Console.WriteLine("Không có sinh viên trong danh sách");
                        }
                        break;
                    case 9: // Tìm sinh viên có điểm trung bình lớn nhất
                        Console.WriteLine();
                        if (quanLiSinhVien.SoLuongSinhVien() > 0)
                        {
                            SinhVien result = quanLiSinhVien.TimDiemLonNhat();
                            quanLiSinhVien.HienThiThongTin(result);
                        }
                        else
                        {
                            Console.WriteLine("Không có sinh viên trong danh sách");
                        }
                        break;
                    default:
                        Console.WriteLine("Không có chức năng mà bạn muốn. Xin hãy nhập lại. ");
                        break;
                }
                do
                {
                    Console.WriteLine();
                    Console.Write("Bạn có muốn tiếp tục không ? (Chọn c: có; Chọn k: không)   ");
                    turn = char.Parse(Console.ReadLine());
                } while (turn != 'c' && turn != 'C' && turn != 'k' && turn != 'K');
                if (turn == 'c' || turn == 'C') // Nếu chọn c hoặc C thì tiếp tục chương trình
                {
                    Console.Write("Chọn chức năng bạn muốn thực hiện: ");
                }
                if (turn == 'k' || turn == 'K') // Nếu chọn k hay K sẽ kết thúc chương trình
                {
                    break;
                }
                chucnang = int.Parse(Console.ReadLine());
            } while (turn != 'k' || turn != 'K');
            /*
            string dulieunhap = Console.ReadLine();
            string filePath = "D:\\test.txt";
            FileStream fileStream = new FileStream(filePath, FileMode.Append);
            StreamWriter sWriter = new StreamWriter(fileStream, Encoding.UTF8);
            sWriter.WriteLine(dulieunhap);
            sWriter.Flush();
            fileStream.Close(); */
        }
    }
}