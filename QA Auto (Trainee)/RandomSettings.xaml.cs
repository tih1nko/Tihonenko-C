using System;
using System.Windows;

namespace QA_Auto__Trainee_
{
    public partial class RandomSettings : Window
    {
        public RandomSettings()
        {
            InitializeComponent();
        }
        public static int[] array;
        private void B_Fill_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int begin, end, size;
                if(!int.TryParse(TB_Begin.Text, out begin) || !int.TryParse(TB_End.Text, out end) || begin > end || !int.TryParse(TB_Size.Text, out size) || size < 0)
                {
                    throw new Exception("Неверный ввод значений");
                }
                else
                {
                    array = new int[size];
                    Random rand = new Random();
                    for (int i = 0; i < size; i++)
                    {
                        array[i] = rand.Next(begin, end);
                    }
                    this.Close();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show($"Ошибка: {exc.Message}");
            }
        }
    }
}
