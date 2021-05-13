using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTableSelenium
{
    class Table
    {
        public List<string> headers;
        public List<List<string>> rows;

        public Table(List<string> headers, List<List<string>> rows)
        {
            this.headers = headers;
            this.rows = rows;
        }
    }
}
