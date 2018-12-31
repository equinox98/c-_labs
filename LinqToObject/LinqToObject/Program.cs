using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.SetWindowSize(213, 50);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDb;Initial Catalog=SeaTransfers;Integrated Security=True";
            string sqlExpressionShips = "SELECT * FROM ship_tb",
                   sqlExpressionGoods = "SELECT * FROM goods_tb",
                   sqlExpressionCustomers = "SELECT * FROM customer_tb",
                   sqlExpressionPorts = "SELECT * FROM port_tb";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Подключение открыто");
              
                List<SqlDataAdapter> adapterlist = new List<SqlDataAdapter>()
                {
                    new SqlDataAdapter(sqlExpressionShips, connection),
                    new SqlDataAdapter(sqlExpressionGoods,connection),
                    new SqlDataAdapter(sqlExpressionCustomers,connection),
                    new SqlDataAdapter(sqlExpressionPorts,connection)

                };
                int caseSwitch,actionSwitch;
                do
                {
                    Console.Write("Выберите таблицу: \nТаблица Кораблей:1\nТаблица Продукции:2\nТаблица Заказчиков:3\nТаблица Портов:4\nВыход:0\n");
                    caseSwitch = Convert.ToInt32(Console.ReadLine());
                    switch (caseSwitch)
                    {
                        case 1:
                            do
                            {
                                Console.Write("Выберите действие: \nПоказать таблицу:1\nДобавить:2\nУдалить:3\nИзменить:4\nОтмена:0\n");
                                actionSwitch = Convert.ToInt32(Console.ReadLine());
                                DataSet dataSet = new DataSet();
                                adapterlist[0].Fill(dataSet);
                                if (actionSwitch == 1)
                                {
                                    

                                    foreach (DataTable dataTable in dataSet.Tables)
                                    {
                                        Console.WriteLine(dataTable.TableName); // название таблицы
                                                                                // перебор всех столбцов
                                        foreach (DataColumn column in dataTable.Columns)
                                            Console.Write("\t{0}", column.ColumnName);
                                        Console.WriteLine();
                                        // перебор всех строк таблицы
                                        foreach (DataRow row in dataTable.Rows)
                                        {
                                            // получаем все ячейки строки
                                            var cells = row.ItemArray;
                                            foreach (object cell in cells)
                                                Console.Write("\t{0}", cell);
                                            Console.WriteLine();
                                        }
                                    }
                                }
                                else if (actionSwitch == 2)
                                {
                                    DataTable dataTable = dataSet.Tables[0];
                                    // добавим новую строку
                                    DataRow newRow = dataTable.NewRow();
                                    Console.WriteLine("Введите id корабля");       
                                    newRow["idShip"] = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите имя корабля");
                                    newRow["name"] = Console.ReadLine();
                                    Console.WriteLine("Введите id порта");
                                    newRow["idPort"] = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите имя капитана");
                                    newRow["capitan"] = Console.ReadLine();
                                    Console.WriteLine("Введите кол-во команды");
                                    newRow["peopleValue"] = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите id товаров");
                                    newRow["idGoods"] = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите грузоподъемность");
                                    newRow["roominessValue"] = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите дату создания год,месяц,день");
                                    int year = Convert.ToInt32(Console.ReadLine());
                                    int month = Convert.ToInt32(Console.ReadLine());
                                    int day = Convert.ToInt32(Console.ReadLine());
                                    newRow["creationDate"] = new DateTime(year,month,day);
                                    Console.WriteLine("Введите дату последнего ремонта год,месяц,день");
                                    int yearRepair = Convert.ToInt32(Console.ReadLine());
                                    int monthRepair = Convert.ToInt32(Console.ReadLine());
                                    int dayRepair = Convert.ToInt32(Console.ReadLine());
                                    newRow["repairDate"] = new DateTime(yearRepair, monthRepair, dayRepair);
                                   
                                    dataTable.Rows.Add(newRow);

                                    // создаем объект SqlCommandBuilder
                                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapterlist[0]);
                                    adapterlist[0].Update(dataSet);  
                                    
                                    // очищаем полностью DataSet
                                    dataSet.Clear();
                                    // перезагружаем данные
                                    adapterlist[0].Fill(dataSet);
                                }
                                else if (actionSwitch == 3)
                                {
                                   
                                }
                                else if (actionSwitch == 4)
                                {

                                }
                                else if (actionSwitch == 0)
                                {
                                    break;
                                }

                            } while (actionSwitch!=0);
                            
                            break;
                        case 2:
                            DataSet dataSecondSet = new DataSet();
                            adapterlist[1].Fill(dataSecondSet);

                            foreach (DataTable dataTable in dataSecondSet.Tables)
                            {
                                Console.WriteLine(dataTable.TableName); // название таблицы
                                                                        // перебор всех столбцов
                                foreach (DataColumn column in dataTable.Columns)
                                    Console.Write("\t{0}", column.ColumnName);
                                Console.WriteLine();
                                // перебор всех строк таблицы
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    // получаем все ячейки строки
                                    var cells = row.ItemArray;
                                    foreach (object cell in cells)
                                        Console.Write("\t{0}\t", cell);
                                    Console.WriteLine();
                                }
                            }
                            break;
                        case 3:
                            DataSet dataThirdSet = new DataSet();
                            adapterlist[2].Fill(dataThirdSet);

                            foreach (DataTable dataTable in dataThirdSet.Tables)
                            {
                                Console.WriteLine(dataTable.TableName); // название таблицы
                                                                        // перебор всех столбцов
                                foreach (DataColumn column in dataTable.Columns)
                                    Console.Write("\t{0}", column.ColumnName);
                                Console.WriteLine();
                                // перебор всех строк таблицы
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    // получаем все ячейки строки
                                    var cells = row.ItemArray;
                                    foreach (object cell in cells)
                                        Console.Write("\t{0}\t", cell);
                                    Console.WriteLine();
                                }
                            }
                            break;
                        case 4:
                            DataSet dataFourthSet = new DataSet();
                            adapterlist[3].Fill(dataFourthSet);

                            foreach (DataTable dataTable in dataFourthSet.Tables)
                            {
                                Console.WriteLine(dataTable.TableName); // название таблицы
                                                                        // перебор всех столбцов
                                foreach (DataColumn column in dataTable.Columns)
                                    Console.Write("\t{0}", column.ColumnName);
                                Console.WriteLine();
                                // перебор всех строк таблицы
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    // получаем все ячейки строки
                                    var cells = row.ItemArray;
                                    foreach (object cell in cells)
                                        Console.Write("\t{0}", cell);
                                    Console.WriteLine();
                                }
                            }
                            break;
                        
                        default:

                            break;
                    }
                } while (caseSwitch != 0);
                
                
                
               

           
            }

            Console.WriteLine("Подключение закрыто...");

            Console.Read();
        }


    }

        }
            
        

