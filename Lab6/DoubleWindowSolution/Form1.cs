using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoubleWindowSolution
{
    public partial class Form1 : Form
    {
        //
        List<ClassLib_1.CPU> LB_Objects = new List<ClassLib_1.CPU>();
        public Form1()
        {
            InitializeComponent();
        }
        ///////////
        private void UpdateInfoInDGV()
        {
            ObjectTable.Rows.Clear();
            for (int row = 0; row < LB_Objects.Count; row++)
            {
                ObjectTable.Rows.Add();
                for (int i = 0; i < 10; i++)
                    ObjectTable.Rows[row].Cells[i].Value = LB_Objects[row].GetInfoForDGV()[i];
            }
        }
        /// //////////////////
        private void B_New_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if(CustomBuffer.BufferObject != null)
                LB_Objects.Add(CustomBuffer.BufferObject);
            //
            UpdateInfoInDGV();
            //
        }


        private void B_Clear_Click(object sender, EventArgs e)
        {
            LB_Objects.Clear();
            //
            UpdateInfoInDGV();
            //
        }
    }
}
