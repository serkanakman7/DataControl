using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ozkan
{
    public class cPersonelBilgileri
    {

        cGenel gnl = new cGenel();

        #region Fields
        private int _Id;
        private string _Name;
        private string _SurName;
        #endregion
        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string SurName { get => _SurName; set => _SurName = value; } 
        #endregion


    }
}
