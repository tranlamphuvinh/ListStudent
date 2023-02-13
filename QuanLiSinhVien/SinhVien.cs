using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLopHoc
{
    public class SinhVien
    {
        public int id;
        public string name;
        public int age;
        public string gender;
        public float score;
        public int Id
        {
            get => id; set => id = value;
        }
        public string Name
        {
            get => name; set => name = value;
        }
        public int Age
        {
            get => age; set => age = value;
        }
        public string Gender
        {
            get => gender; set => gender = value;
        }
        public float Score
        {
            get => score; set => score = value;
        }

    }
}
