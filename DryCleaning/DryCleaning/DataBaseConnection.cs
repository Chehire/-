using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DatabaseConnection
{
    const string dataSource = @"DJ-ZENBOOK\IVANOV",  //Имя сервера
                    initialCatalog = "DryCleanig",   //Имя базы данных
                    userID = "sa",         //Имя входа
                    password = "123"; //Пароль входа
    const bool checkSecurity = true; //Проверка подлинности

    public SqlConnection DatabaseSQL()
    {
        var sqlConnection = new SqlConnection($"Data Source = {dataSource}; Initial Catalog = {initialCatalog};" +
        $"Persist Security Info = {checkSecurity}; User ID = {userID}; password = {password}");
        return sqlConnection;
    }


    public DataSet TableFill(string query, SqlConnection sql)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
        var dataSet = new DataSet();
        dataSet.Clear();
        adapter.Fill(dataSet);
        return dataSet;
    }
}
