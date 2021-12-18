using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangriaHealthCenter
{
    class DisplayDataGridView
    {
        private MySqlConnection _cnn;
        private String _query;
        public DisplayDataGridView(MySqlConnection cnn, String query)
        {
            _cnn = cnn;
            _query = query;
 
        }

    }
}



