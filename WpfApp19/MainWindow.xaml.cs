using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// устанавливаем пакеты
//Pomelo.EntityFrameworkCore.MySql  7.0.0
//Microsoft.EntityFrameworkCore.Tools 7.0.0

// пишем команду в консоли диспетчера пакетов, например
//Scaffold - DbContext "server=192.168.200.13;user=student;password=student;database=1125_students" Pomelo.EntityFrameworkCore.MySql

// в случае успеха имеем контекст бд, например _1125StudentsContext
// и кучу моделей (для каждой таблицы своя модель) со свойствами навигации (появляются при наличии связей между таблицами)

// делаем класс типа DB для доступа к контексту базы из любого места приложения

// ниже примеры обращения к таблицам

namespace WpfApp19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> Data { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            // выборка (select)
            Data = DB.GetInstance().Students.
                Include(s=>s.Group). // Include работает только с указанным using Microsoft.EntityFrameworkCore;
                Where(s=>s.GroupId == 6).ToList();

            // добавление новой записи (insert)
            /*DB.GetInstance().Students.Add(new Student {
             Birthday = new DateOnly(2023, 3,6),
              GroupId = 6,
               LastName = "Первый",
                FirstName = "Второй",
                 PatronymicName = "Третий"
            });
            DB.GetInstance().SaveChanges();*/

            // изменение (update)
            /*Data.First().FirstName = "Изменено";
            DB.GetInstance().SaveChanges();*/

            // удаление (delete)
            /* DB.GetInstance().Students.Remove(Data.First());
            DB.GetInstance().SaveChanges();*/

            DataContext = this;
        }
    }
}