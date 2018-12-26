using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSQLSERVER.Models;
using WinFormsSQLSERVER.Views;

namespace WinFormsSQLSERVER.Presenters
{
    public class PrincipalPresenter
    {
        #region Var
        private  IInterfaz view;
        private  DbConsultation query;
        #endregion

        #region Properties
        public string ValueComboBox { get; set; }
        //public string ValueTextBox { get; set; }

        public string Year = DateTime.Now.Year.ToString();
        public string Date = DateTime.Now.ToShortDateString();
        public DateTime Today = DateTime.Now;


        #endregion


        #region  Constructor
        public PrincipalPresenter(IInterfaz screen)
        {
            view = screen;
        }

        public PrincipalPresenter()
        {
         
        }

        #endregion

        #region Methods

        // Send to database
        public void Process()
        {
            query = new DbConsultation();

            // Count empty in Cells2 of datagridView
            int C = 0;
            for (int i = 0; i < view.DataGridText.Rows.Count; i++)
            {
               // view.DataGridText[2, i].Value = 0;
                var xx = view.DataGridText.Rows[i].Cells[2].Value.ToString();
                 
                if (String.IsNullOrEmpty(xx))
                {
                    C = C + 1;
                }

             
            }

            //MessageBox.Show("Contador, Line" + " " + C);

            // Check if Cell 2 is empty or full
            // Main part, Compare with the counter if cell 2 of the DatagridView is empty or full. 
            // Counter = 0 (full Cell 2 ) and Counter != 0 ( some empty cell 2).  

         if ( C != 0 )
         {
             
                        MessageBox.Show("Tem que inserir a Qta (Cantidade) em tabela");
         }

         else
         {     

            // Validate the combox  if it has selected value
            var entities = view.ComboBox1Text.Text;
            if (String.IsNullOrEmpty(entities))
            {
                MessageBox.Show("Tem selecionar uma entidade");
            }
            else
            {

           
                try
            {
              
                // Insert in database, head of form 
           
                var nDocumento = view.numDoc.Text;
                var dates = Year;


                Users co = new Users
                {
                    TypeofUserId = 1,
                    FirstName = "dq",
                    LastName = nDocumento,
                    Email = "www@vvv.com",
                    Telephone = "12334",
                    Address = dates,
                    Location = "VVV",
                
                };


                query.Add2(co);
                     

                // Insert in database , all of datagridView
                var count = view.DataGridText.Rows.Count;
                Tres[] miObj = new Tres[count];
           
                for (int i = 0; i < view.DataGridText.Rows.Count; i++)
                 {

                    var n = i.ToString();

                    var uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");
                    var id = uid;

                    string cell1 = view.DataGridText.Rows[i].Cells[0].Value.ToString();

                   //string cell2 = view.DataGridText.Rows[i].Cells[1].Value.ToString();    ===========> no funciona por del email es unico en BD y no puede repetir, que despues es guardado en otra tabala
                 
                    var obj = query.GetId(cell1);
                    var cell2 = obj.Description;
        
                   var  cell3 = view.DataGridText.Rows[i].Cells[2].Value.ToString();
              

                       
                        miObj[i] = new Tres
                    {
                        id = id,
                        x1 = cell3,
                        x2 = cell1,
                        x3 = cell2,
                        x4 = "x" +" "+ n,
                    };

                    query.Add(miObj[i], n);
                   
                }

                // Clean and Enable , textbox, datagridview and button
                    view.DataGridText.Rows.Clear();
                    view.ButtonNewText.Enabled = true;
                    view.ButtonSendText.Enabled = false;
                    view.ButtonDeleteText.Enabled = false;
                    view.ButtonDeleteAllText.Enabled = false;
                    view.ButtonLineText.Enabled = false;
                    view.ButtonPrintText.Enabled = false;

                    view.numDoc.Text ="";
                    view.ComboBox1Text.Text = "";
                    view.ComboBox1Text.Items.Clear();

            }
                
                catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
         }

        }
       }

        // Load ComboBox
        public async Task FillCombox()
        {
            //view.DateText = Date; // Load Date
          view.ComboBox1Text.Sorted = true;

          query = new DbConsultation();
            var ListComboBox = query.GetAllComboBox();

            foreach (var item in ListComboBox)
            {
                view.ComboBox1Text.Items.Add(item.FirstName);
              
            }
        }

        // Add to textbox num doc
        public  async Task NumDoc()
        {
            query = new DbConsultation();
            var max = query.GetMax();

            if (String.IsNullOrEmpty(max))
            {
            
                view.NDocText = "1";
            }
            else
            {
                var num = Int32.Parse(max);
                var num1 = ++num;
                var maxString = num1.ToString();
                view.NDocText = maxString;

            }                   
        }

        // Add Name columns and data combox to DatagridView
        public void ColumnsDataGV()
        {   
            view.DataGridText.ColumnCount = 3;
            //view.DataGridText.Columns[0].Name = "Id";
            view.DataGridText.Columns[1].Name = "Name";
            view.DataGridText.Columns[2].Name = "E-Mail";       

        }


        // Search id in Database and add  Row of id for comboxDatagridview
        public DataGridViewComboBoxColumn SearchListId()
        {
            query = new DbConsultation();
            var ListCD = query.GetComboBoxDataGrid();

            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Year Won";
            combo.Name = "combo";

            foreach (var item in ListCD)
            {
                combo.Items.Add(item.Company);
                
            }

            return combo;

        }

        // Search id and Load dataGridViem (Cell 1, columns 1)
        public void SearchId(string x, int n)
        {
            var valueSearch = x;
            int index = n;

            try
            {
           
                if (string.IsNullOrEmpty(valueSearch))
                {
                    MessageBox.Show("Vacio");
                }


                query = new DbConsultation();
                var obj = query.GetId(valueSearch);
                var objName = obj.Email;

                view.DataGridText[1, index].ReadOnly = true;
                view.DataGridText[1, index].Value = objName;

          
            }
            catch
            {
                MessageBox.Show("No existe");
            }
        }

        #endregion

    }
}
