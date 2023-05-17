using EFC_02.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02.Iservices
{
    public enum ErrorType
    {
        MonAnDaTonTai,
        MonAnChuaTonTai,
        ThanhCong,
    }
   
    public class Error
    {
        public static void log(ErrorType type)
        {
            switch(type)
            {
                case ErrorType.MonAnDaTonTai:
                    Console.WriteLine("mon an da ton tai");
                    break;
                case ErrorType.MonAnChuaTonTai:
                    Console.WriteLine("mon an chua ton tai");
                    break;
                case ErrorType.ThanhCong:
                    Console.WriteLine("thanh cong");
                    break;
            }
        }

        
    }
}
