﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountFuncionsProjectByHirutsu
{
    public partial class Form1 : Form
    {
        private string nameFile;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nameFile = openFileDialog1.FileName;
                LabelNameFile.Text = "Открыт файл:" + nameFile;
            }
        }

        private void ButtonCountFunctions_Click(object sender, EventArgs e)
        {
            using (StreamReader streamReader = new StreamReader(nameFile, Encoding.GetEncoding(1251)))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] FunctionsArray = line.Split();
                    for(int index=0;index<FunctionsArray.Length;index++)
                    {
                        if (dictionary.ContainsKey(FunctionsArray[index]))
                        {
                            dictionary[FunctionsArray[index]] += 1;
                        }
                        else
                        {
                            dictionary.Add(FunctionsArray[index], 1);
                        }
                    }
                }
            }
            LabelNameFile.Text = "Счетние данных завершено";
        }

        private void ButtonSafeCountFunctions_Click(object sender, EventArgs e)
        {
            dictionary = dictionary.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nameFile = saveFileDialog1.FileName;
                using(StreamWriter streamWriter = new StreamWriter(nameFile, false))
                {
                    foreach(var item in dictionary)
                    {
                        streamWriter.WriteLine(item.Key + ": " + item.Value + " штук");
                    }
                }
            }
            LabelNameFile.Text = "Файл сохранен";
        }
    }
}
