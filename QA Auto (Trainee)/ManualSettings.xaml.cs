using System;
using System.Collections.Generic;
using System.Windows;

namespace QA_Auto__Trainee_
{
    public partial class ManualSettings : Window
    {
        public static Stack<int> stackarr = new Stack<int>();
        public ManualSettings()
        {
            InitializeComponent();
        }
        private void B_AddToArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num;
                if(!int.TryParse(TB_AddNum.Text, out num))
                {
                    throw new Exception("Неверное число");
                }
                else
                {
                    stackarr.Push(num);
                    WriteArr();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка: {exc.Message}");
            }
        }
        private void B_PrevDell_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (stackarr.Count == 0) throw new Exception("Массив пуст");
                else 
                {
                    stackarr.Pop();
                    WriteArr();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка: {exc.Message}"); ;
            }
        }
        private void B_ClearArray_Click(object sender, RoutedEventArgs e)
        {
            stackarr.Clear();
            WriteArr();
        }
        void WriteArr()
        {
            TextB_Array.Text = "Массив: ";
            foreach (var item in stackarr)
            {
                TextB_Array.Text += item + " ";
            }
        }
    }
}
