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
using System.Text.RegularExpressions;

namespace Releases_of_films
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            // задать размеры для textBox
            textBoxIn.ForeColor = Color.Gray;
            textBoxDel.ForeColor = Color.Red;
            textBoxIn.Text = "дд.мм.гггг - название";
            textBoxIn.Size = new Size(this.Width - 350, 35);
            textBoxOut.Size = new Size(this.Width - 350, 300);
            textBoxDel.Size = new Size(this.Width - 45, 24);
        }

        private void exit_Click(object sender, EventArgs e) // выход из программы
        { Application.Exit(); }

        private void info_Click(object sender, EventArgs e) // инфо
        {
            this.TopMost = true;
            MessageBox.Show("A simple program for reminding dates.\n© Alexander Usov");
        }

        private void textBoxIn_MouseEnter(object sender, EventArgs e) // событие 1 курсор внутри
        {
            textBoxIn.ForeColor = Color.Black;
            textBoxIn.Text = "";
            textBoxIn.MouseEnter -= textBoxIn_MouseEnter; // откл.
        }
        /*
        private void textBoxIn_MouseLeave(object sender, EventArgs e) // событие 2 курсор снаружи
        {
            textBoxIn.ForeColor = Color.Gray;
            textBoxIn.Text = "дд.мм.гггг - название";
            //textBoxIn.MouseLeave -= textBoxIn_MouseLeave; // откл.
        }
        */
        private void buttonIn_Click(object sender, EventArgs e) // сохранить
        {
            try
            {
                //if (!System.IO.File.Exists("Releases_of_films.txt")) { } // проверка на существование файла, не используется
                string text = textBoxIn.Text; // записывает в переменную данные

                FileStream file = new FileStream("Releases_of_films.txt", FileMode.Append, FileAccess.Write); // открывает поток
                StreamWriter writer = new StreamWriter(file, Encoding.Unicode); // писатель

                if (!String.IsNullOrWhiteSpace(text)) // проверка
                {
                    if (!(text == "дд.мм.гггг - название"))
                    {
                        if (text[10] == '-' || text[11] == '-' || text[12] == '-')
                        {
                            // форматирование перед записью
                            string[] strValues = text.Split('\t', '\n', '\r', '.', '-'); // извлекает конкретную строку из массива
                            string data = null;
                            for (int t = 0; t < strValues.Length; t++)
                            {
                                data += $"{strValues[t].Trim(new Char[] { ' ', '*', '.' })}{(t < 2 ? '.' : ' ')}";
                                if (t == 3) data = data.Insert(11, "- ");
                                if (t == 3) data = data.TrimEnd(new Char[] { ' ' }) + "";
                            }

                            writer.WriteLine(data); // записывает в файл данные
                            textBoxIn.Text = "";
                        }
                        else
                        {
                            textBoxIn.ForeColor = Color.Black;
                            textBoxIn.Text = "Не соответствует формату!";
                        }
                    }
                }
                writer.Close(); // закрывает поток
                buttonOut_Click(null, null);
            }
            catch (Exception ex)
            {
                textBoxOut.Text = ex.Message;
            }
        }

        private void buttonOut_Click(object sender, EventArgs e) // отобразить
        {
            try
            {
                if (System.IO.File.Exists("Releases_of_films.txt")) // проверка на существование файла
                {
                    FileStream file = new FileStream("Releases_of_films.txt", FileMode.Open, FileAccess.Read); // открывает поток
                    StreamReader reader = new StreamReader(file, Encoding.Unicode); // читатель

                    string text = reader.ReadToEnd(); // в строку text записывает файл данных
                    reader.Close(); // закрывает поток

                    // создание массива union, согласование типов/формата данных
                    string[] lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries); // заполнить массив разбитыми на табы строками
                    //double[] realValues = new double[lines.Length]; // хранилище результатов, не используется
                    int[][] union = new int [lines.Length][]; // хранилище результатов

                    if (textBoxOut.Text != String.Empty) // обновить textBox перед выводом информации
                    { textBoxOut.Text = ""; }

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] strValues = lines[i].Split('\t', '\n', '\r', '.', '-'); // извлекает конкретную строку из массива
                        // форматирование строки
                        string display = null;
                        for (int t = 0; t < strValues.Length; t++)
                        {
                            display += $"{strValues[t].Trim(new Char[] { ' ', '*', '.' })}{(t < 2 ? '.' : ' ')}";
                            if (t == 2) display += " «";
                            else if (t == 3) display = display.TrimEnd(new Char[] { ' ' }) + "»";
                        }
                        // форматирование строки выполнено

                        textBoxOut.Text += display; // вывод информации в textBox

                        //realValues[i] = double.Parse(strValues[j]); // извлекает конкретный символ из строки
                        union[i] = new int[strValues.Length - 1];
                        for (int j = 0; j < strValues.Length; j++)
                            if (!(j == 3))
                                union[i][j] = Convert.ToInt32(strValues[j]);


                        // вычислить даты
                        DateTime dateNow = new DateTime();
                        dateNow = DateTime.Now; // текущее время

                        int y = 0, m = 0, d = 0;
                        for (; i < union.Length;) // установка даты, используется массив union
                        {
                            for (int j = 0; j < union[i].Length; j++)
                            {
                                if (j == 0)
                                    d = union[i][j];
                                else if (j == 1)
                                    m = union[i][j];
                                else if (j == 2)
                                    y = union[i][j];
                            }
                            break;
                        }

                        DateTime dateSet = new DateTime(y, m, d);  // установка год - месяц - день

                        TimeSpan time = dateSet.Subtract(dateNow); // разница между датами

                        int intact = time.Days + 1; // проверка
                        string s = intact.ToString();
                        char[] ar = s.ToCharArray();
                        Array.Reverse(ar);
                        s = new String(ar);
                        int shift = Convert.ToInt32(s[0].ToString());
                        if (shift == 1 && intact != 11) s = "день";
                        else if (shift == 2 && intact != 12) s = "дня";
                        else if (shift == 3 && intact != 13) s = "дня";
                        else if (shift == 4 && intact != 14) s = "дня";
                        else s = "дней";
                        textBoxOut.Text += $"  через {time.Days + 1} {s}.{Environment.NewLine}"; // вывод информации в textBox
                    }
                }
                else { textBoxOut.Text = "Информация не найдена!"; }
            }
            catch (Exception ex)
            {
                textBoxOut.Text = ex.Message;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e) // удалить
        {
            try
            {
                if (System.IO.File.Exists("Releases_of_films.txt")) // проверка на существование файла
                {
                    int del = Convert.ToInt32(textBoxDel.Text)-1; // номер индекса строки, которую надо удалить

                    FileStream file = new FileStream("Releases_of_films.txt", FileMode.Open, FileAccess.Read); // открывает поток
                    StreamReader reader = new StreamReader(file, Encoding.Unicode); // читатель

                    string text = reader.ReadToEnd(); // в строку text записывает файл данных
                    reader.Close(); // закрывает поток

                    string[] lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries); // заполнить массив разбитыми на табы строками
                    StreamWriter writer = new StreamWriter("Releases_of_films.txt", false, Encoding.Unicode); // писатель

                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (i == del)
                            continue;
                        writer.WriteLine(lines[i]);
                    }
                    writer.Close(); // закрывает поток
                    buttonOut_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                textBoxOut.Text = ex.Message;
            }
        }
    }
}
