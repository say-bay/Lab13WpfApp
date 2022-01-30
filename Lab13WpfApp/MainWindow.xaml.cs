﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab13WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontWeight != (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromInvariantString("Bold"))
                {
                    textBox.FontWeight = (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromInvariantString("Bold");
                }
                else
                {
                    textBox.FontWeight = (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromInvariantString("1");
                }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontStyle != (FontStyle)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontStyle)).ConvertFromInvariantString("Italic"))
                {
                    textBox.FontStyle = (FontStyle)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontStyle)).ConvertFromInvariantString("Italic");
                }
                else
                {
                    textBox.FontStyle = (FontStyle)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontStyle)).ConvertFromInvariantString("Normal");
                }
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.TextDecorations != (TextDecorationCollection)System.ComponentModel.TypeDescriptor.GetConverter(typeof(TextDecorationCollection)).ConvertFromInvariantString("Underline"))
                {
                    textBox.TextDecorations = (TextDecorationCollection)System.ComponentModel.TypeDescriptor.GetConverter(typeof(TextDecorationCollection)).ConvertFromInvariantString("Underline");
                }
                else
                {
                    textBox.TextDecorations = (TextDecorationCollection)System.ComponentModel.TypeDescriptor.GetConverter(typeof(TextDecorationCollection)).ConvertFromInvariantString("None");
                }
            }
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.SelectionTextBrush = (Brush)System.ComponentModel.TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("Black");
            }
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.SelectionTextBrush = (Brush)System.ComponentModel.TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("Red");
            }
        }
        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }
    }
}
