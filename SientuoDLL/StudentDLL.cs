using Dm;
using SientuoIDLL;
using SienuoModel;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SientuoDLL
{
    public class StudentDLL: IStudentDLL
    {
        //获取学生名字

        public Student GetStudent(string code)
        {
            string sql = $" select * from student where susercode = '{code}'";

            return SqlSugarUtil.SqlSugarClient.SqlQueryable<Student>(sql).First();
        }
    }
}