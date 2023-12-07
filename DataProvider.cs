using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBTLQlyTV
{
    public partial class DataProvider : Component
    {
       

        public DataProvider(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();
        public DataProvider()
        {
            try
            {
                connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYTHUvIEN;Integrated Security=True";
                connection.Open();
            }
            catch { }
        }
        public DataTable loadAccount()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOADACCOUNT";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void addAccount(string USERNAME, string DISPLAYNAME, string PASSWORD, string TYPE)
        {
            SqlCommand command = new SqlCommand("USP_ADD_ACCOUNT", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
            command.Parameters.AddWithValue("@DISPLAYNAME", SqlDbType.NVarChar).Value = DISPLAYNAME;
            command.Parameters.AddWithValue("@PASSWORD", SqlDbType.NVarChar).Value = PASSWORD;
            command.Parameters.AddWithValue("@TYPE", SqlDbType.NVarChar).Value = TYPE;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void delAccount(string USERNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_DEL_ACCOUNT";
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NChar).Value = USERNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void editAccount(string USERNAME, string DISPLAYNAME, string PASSWORD, string TYPE, string where)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_EDIT_ACCOUNT";
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
            command.Parameters.AddWithValue("@DISPLAYNAME", SqlDbType.NVarChar).Value = DISPLAYNAME;
            command.Parameters.AddWithValue("@PASSWORD", SqlDbType.NVarChar).Value = PASSWORD;
            command.Parameters.AddWithValue("@TYPE", SqlDbType.NVarChar).Value = TYPE;
            command.Parameters.AddWithValue("@where_USERNAME", SqlDbType.NVarChar).Value = where;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable loadCustomer()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_CUSTOMER";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void addCustomer(string NAME, string BIRTH, string PHONENUMBER, string ADDRESS)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_ADD_CUSTOMER";
            command.Parameters.AddWithValue("@NAME", SqlDbType.NVarChar).Value = NAME;
            command.Parameters.AddWithValue("@BIRTH", SqlDbType.NVarChar).Value = BIRTH;
            command.Parameters.AddWithValue("@PHONENUMBER", SqlDbType.NVarChar).Value = PHONENUMBER;
            command.Parameters.AddWithValue("@ADDRESS", SqlDbType.NVarChar).Value = ADDRESS;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void delCustomer(string NAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_DEL_CUSTOMER";
            command.Parameters.AddWithValue("@NAME", SqlDbType.NChar).Value = NAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void editCustomer(string NAME, string BIRTH, string PHONENUMBER, string ADDRESS, string where)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_EDIT_CUSTOMER";
            command.Parameters.AddWithValue("@NAME", SqlDbType.NVarChar).Value = NAME;
            command.Parameters.AddWithValue("@BIRTH", SqlDbType.NVarChar).Value = BIRTH;
            command.Parameters.AddWithValue("@PHONENUMBER", SqlDbType.NVarChar).Value = PHONENUMBER;
            command.Parameters.AddWithValue("@ADDRESS", SqlDbType.NVarChar).Value = ADDRESS;
            command.Parameters.AddWithValue("@where_NAME", SqlDbType.NVarChar).Value = where;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable searchCustomer(string NAME)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_SEARCH_CUSTOMER";
            command.Parameters.AddWithValue("@NAME", SqlDbType.NVarChar).Value = NAME;
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public DataTable loadBook()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_BOOK";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void addBook(string BOOKNAME, string RELEASEYEAR, string GENRES, string AUTHOR, string PUBLISHER, string BOOKSELF, string QUANTITY)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_ADD_BOOK";
            command.Parameters.AddWithValue("@BOOKNAME", SqlDbType.NVarChar).Value = BOOKNAME;
            command.Parameters.AddWithValue("@RELEASEYEAR", SqlDbType.NVarChar).Value = RELEASEYEAR;
            command.Parameters.AddWithValue("@GENRES", SqlDbType.NVarChar).Value = GENRES;
            command.Parameters.AddWithValue("@AUTHOR", SqlDbType.NVarChar).Value = AUTHOR;
            command.Parameters.AddWithValue("@PUBLISHER", SqlDbType.NVarChar).Value = PUBLISHER;
            command.Parameters.AddWithValue("@BOOKSELF", SqlDbType.NVarChar).Value = BOOKSELF;
            command.Parameters.AddWithValue("@QUANTITY", SqlDbType.NVarChar).Value = QUANTITY;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void delBook(int ID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_DEL_BOOK";
            command.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void editBook(string BOOKNAME, string RELEASEYEAR, string GENRES, string AUTHOR, string PUBLISHER, string BOOKSELF, string QUANTITY, string where)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_EDIT_BOOK";
            command.Parameters.AddWithValue("@BOOKNAME", SqlDbType.NVarChar).Value = BOOKNAME;
            command.Parameters.AddWithValue("@RELEASEYEAR", SqlDbType.NVarChar).Value = RELEASEYEAR;
            command.Parameters.AddWithValue("@GENRES", SqlDbType.NVarChar).Value = GENRES;
            command.Parameters.AddWithValue("@AUTHOR", SqlDbType.NVarChar).Value = AUTHOR;
            command.Parameters.AddWithValue("@PUBLISHER", SqlDbType.NVarChar).Value = PUBLISHER;
            command.Parameters.AddWithValue("@BOOKSELF", SqlDbType.NVarChar).Value = BOOKSELF;
            command.Parameters.AddWithValue("@QUANTITY", SqlDbType.NVarChar).Value = QUANTITY;
            command.Parameters.AddWithValue("@where_BOOKNAME", SqlDbType.NVarChar).Value = where;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable searchBookByBookName(string BOOKNAME)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_SEARCH_BY_BOOKNAME";
            command.Parameters.AddWithValue("@BOOKNAME", SqlDbType.NVarChar).Value = BOOKNAME;
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable searchBookByGenres(string GENRES)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_SEARCH_BY_GENRES";
            command.Parameters.AddWithValue("@GENRES", SqlDbType.NVarChar).Value = GENRES;
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable searchBookByReleaseYear(string releaseyear)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_SEARCH_BY_YEAR";
            command.Parameters.AddWithValue("@RELEASEYEAR", SqlDbType.NVarChar).Value = releaseyear;
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable searchBookByAuthor(string author)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_SEARCH_BY_AUTHOR";
            command.Parameters.AddWithValue("@AUTHOR", SqlDbType.NVarChar).Value = author;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable searchBookByPublisher(string publisher)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_SEARCH_BY_PUBLISHER";
            command.Parameters.AddWithValue("@PUBLISHER", SqlDbType.NVarChar).Value = publisher;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable searchBookByBookSelf(string bookself)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_SEARCH_BY_BOOKSELF";
            command.Parameters.AddWithValue("@BOOKSELF", SqlDbType.NVarChar).Value = bookself;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable loadCustomerName()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_CUSTOMER_NAME";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable loadBookName()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_BOOK_NAME";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable loadBorrow()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_BORROW";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void addBorrow(string CUSTOMERNAME, string BOOKNAME, string QUANTITY, string BORROWDATE, string PAIDDATE)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_ADD_BOROW";
            command.Parameters.AddWithValue("@CUSTOMERNAME", SqlDbType.NVarChar).Value = CUSTOMERNAME;
            command.Parameters.AddWithValue("@BOOKNAME", SqlDbType.NVarChar).Value = BOOKNAME;
            command.Parameters.AddWithValue("@QUANTITY", SqlDbType.NVarChar).Value = QUANTITY;
            command.Parameters.AddWithValue("@BORROWDATE", SqlDbType.NVarChar).Value = BORROWDATE;
            command.Parameters.AddWithValue("@PAIDDATE", SqlDbType.NVarChar).Value = PAIDDATE;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void delBorrow(string CUSTOMERNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_DEL_BOROW";
            command.Parameters.AddWithValue("@CUSTOMERNAME", SqlDbType.NChar).Value = CUSTOMERNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable loadLatePaid()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_LATEPAID";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void addLatePaid(string CUSTOMERNAME, string BOOKNAME, string QUANTITY, string PAIDDATE, string LATEPAIDDATE, string DAYLATE, string BOOKLATE, string FEE)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_ADD_LATEPAID";
            command.Parameters.AddWithValue("@CUSTOMERNAME", SqlDbType.NVarChar).Value = CUSTOMERNAME;
            command.Parameters.AddWithValue("@BOOKNAME", SqlDbType.NVarChar).Value = BOOKNAME;
            command.Parameters.AddWithValue("@QUANTITY", SqlDbType.NVarChar).Value = QUANTITY;
            command.Parameters.AddWithValue("@PAIDDATE", SqlDbType.NVarChar).Value = PAIDDATE;
            command.Parameters.AddWithValue("@LATEPAIDDATE", SqlDbType.NVarChar).Value = LATEPAIDDATE;
            command.Parameters.AddWithValue("@DAYLATE", SqlDbType.NVarChar).Value = DAYLATE;
            command.Parameters.AddWithValue("@BOOKLATE", SqlDbType.NVarChar).Value = BOOKLATE;
            command.Parameters.AddWithValue("@FEE", SqlDbType.NVarChar).Value = FEE;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void delLatePaid(string CUSTOMERNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_DEL_LATEPAID";
            command.Parameters.AddWithValue("@CUSTOMERNAME", SqlDbType.NChar).Value = CUSTOMERNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable Login(string USERNAME, string PASSWORD)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOGIN";
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
            command.Parameters.AddWithValue("@PASSWORD", SqlDbType.NVarChar).Value = PASSWORD;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable loadGenres()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_GENRES";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void addGenres(string GENRESNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_ADD_GENRES";
            command.Parameters.AddWithValue("@GENRESNAME", SqlDbType.NVarChar).Value = GENRESNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void delGenres(string GENRESNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_DEL_GENRES";
            command.Parameters.AddWithValue("@GENRESNAME", SqlDbType.NVarChar).Value = GENRESNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable loadAuthor()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_AUTHOR";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void addAuthor(string AUTHORNAME, string YEARDATE)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_ADD_AUTHOR";
            command.Parameters.AddWithValue("@AUTHORNAME", SqlDbType.NVarChar).Value = AUTHORNAME;
            command.Parameters.AddWithValue("@YEARDATE", SqlDbType.NVarChar).Value = YEARDATE;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void delAuthor(string AUTHORNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_DEL_AUTHOR";
            command.Parameters.AddWithValue("@AUTHORNAME", SqlDbType.NVarChar).Value = AUTHORNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable loadPublisher()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_ADD_PUBLISHER";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void addPublisher(string PUBLISHERNAME, string ADDRESS, string PHONENUMBER)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_PUBLISHER";
            command.Parameters.AddWithValue("@PUBLISHERNAME", SqlDbType.NVarChar).Value = PUBLISHERNAME;
            command.Parameters.AddWithValue("@ADDRESS", SqlDbType.NVarChar).Value = ADDRESS;
            command.Parameters.AddWithValue("@PHONENUMBER", SqlDbType.NVarChar).Value = PHONENUMBER;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void delPublisher(string PUBLISHERNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_DEL_PUBLISHER";
            command.Parameters.AddWithValue("@PUBLISHERNAME", SqlDbType.NVarChar).Value = PUBLISHERNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable loadBooKSelf()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_LOAD_BOOKSELF";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public void addBookSelf(string BOOKSELFNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_ADD_BOOKSELF";
            command.Parameters.AddWithValue("@BOOKSELFNAME", SqlDbType.NVarChar).Value = BOOKSELFNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void delBookSelf(string BOOKSELFNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "USP_DEL_BOOKSELF";
            command.Parameters.AddWithValue("@BOOKSELFNAME", SqlDbType.NVarChar).Value = BOOKSELFNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
