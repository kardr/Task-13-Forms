using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_13_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Client> clientList = new List<Client>();
                StreamReader sr = new StreamReader(@"C:\Users\KDroz\OneDrive\Рабочий стол\Практика\Неделя 4\Задание 13\Task 13 Forms\1.txt", Encoding.Default);
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (s.Length == 5)
                    {
                        clientList.Add(new Creditor(s[0], Convert.ToDateTime(s[1]), Convert.ToDecimal(s[2]),
                                                          Convert.ToDouble(s[3]), Convert.ToDecimal(s[4])));
                    }
                    if (s.Length == 4)
                    {
                        int number;
                        if (Int32.TryParse(s[2], out number))
                        {
                            clientList.Add(new Organization(s[0], Convert.ToDateTime(s[1]),
                                                         number, Convert.ToDecimal(s[3])));
                        }
                        else
                        {
                            clientList.Add(new Investor(s[0], Convert.ToDateTime(s[1]),
                                      Convert.ToDecimal(s[2]), Convert.ToDouble(s[3])));
                        }
                    }
                }
                sr.Close();

                foreach (Client client in clientList)
                {
                    textBox1.Text += client.Print();
                    textBox1.Text += "\n\r";
                }

                textBox1.Text += "\n\r" + "Поиск клиентов, начавших сотрудничать с банком в заданную дату:";

                DateTime askDate = new DateTime(2017, 12, 13);
                int foundClients = 0;

                foreach (Client client in clientList)
                {
                    if (client.Quest(askDate))
                    {
                        textBox2.Text += client.Print();
                        textBox2.Text += foundClients++;
                    }
                }
                if (foundClients == 0)
                {
                    textBox2.Text += "Клиенты по данной дате не найдены";
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
