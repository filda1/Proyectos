using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSQLSERVER.Models
{
    public class DbConsultation
    {
         List<Users> Items;
         List<Contacts> Items2;
          Contacts conta;

        String numString;

        // Get All, List for ComboBox 
        public  List<Users>GetAllComboBox()
        {
            Items = new List<Users>();
            using (DBConnect db = new DBConnect())
            {

                Items = db.Users.ToList<Users>();

            }

            return Items;
        }


        // GetMax
        public string GetMax ()
        {
          
            using (DBConnect db = new DBConnect())
            {

                var rept_max = (from c in db.Users
                                where c.TypeofUserId == 2 && c.UserId == 36
                                select c).Max(c => c.UserId);

                numString = rept_max.ToString();

            }

            return numString;
        }

        // Search value  in database for combox dataGridview
        public List<Contacts> GetComboBoxDataGrid()
        {
            Items2 = new List<Contacts>();
            using (DBConnect db = new DBConnect())
            {

                Items2 = db.Contacts.ToList<Contacts>();

            }

            return Items2;
        }



        // Search id in database for load in (Cell 1, Colummns1)
        public Contacts GetId(String y)
        {
            var valueS = y;
       
            using (DBConnect db = new DBConnect())
            {
                
               conta= db.Contacts.First(p => p.Company == valueS);


            }

            return conta;
           
        }


        // Insert obj en rown with Id in database
        public void AddId(Users model)
        {

            using (DBConnect db = new DBConnect())
            {

                 if (model.UserId== 0)//Insert
                      db.Users.Add(model);
                 else //Update
                     db.Entry(model).State = EntityState.Modified;
                  db.SaveChanges();
            }


            MessageBox.Show("Submitted Successfully");
        }


        // Insert obj en rown in database
        public void Add(Tres model, string n)
        {

            try
            {
                using (DBConnect db = new DBConnect())
                {

                    db.Tres.Add(model);
                    db.SaveChanges();

                  /*  if (model.id != null)//Insert
                        db.Tres.Add(model);
                    else //Update
                        db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();*/



                    MessageBox.Show("Successfully"+"," +"Line"+ " "+ n);

                }

            }catch
            {
                MessageBox.Show("Error" + "," + "Line" + " " + n);
            }

        }

        // Insert obj en rown in database
        public void Add2(Users model)
        {

       //   try
          {
                using (DBConnect db = new DBConnect())
                {

                    db.Users.Add(model);
                    db.SaveChanges();


                    MessageBox.Show("Successfully head");
                     
                }

        //  }
        //   catch
       //  {
        //       MessageBox.Show("Error in head" );
         }

        }
    }

    
}
