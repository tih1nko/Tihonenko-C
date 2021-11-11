using System;
using System.Windows;

namespace QA_Auto__Trainee_
{
    public partial class MainWindow : Window
    {
        public int[] array;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_CheckNum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(Convert.ToInt32(TB_Number.Text) > 7)
                {
                    TextB_Message.Text = "Привет";
                }
                else TextB_Message.Text = "";
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка: {exc.Message}");
            }
        }

        private void B_CheckName_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB_Name.Text == "Вячеслав")
                {
                    TextB_Message1.Text = $"Привет, {TB_Name.Text}";
                }
                else TextB_Message1.Text = "Нет такого имени";
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка: {exc.Message}");
            }
        }

        private void B_FillRandom_Click(object sender, RoutedEventArgs e)
        {
            new RandomSettings().ShowDialog();
            array = RandomSettings.array;
        }

        private void B_FillManual_Click(object sender, RoutedEventArgs e)
        {
            new ManualSettings().ShowDialog();
            array = ManualSettings.stackarr.ToArray();
        }

        private void B_Write_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (array == null) throw new Exception("Массив не заполнен");
                TextB_Array.Text = "Массив: ";
                for (int i = 0; i < array.Length; i++)
                {
                    TextB_Array.Text += array[i] + " ";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка: {exc.Message}");
            }
        }

        private void B_Multiple3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (array == null) throw new Exception("Массив пуст");
                TextB_Multiple3.Text = "Элементы массива кратные 3: ";
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 3 == 0)
                    {
                        TextB_Multiple3.Text += array[i] + " ";
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка: {exc.Message}");
            }
        }
    }
}
