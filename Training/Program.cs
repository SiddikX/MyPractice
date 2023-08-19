using Training;

string connectionString = "Server=DESKTOP-353N469\\SQLEXPRESS;Database=CSharpB14;User Id=csharplogin;Password=123456;TrustServerCertificate=True";
DataUtility dataUtility = new DataUtility(connectionString);
/*string sql = "delete from courses where name = 'Laravel';";
dataUtility.ExecuteSql(sql);*/

string query = "select * from courses";
IList<Dictionary<string, object>> data = dataUtility.ReadData(query);

foreach (Dictionary<string, object> item in data)
{
    Console.WriteLine($"ID: {item["Id"]}, Name: {item["Name"]}, Fees: {item["Fees"]}, Date: {item["ClassStartDate"]}");
}
