using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Serializable]
    public class SocketData
    {
        int command;
        object ojb; // Phụ thuộc vào command để biết kiểu dữ liệu.
        public int Command { get => command; set => command = value; }
        public object Ojb { get => ojb; set => ojb = value; }

        public SocketData(int command, object obj)
        {
            this.Command = command;
            this.Ojb = obj;
        }
    }
    public enum SocketCommand
    {
        Exit,
        Sql,
    }
}

