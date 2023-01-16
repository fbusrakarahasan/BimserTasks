using System.Data;
using System.Data.SqlClient; 
 
public class sqlConnection
{
    private string m_strConnectionString;
    private SqlConnection m_cnnConnection; 
    private sqlConnection m_oConnection;

    private SqlTransaction m_oTransaction;
     
    private SqlConnection Connect2Database()
    {
        SqlConnection cnnConnection = default(SqlConnection);

        if (m_oConnection == null)
        {
            m_oConnection = new sqlConnection();
        }
        cnnConnection = new SqlConnection();

        cnnConnection.ConnectionString = GetConnectionString(); 
        cnnConnection.Open();
        return cnnConnection;
    }

    public SqlConnection DBConnection
    {
        get
        {
            if (m_cnnConnection == null)
            {
                m_cnnConnection = Connect2Database();
            }
            if (m_cnnConnection.State == ConnectionState.Broken | m_cnnConnection.State == ConnectionState.Closed)
            {
                m_cnnConnection = Connect2Database();
            }
            return m_cnnConnection;
        }
        set
        {
            if (value == null)
            {
                if (m_oTransaction == null)
                {
                    if ((m_cnnConnection != null))
                    {
                        if (m_cnnConnection.State == ConnectionState.Open)
                        {
                            m_cnnConnection.Close();
                        }
                        m_cnnConnection.Dispose();
                    }
                }
            }
            m_cnnConnection = value;
        }
    } 
    private string GetConnectionString()
    {
        m_strConnectionString = "server=LAPTOP-35JSQIQ9;Initial Catalog=Rehber;Integrated Security=SSPI";
        return m_strConnectionString;
    }  
}