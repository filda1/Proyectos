using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSQLSERVER.Views
{
    public interface IInterfaz
    {
        ComboBox ComboBox1Text { get; set; }
        string DateText { get; set; }
        string NDocText { get; set; }
        TextBox numDoc { get; set; }
        DataGridView DataGridText { get; set; }

  
        Button ButtonNewText { get; set; }
        Button ButtonSendText { get; set; }
        Button ButtonDeleteText { get; set; }
        Button ButtonDeleteAllText { get; set; }
        Button ButtonLineText { get; set; }
        Button ButtonPrintText { get; set; }
        


    }
}
