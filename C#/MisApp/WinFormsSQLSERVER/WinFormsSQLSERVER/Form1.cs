using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSQLSERVER.Models;
using WinFormsSQLSERVER.Presenters;
using WinFormsSQLSERVER.Views;

namespace WinFormsSQLSERVER
{
    public partial class Form1 : Form, IInterfaz
    {
        PrincipalPresenter p;
        Bitmap bmp;

        // Interface
        public ComboBox ComboBox1Text
        {
            get => comboBox1;
            set => comboBox1.SelectedItem = value;
        }
        public String DateText
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }
        public string NDocText
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public DataGridView DataGridText
        {
            get => dataGridView1;
            set => dataGridView1 = value;
        }
        public Button ButtonNewText {
            get => button1;
            set => button1 = value;

        }

        public Button ButtonSendText
        {
            get => button2;
            set => button2 = value;

        }

        public Button ButtonDeleteText
        {
            get => button3;
            set => button3 = value;

        }

        public Button ButtonDeleteAllText
        {
            get => button4;
            set => button4 = value;

        }

        public Button ButtonLineText
        {
            get => button5;
            set => button5 = value;

        }
        public TextBox numDoc {
            get => textBox1;
            set => textBox1= value;
        }
        public Button ButtonPrintText {
            get => button6;
            set => button6 = value;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("dd .MM . yyyy");
            // textBox2.Text = DateTime.Now.ToShortDateString();
            ColumnsDataGV();


            comboBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            ActiveContrary();
           
      
        }
        // Combox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Value selected
            String valueCombo = comboBox1.SelectedItem.ToString();
            p = new PrincipalPresenter();
            p.ValueComboBox = valueCombo;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Button Principal, nuevo Doc
        private void button1_Click(object sender, EventArgs e)
        {

            p = new PrincipalPresenter(this);
            p.FillCombox();
            p.NumDoc();

            comboBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            // Number Doc, readonly
            textBox1.ReadOnly = true;
            // Date, readonly
            textBox2.ReadOnly = true;

            Active();

            ArrayList row = new ArrayList
            {   "", "",  "" };

            dataGridView1.Rows.Add(row.ToArray());

        }


        // Load ComboxDatagridView
        public void ColumnsDataGV()
        {
            dataGridView1.AllowUserToAddRows = false;  // Not Visible first Rown

            p = new PrincipalPresenter(this);
            DataGridViewComboBoxColumn combo = p.SearchListId();
            this.dataGridView1.Columns.Insert(0, combo);

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "E-Mail";

            dataGridView1.Columns[2].ValueType = typeof(Decimal);


        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
        }

        private void dataGridView1_Enter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {      
        }

        // Enter cell 0 , search and load in (cell 1, Columns 1)
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexCell_0 = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[indexCell_0];
                var valueSearch = selectedRow.Cells[0].Value.ToString();

                p = new PrincipalPresenter(this);
                p.SearchId(valueSearch, indexCell_0);
            }
            catch
            {
                MessageBox.Show("Tem que introduzir o valor");
            }

        }


        // Combox editable y autocomplete in datagridview
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control.GetType() == typeof(DataGridViewComboBoxEditingControl))
            {
                DataGridViewComboBoxEditingControl combo = e.Control as DataGridViewComboBoxEditingControl;
                combo.DropDownStyle = ComboBoxStyle.DropDown;
                combo.Sorted = true;
                combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }

        // New row
        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList row = new ArrayList
            {   "", "",  " " };

            dataGridView1.Rows.Add(row.ToArray());

        }


        // Delete row
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.RowCount == 1)
                {
                    dataGridView1.Rows.Clear();
                    button1.Enabled = true;
                    ActiveContrary();
                    textBox1.Text = "";
                    comboBox1.Items.Clear();
                }

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            catch
            {

                button1.Enabled = true;
                ActiveContrary();
                textBox1.Text = "";
                comboBox1.Items.Clear();
            }



        }

        // Delete datagridView
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            button1.Enabled = true;
            ActiveContrary();
            textBox1.Text = "";
            comboBox1.Items.Clear();
        }

        // Button Enviar
        private void button2_Click(object sender, EventArgs e)
        {
            

            p = new PrincipalPresenter(this);
            p.Process();
          



            /*    Contacts co = new Contacts
                {
                    Company = "Richie2",
                    Email = "Richie2@ hotmail.com",
                    Description = "ccc",
                    Address = "zzxzxzzzz",
                    Location = "PT",
                };

                Tres t = new Tres
                {
                    id = "bbbbb",
                    x1 = "v",
                    x2 = "6",
                    x3 = "r",
                    x10 = "b",
                };

              /*  using (DBConnect db = new DBConnect())
                {

                    /* button1.Enabled = true;
                     ActiveContrary();
                     textBox1.Text = "";
                     comboBox1.Items.Clear();*/

            // db.Tres.Add(t);          
            //db.SaveChanges();

            //if (co.ContactsId== 0)//Insert
            //  db.Contacts.Add(co);
            //  else //Update
            //      db.Entry(co).State = EntityState.Modified;
            //    db.SaveChanges();
            //   }


            //    MessageBox.Show("Submitted Successfully");

        }



        private void Active()
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void ActiveContrary()
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {            
        }


        // Controls the error in cell 2 by being different from decimal
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {
                MessageBox.Show("Tem que inserir um numero valido em Qta. Ej: 2 o 2,0");
            }
        }


        // Print Document, necessary printPreviewDialog1 and  printDocument1
        private void button6_Click(object sender, EventArgs e)
        {
             int height = dataGridView1.Height;
             dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
             bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
             dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
             dataGridView1.Height = height;
             
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }


        // Print Document, necessary printPreviewDialog1 and  printDocument1
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
