using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp19
{
    public class DB
    {
        static _1125StudentsContext _studentsContext;

        public static _1125StudentsContext GetInstance()
        {
            if (_studentsContext == null)
                _studentsContext = new _1125StudentsContext();
            return _studentsContext;
        }

        private DB()
        {
        }
    }
}
