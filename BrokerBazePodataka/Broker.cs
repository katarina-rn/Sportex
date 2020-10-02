using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BrokerBazePodataka
{
    public class Broker
    {
        SqlConnection connection;
        SqlTransaction transaction;

        public static Broker instance;

        public static Broker Instance()
        {
            if (instance == null)
            {
                instance = new Broker();
            }
            return instance;
        }
        
        public void OpenConnection()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=LAPTOP-70EMEF26\SQLEXPRESS;Initial Catalog=Projekat;Integrated Security=True");
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesna konekcija!");
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguce zatvoriti konekciju!");
            }
        }

        public void BeginTransaction()
        {
            try
            {
                transaction = connection.BeginTransaction();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesna transakcija!");
            }
        }

        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesna potvrda transakcije!");
            }
        }

        public void Rollback()
        {
            try
            {
                transaction.Rollback();
            }
            catch (Exception)
            {
                 MessageBox.Show("Neuspesno ponistavanje!");
            }
        }

        public List<IDomenskiObjekat> VratiSve(IDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.Table +odo.Join+odo.OrderBy;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, connection, transaction);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    IDomenskiObjekat pom = odo.napuni(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
        
        public List<IDomenskiObjekat> VratiSveZaUslov(IDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.Table + odo.Join+" WHERE " + odo.SearchWhere+odo.OrderBy;
            SqlDataReader reader = null;
            SqlCommand komanda = new SqlCommand(upit, connection, transaction);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);
                List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    IDomenskiObjekat pom = odo.napuni(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception e)
            {
                //throw e;
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public List<IDomenskiObjekat> VratiGrupisane(IDomenskiObjekat odo)
        {
            string upit = "SELECT "+odo.Select+" FROM " + odo.Table +odo.Join+" WHERE " + odo.SearchWhere + odo.GroupBy + odo.OrderBy;
            SqlDataReader reader = null;
            SqlCommand komanda = new SqlCommand(upit, connection, transaction);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);
                List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    IDomenskiObjekat pom = odo.napuni(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public IDomenskiObjekat VratiZaId(IDomenskiObjekat odo)
        {
            string upitniString = "SELECT * FROM " + odo.Table + odo.Join+" WHERE " + odo.SearchID;
            SqlDataReader reader = null;
            SqlCommand komanda = new SqlCommand(upitniString, connection, transaction);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.napuni(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public IDomenskiObjekat VratiZaUslov(IDomenskiObjekat odo)
        {
            string upitniString = "SELECT *FROM " + odo.Table + odo.Join+ " WHERE " + odo.SearchWhere;
            
            SqlDataReader reader = null;
            SqlCommand komanda = new SqlCommand(upitniString, connection, transaction);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.napuni(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public int Izmeni(IDomenskiObjekat odo)
        {
            string upit = $"UPDATE " + odo.Table + " SET " + odo.UpdateValues + " WHERE " + odo.SearchId;
            SqlCommand komanda = new SqlCommand(upit, connection, transaction);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int Sacuvaj(IDomenskiObjekat odo)
        {
            string upit = @"INSERT INTO " + odo.Table + " "+ odo.InsertValues;
            SqlCommand komanda = new SqlCommand(upit, connection, transaction);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int Obrisi(IDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.Table + " WHERE " + odo.SearchId;
            SqlCommand komanda = new SqlCommand(upit, connection, transaction);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int VratiSifru(IDomenskiObjekat odo)
        {
            string upit = "SELECT MAX(" + odo.ColumnId + ") FROM " + odo.Table;
            SqlCommand komanda = new SqlCommand(upit, connection, transaction);
            try
            {
                int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                return sifra + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
    }
}
