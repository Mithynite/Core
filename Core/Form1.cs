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
        private InsertIntoDatabaseDAO ins;
        private ClientOrdersDAO codao;
        private RemoveFromDatabase refdat;
        public Form1()
        {
            InitializeComponent();
            ins = new InsertIntoDatabaseDAO();
            codao = new ClientOrdersDAO();
            refdat = new RemoveFromDatabase();
        }

        
        private void close_button_Click(object sender, EventArgs e)
        {
            Close(); //TODO Zavření aplikace
        }
        
        #region Insertion
        private void insert_btn_Click(object sender, EventArgs e)
        {
            insert_panel.Visible = !insert_panel.Visible;
        }
        private void Insert_create_no_Click(object sender, EventArgs e)
        {
            Order order = new Order(Insert_no_mark.Text, Convert.ToInt32(Insert_no_number.Text));
            output_txt.Text = ins.InsertNewOrder(order, Insert_no_cusername.Text);
        }
        private void Insert_add_aito_Click(object sender, EventArgs e)
        {
            output_txt.Text = ins.AddItemToOrder(Convert.ToInt32(Insert_aito_onumber.Text), Insert_aito_ptag.Text);
        }
        private void Insert_create_nclient_Click(object sender, EventArgs e)
        {
            Client client = new Client(Insert_nclient_mail.Text, Insert_nclient_username.Text);
            output_txt.Text = ins.InsertNewClient(client);
        }
        private void Insert_create_np_Click(object sender, EventArgs e)
        {
            Product product = new Product(Insert_np_tag.Text, Convert.ToInt32(Insert_np_price.Text));
            output_txt.Text = ins.InsertNewProduct(product, Insert_np_title.Text);
        }
        private void Insert_create_ncat_Click(object sender, EventArgs e)
        {
            Category category = new Category(Insert_ncat_title.Text, Insert_ncat_note.Text);
            output_txt.Text = ins.InsertNewCategory(category);
        }
        #endregion

        #region Remove Data

        private void remove_btn_Click(object sender, EventArgs e)
        {
            remove_panel.Visible = !remove_panel.Visible;
        }
        
        private void Remove_del_client_Click(object sender, EventArgs e)
        {
            output_txt.Text = refdat.RemoveClient(Remove_client_cusername.Text);
        }
        private void Remove_del_order_Click(object sender, EventArgs e)
        {
            output_txt.Text = refdat.RemoveOrder(Convert.ToInt32(Remove_order_onumber.Text));
        }
        private void Remove_del_product_Click(object sender, EventArgs e)
        {
            output_txt.Text = refdat.RemoveProduct(Remove_product_ptag.Text);
        }
        #endregion
        
        #region Cofiguration File
        private void view_btn_Click(object sender, EventArgs e)
        {
            config_panel.Visible = !config_panel.Visible;
        }
        private void ViewConFile_change_Click(object sender, EventArgs e)
        {
            ConfigurationFileManagement.UpdateConfigurationFile(ViewConFile_datas.Text, ViewConFile_database.Text, ViewConFile_name.Text, ViewConFile_passwd.Text);
        }

        #endregion
        
        #region See your Data
        private void see_btn_Click(object sender, EventArgs e)
        {
            see_panel.Visible = !see_panel.Visible;
        }
        private void SeeData_show_co_Click(object sender, EventArgs e)
        {
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
            int orderNumber = Convert.ToInt32(SeeData_poo_onumber.Text);
            IEnumerable<Product> products = codao.GetByItemsOfAnOrder(orderNumber);
            string result = "";
            foreach (var v in products)
            {
                result += v.ToString() + "\n";
            }
            output_txt.Text = result;
        }
        #endregion

        
    }
}