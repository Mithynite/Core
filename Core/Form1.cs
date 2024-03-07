using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Classes;
using Core.Classes.DAOs;

namespace Core
{
    public partial class Form1 : Form
    {
        private ClientOrdersDAO codao;
        public Form1()
        {
            InitializeComponent();
            codao = new ClientOrdersDAO();
        }

        
        private void close_button_Click(object sender, EventArgs e)
        {
            Close(); //TODO Zavření aplikace
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            insert_panel.Visible = !insert_panel.Visible;
        }

        private void see_btn_Click(object sender, EventArgs e)
        {
            see_panel.Visible = !see_panel.Visible;
        }
        private void view_btn_Click(object sender, EventArgs e)
        {
            config_panel.Visible = !config_panel.Visible;
        }
        
        private void SeeData_show_co_Click(object sender, EventArgs e)
        {
            output_txt.Clear();
            string username = SeeData_co_cusername.Text;
            username.Trim();
            IEnumerable<Order> orders = codao.GetByOrdersOfClient(username);
            string result = "";
            foreach (var v in orders)
            {
                result += v.ToString() + "\n";
            }
            output_txt.Text = result;
        }
        
        private void SeeData_show_poo_Click(object sender, EventArgs e)
        {
            output_txt.Clear();
            int orderNumber = Convert.ToInt32(SeeData_poo_onumber.Text);
            IEnumerable<Product> products = codao.GetByItemsOfAnOrder(orderNumber);
            string result = "";
            foreach (var v in products)
            {
                result += v.ToString() + "\n";
            }
            output_txt.Text = result;
        }
        
        private void ViewConFile_change_Click(object sender, EventArgs e)
        {
            ConfigurationFileManagement.UpdateConfigurationFile(ViewConFile_datas.Text, ViewConFile_database.Text, ViewConFile_name.Text, ViewConFile_passwd.Text);
        }
    }
}