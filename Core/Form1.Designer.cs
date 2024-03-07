namespace Core
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close_button = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.output_txt = new System.Windows.Forms.RichTextBox();
            this.view_btn = new System.Windows.Forms.Button();
            this.insert_panel = new System.Windows.Forms.Panel();
            this.category_panel = new System.Windows.Forms.Panel();
            this.Insert_create_ncat = new System.Windows.Forms.Button();
            this.Insert_ncat_note = new System.Windows.Forms.TextBox();
            this.Insert_ncat_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.product_panel = new System.Windows.Forms.Panel();
            this.Insert_create_np = new System.Windows.Forms.Button();
            this.Insert_np_title = new System.Windows.Forms.TextBox();
            this.Insert_np_price = new System.Windows.Forms.TextBox();
            this.Insert_np_tag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderitems_panel = new System.Windows.Forms.Panel();
            this.Insert_add_aito = new System.Windows.Forms.Button();
            this.Insert_aito_ptag = new System.Windows.Forms.TextBox();
            this.Insert_aito_onumber = new System.Windows.Forms.TextBox();
            this.orderItem_insert_label = new System.Windows.Forms.Label();
            this.client_panel = new System.Windows.Forms.Panel();
            this.Insert_nclient_username = new System.Windows.Forms.TextBox();
            this.Insert_nclient_mail = new System.Windows.Forms.TextBox();
            this.Insert_create_nclient = new System.Windows.Forms.Button();
            this.client_insert_label = new System.Windows.Forms.Label();
            this.order_panel = new System.Windows.Forms.Panel();
            this.Insert_no_cusername = new System.Windows.Forms.TextBox();
            this.Insert_no_mark = new System.Windows.Forms.TextBox();
            this.order_insert_label = new System.Windows.Forms.Label();
            this.Insert_no_number = new System.Windows.Forms.TextBox();
            this.Insert_create_no = new System.Windows.Forms.Button();
            this.insert_label = new System.Windows.Forms.Label();
            this.see_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SeeData_show_poo = new System.Windows.Forms.Button();
            this.SeeData_poo_onumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SeeData_show_co = new System.Windows.Forms.Button();
            this.SeeData_co_cusername = new System.Windows.Forms.TextBox();
            this.see_btn = new System.Windows.Forms.Button();
            this.config_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ViewConFile_passwd = new System.Windows.Forms.TextBox();
            this.ViewConFile_name = new System.Windows.Forms.TextBox();
            this.ViewConFile_database = new System.Windows.Forms.TextBox();
            this.ViewConFile_change = new System.Windows.Forms.Button();
            this.ViewConFile_datas = new System.Windows.Forms.TextBox();
            this.insert_panel.SuspendLayout();
            this.category_panel.SuspendLayout();
            this.product_panel.SuspendLayout();
            this.orderitems_panel.SuspendLayout();
            this.client_panel.SuspendLayout();
            this.order_panel.SuspendLayout();
            this.see_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.config_panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.BackColor = System.Drawing.Color.Red;
            this.close_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close_button.Location = new System.Drawing.Point(1572, 11);
            this.close_button.Margin = new System.Windows.Forms.Padding(0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(45, 31);
            this.close_button.TabIndex = 0;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.insert_btn.Location = new System.Drawing.Point(35, 65);
            this.insert_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(111, 41);
            this.insert_btn.TabIndex = 1;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Orange;
            this.edit_btn.Location = new System.Drawing.Point(35, 142);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(111, 41);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.remove_btn.Location = new System.Drawing.Point(35, 222);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(111, 41);
            this.remove_btn.TabIndex = 3;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            // 
            // import_btn
            // 
            this.import_btn.BackColor = System.Drawing.Color.Gold;
            this.import_btn.Location = new System.Drawing.Point(35, 295);
            this.import_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(111, 41);
            this.import_btn.TabIndex = 4;
            this.import_btn.Text = "Import Data";
            this.import_btn.UseVisualStyleBackColor = false;
            // 
            // output_txt
            // 
            this.output_txt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.output_txt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.output_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_txt.ForeColor = System.Drawing.Color.Yellow;
            this.output_txt.Location = new System.Drawing.Point(0, 756);
            this.output_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output_txt.Name = "output_txt";
            this.output_txt.ReadOnly = true;
            this.output_txt.Size = new System.Drawing.Size(1641, 296);
            this.output_txt.TabIndex = 5;
            this.output_txt.Text = "";
            // 
            // view_btn
            // 
            this.view_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.view_btn.Location = new System.Drawing.Point(35, 373);
            this.view_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(111, 41);
            this.view_btn.TabIndex = 6;
            this.view_btn.Text = "View ConFile";
            this.view_btn.UseVisualStyleBackColor = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // insert_panel
            // 
            this.insert_panel.BackColor = System.Drawing.Color.Black;
            this.insert_panel.Controls.Add(this.category_panel);
            this.insert_panel.Controls.Add(this.product_panel);
            this.insert_panel.Controls.Add(this.orderitems_panel);
            this.insert_panel.Controls.Add(this.client_panel);
            this.insert_panel.Controls.Add(this.order_panel);
            this.insert_panel.Controls.Add(this.insert_label);
            this.insert_panel.Location = new System.Drawing.Point(204, 9);
            this.insert_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insert_panel.Name = "insert_panel";
            this.insert_panel.Size = new System.Drawing.Size(951, 386);
            this.insert_panel.TabIndex = 7;
            this.insert_panel.Visible = false;
            // 
            // category_panel
            // 
            this.category_panel.BackColor = System.Drawing.Color.Goldenrod;
            this.category_panel.Controls.Add(this.Insert_create_ncat);
            this.category_panel.Controls.Add(this.Insert_ncat_note);
            this.category_panel.Controls.Add(this.Insert_ncat_title);
            this.category_panel.Controls.Add(this.label2);
            this.category_panel.Location = new System.Drawing.Point(709, 48);
            this.category_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.category_panel.Name = "category_panel";
            this.category_panel.Size = new System.Drawing.Size(239, 335);
            this.category_panel.TabIndex = 11;
            // 
            // Insert_create_ncat
            // 
            this.Insert_create_ncat.BackColor = System.Drawing.Color.Maroon;
            this.Insert_create_ncat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Insert_create_ncat.Location = new System.Drawing.Point(49, 156);
            this.Insert_create_ncat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_create_ncat.Name = "Insert_create_ncat";
            this.Insert_create_ncat.Size = new System.Drawing.Size(117, 39);
            this.Insert_create_ncat.TabIndex = 12;
            this.Insert_create_ncat.Text = "Create";
            this.Insert_create_ncat.UseVisualStyleBackColor = false;
            // 
            // Insert_ncat_note
            // 
            this.Insert_ncat_note.Location = new System.Drawing.Point(16, 112);
            this.Insert_ncat_note.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_ncat_note.Name = "Insert_ncat_note";
            this.Insert_ncat_note.Size = new System.Drawing.Size(204, 22);
            this.Insert_ncat_note.TabIndex = 13;
            this.Insert_ncat_note.Text = "note (optional)";
            this.Insert_ncat_note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Insert_ncat_title
            // 
            this.Insert_ncat_title.Location = new System.Drawing.Point(16, 69);
            this.Insert_ncat_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_ncat_title.Name = "Insert_ncat_title";
            this.Insert_ncat_title.Size = new System.Drawing.Size(204, 22);
            this.Insert_ncat_title.TabIndex = 12;
            this.Insert_ncat_title.Text = "title (name)";
            this.Insert_ncat_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Category";
            // 
            // product_panel
            // 
            this.product_panel.BackColor = System.Drawing.Color.Goldenrod;
            this.product_panel.Controls.Add(this.Insert_create_np);
            this.product_panel.Controls.Add(this.Insert_np_title);
            this.product_panel.Controls.Add(this.Insert_np_price);
            this.product_panel.Controls.Add(this.Insert_np_tag);
            this.product_panel.Controls.Add(this.label1);
            this.product_panel.Location = new System.Drawing.Point(347, 206);
            this.product_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product_panel.Name = "product_panel";
            this.product_panel.Size = new System.Drawing.Size(357, 177);
            this.product_panel.TabIndex = 10;
            // 
            // Insert_create_np
            // 
            this.Insert_create_np.BackColor = System.Drawing.Color.Maroon;
            this.Insert_create_np.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Insert_create_np.Location = new System.Drawing.Point(121, 135);
            this.Insert_create_np.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_create_np.Name = "Insert_create_np";
            this.Insert_create_np.Size = new System.Drawing.Size(117, 39);
            this.Insert_create_np.TabIndex = 8;
            this.Insert_create_np.Text = "Create";
            this.Insert_create_np.UseVisualStyleBackColor = false;
            // 
            // Insert_np_title
            // 
            this.Insert_np_title.Location = new System.Drawing.Point(77, 102);
            this.Insert_np_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_np_title.Name = "Insert_np_title";
            this.Insert_np_title.Size = new System.Drawing.Size(204, 22);
            this.Insert_np_title.TabIndex = 11;
            this.Insert_np_title.Text = "category title (name)";
            this.Insert_np_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Insert_np_price
            // 
            this.Insert_np_price.Location = new System.Drawing.Point(77, 73);
            this.Insert_np_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_np_price.Name = "Insert_np_price";
            this.Insert_np_price.Size = new System.Drawing.Size(204, 22);
            this.Insert_np_price.TabIndex = 10;
            this.Insert_np_price.Text = "price";
            this.Insert_np_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Insert_np_tag
            // 
            this.Insert_np_tag.Location = new System.Drawing.Point(77, 43);
            this.Insert_np_tag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_np_tag.Name = "Insert_np_tag";
            this.Insert_np_tag.Size = new System.Drawing.Size(204, 22);
            this.Insert_np_tag.TabIndex = 8;
            this.Insert_np_tag.Text = "tag (name)";
            this.Insert_np_tag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(91, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Product\r\n";
            // 
            // orderitems_panel
            // 
            this.orderitems_panel.BackColor = System.Drawing.Color.Goldenrod;
            this.orderitems_panel.Controls.Add(this.Insert_add_aito);
            this.orderitems_panel.Controls.Add(this.Insert_aito_ptag);
            this.orderitems_panel.Controls.Add(this.Insert_aito_onumber);
            this.orderitems_panel.Controls.Add(this.orderItem_insert_label);
            this.orderitems_panel.Location = new System.Drawing.Point(3, 206);
            this.orderitems_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderitems_panel.Name = "orderitems_panel";
            this.orderitems_panel.Size = new System.Drawing.Size(337, 177);
            this.orderitems_panel.TabIndex = 9;
            // 
            // Insert_add_aito
            // 
            this.Insert_add_aito.BackColor = System.Drawing.Color.Maroon;
            this.Insert_add_aito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Insert_add_aito.Location = new System.Drawing.Point(107, 127);
            this.Insert_add_aito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_add_aito.Name = "Insert_add_aito";
            this.Insert_add_aito.Size = new System.Drawing.Size(117, 39);
            this.Insert_add_aito.TabIndex = 8;
            this.Insert_add_aito.Text = "Link and add";
            this.Insert_add_aito.UseVisualStyleBackColor = false;
            // 
            // Insert_aito_ptag
            // 
            this.Insert_aito_ptag.Location = new System.Drawing.Point(67, 90);
            this.Insert_aito_ptag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_aito_ptag.Name = "Insert_aito_ptag";
            this.Insert_aito_ptag.Size = new System.Drawing.Size(204, 22);
            this.Insert_aito_ptag.TabIndex = 10;
            this.Insert_aito_ptag.Text = "product tag\r\n";
            this.Insert_aito_ptag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Insert_aito_onumber
            // 
            this.Insert_aito_onumber.Location = new System.Drawing.Point(67, 50);
            this.Insert_aito_onumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_aito_onumber.Name = "Insert_aito_onumber";
            this.Insert_aito_onumber.Size = new System.Drawing.Size(204, 22);
            this.Insert_aito_onumber.TabIndex = 8;
            this.Insert_aito_onumber.Text = "order number";
            this.Insert_aito_onumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderItem_insert_label
            // 
            this.orderItem_insert_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItem_insert_label.ForeColor = System.Drawing.SystemColors.Window;
            this.orderItem_insert_label.Location = new System.Drawing.Point(53, 15);
            this.orderItem_insert_label.Name = "orderItem_insert_label";
            this.orderItem_insert_label.Size = new System.Drawing.Size(243, 33);
            this.orderItem_insert_label.TabIndex = 9;
            this.orderItem_insert_label.Text = "Add item to order";
            // 
            // client_panel
            // 
            this.client_panel.BackColor = System.Drawing.Color.Goldenrod;
            this.client_panel.Controls.Add(this.Insert_nclient_username);
            this.client_panel.Controls.Add(this.Insert_nclient_mail);
            this.client_panel.Controls.Add(this.Insert_create_nclient);
            this.client_panel.Controls.Add(this.client_insert_label);
            this.client_panel.Location = new System.Drawing.Point(380, 48);
            this.client_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.client_panel.Name = "client_panel";
            this.client_panel.Size = new System.Drawing.Size(324, 153);
            this.client_panel.TabIndex = 6;
            // 
            // Insert_nclient_username
            // 
            this.Insert_nclient_username.Location = new System.Drawing.Point(44, 69);
            this.Insert_nclient_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_nclient_username.Name = "Insert_nclient_username";
            this.Insert_nclient_username.Size = new System.Drawing.Size(204, 22);
            this.Insert_nclient_username.TabIndex = 8;
            this.Insert_nclient_username.Text = "username";
            this.Insert_nclient_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Insert_nclient_mail
            // 
            this.Insert_nclient_mail.Location = new System.Drawing.Point(44, 39);
            this.Insert_nclient_mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_nclient_mail.Name = "Insert_nclient_mail";
            this.Insert_nclient_mail.Size = new System.Drawing.Size(204, 22);
            this.Insert_nclient_mail.TabIndex = 8;
            this.Insert_nclient_mail.Text = "e - mail";
            this.Insert_nclient_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Insert_create_nclient
            // 
            this.Insert_create_nclient.BackColor = System.Drawing.Color.Maroon;
            this.Insert_create_nclient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Insert_create_nclient.Location = new System.Drawing.Point(88, 105);
            this.Insert_create_nclient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_create_nclient.Name = "Insert_create_nclient";
            this.Insert_create_nclient.Size = new System.Drawing.Size(117, 39);
            this.Insert_create_nclient.TabIndex = 4;
            this.Insert_create_nclient.Text = "Create";
            this.Insert_create_nclient.UseVisualStyleBackColor = false;
            // 
            // client_insert_label
            // 
            this.client_insert_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_insert_label.ForeColor = System.Drawing.SystemColors.Window;
            this.client_insert_label.Location = new System.Drawing.Point(72, 0);
            this.client_insert_label.Name = "client_insert_label";
            this.client_insert_label.Size = new System.Drawing.Size(193, 37);
            this.client_insert_label.TabIndex = 8;
            this.client_insert_label.Text = "New Client";
            // 
            // order_panel
            // 
            this.order_panel.BackColor = System.Drawing.Color.Goldenrod;
            this.order_panel.Controls.Add(this.Insert_no_cusername);
            this.order_panel.Controls.Add(this.Insert_no_mark);
            this.order_panel.Controls.Add(this.order_insert_label);
            this.order_panel.Controls.Add(this.Insert_no_number);
            this.order_panel.Controls.Add(this.Insert_create_no);
            this.order_panel.Location = new System.Drawing.Point(3, 47);
            this.order_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_panel.Name = "order_panel";
            this.order_panel.Size = new System.Drawing.Size(372, 153);
            this.order_panel.TabIndex = 5;
            // 
            // Insert_no_cusername
            // 
            this.Insert_no_cusername.Location = new System.Drawing.Point(19, 94);
            this.Insert_no_cusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_no_cusername.Name = "Insert_no_cusername";
            this.Insert_no_cusername.Size = new System.Drawing.Size(204, 22);
            this.Insert_no_cusername.TabIndex = 3;
            this.Insert_no_cusername.Text = "Client username";
            this.Insert_no_cusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Insert_no_mark
            // 
            this.Insert_no_mark.Location = new System.Drawing.Point(19, 62);
            this.Insert_no_mark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_no_mark.Name = "Insert_no_mark";
            this.Insert_no_mark.Size = new System.Drawing.Size(204, 22);
            this.Insert_no_mark.TabIndex = 2;
            this.Insert_no_mark.Text = "mark (optional)";
            this.Insert_no_mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // order_insert_label
            // 
            this.order_insert_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_insert_label.ForeColor = System.Drawing.SystemColors.Window;
            this.order_insert_label.Location = new System.Drawing.Point(53, 0);
            this.order_insert_label.Name = "order_insert_label";
            this.order_insert_label.Size = new System.Drawing.Size(156, 31);
            this.order_insert_label.TabIndex = 7;
            this.order_insert_label.Text = "New Order";
            // 
            // Insert_no_number
            // 
            this.Insert_no_number.Location = new System.Drawing.Point(19, 34);
            this.Insert_no_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_no_number.Name = "Insert_no_number";
            this.Insert_no_number.Size = new System.Drawing.Size(204, 22);
            this.Insert_no_number.TabIndex = 1;
            this.Insert_no_number.Text = "number";
            this.Insert_no_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Insert_create_no
            // 
            this.Insert_create_no.BackColor = System.Drawing.Color.Maroon;
            this.Insert_create_no.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Insert_create_no.Location = new System.Drawing.Point(244, 53);
            this.Insert_create_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_create_no.Name = "Insert_create_no";
            this.Insert_create_no.Size = new System.Drawing.Size(117, 39);
            this.Insert_create_no.TabIndex = 0;
            this.Insert_create_no.Text = "Create";
            this.Insert_create_no.UseVisualStyleBackColor = false;
            // 
            // insert_label
            // 
            this.insert_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insert_label.Location = new System.Drawing.Point(215, 2);
            this.insert_label.Name = "insert_label";
            this.insert_label.Size = new System.Drawing.Size(544, 41);
            this.insert_label.TabIndex = 3;
            this.insert_label.Text = "Here you can insert new Data";
            // 
            // see_panel
            // 
            this.see_panel.Controls.Add(this.panel2);
            this.see_panel.Controls.Add(this.label3);
            this.see_panel.Controls.Add(this.panel1);
            this.see_panel.Location = new System.Drawing.Point(204, 396);
            this.see_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.see_panel.Name = "see_panel";
            this.see_panel.Size = new System.Drawing.Size(515, 183);
            this.see_panel.TabIndex = 9;
            this.see_panel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.SeeData_show_poo);
            this.panel2.Controls.Add(this.SeeData_poo_onumber);
            this.panel2.Location = new System.Drawing.Point(251, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 133);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(31, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Products of Order";
            // 
            // SeeData_show_poo
            // 
            this.SeeData_show_poo.BackColor = System.Drawing.Color.Maroon;
            this.SeeData_show_poo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SeeData_show_poo.Location = new System.Drawing.Point(72, 85);
            this.SeeData_show_poo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeData_show_poo.Name = "SeeData_show_poo";
            this.SeeData_show_poo.Size = new System.Drawing.Size(117, 39);
            this.SeeData_show_poo.TabIndex = 9;
            this.SeeData_show_poo.Text = "Show\r\n";
            this.SeeData_show_poo.UseVisualStyleBackColor = false;
            this.SeeData_show_poo.Click += new System.EventHandler(this.SeeData_show_poo_Click);
            // 
            // SeeData_poo_onumber
            // 
            this.SeeData_poo_onumber.Location = new System.Drawing.Point(31, 53);
            this.SeeData_poo_onumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeData_poo_onumber.Name = "SeeData_poo_onumber";
            this.SeeData_poo_onumber.Size = new System.Drawing.Size(204, 22);
            this.SeeData_poo_onumber.TabIndex = 9;
            this.SeeData_poo_onumber.Text = "order number";
            this.SeeData_poo_onumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(91, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Let\'s see the Data!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SeeData_show_co);
            this.panel1.Controls.Add(this.SeeData_co_cusername);
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 133);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(39, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Client\'s orders";
            // 
            // SeeData_show_co
            // 
            this.SeeData_show_co.BackColor = System.Drawing.Color.Maroon;
            this.SeeData_show_co.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SeeData_show_co.Location = new System.Drawing.Point(67, 85);
            this.SeeData_show_co.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeData_show_co.Name = "SeeData_show_co";
            this.SeeData_show_co.Size = new System.Drawing.Size(117, 39);
            this.SeeData_show_co.TabIndex = 9;
            this.SeeData_show_co.Text = "Show";
            this.SeeData_show_co.UseVisualStyleBackColor = false;
            this.SeeData_show_co.Click += new System.EventHandler(this.SeeData_show_co_Click);
            // 
            // SeeData_co_cusername
            // 
            this.SeeData_co_cusername.Location = new System.Drawing.Point(16, 53);
            this.SeeData_co_cusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeData_co_cusername.Name = "SeeData_co_cusername";
            this.SeeData_co_cusername.Size = new System.Drawing.Size(204, 22);
            this.SeeData_co_cusername.TabIndex = 9;
            this.SeeData_co_cusername.Text = "client username";
            this.SeeData_co_cusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // see_btn
            // 
            this.see_btn.BackColor = System.Drawing.Color.Gold;
            this.see_btn.Location = new System.Drawing.Point(35, 450);
            this.see_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.see_btn.Name = "see_btn";
            this.see_btn.Size = new System.Drawing.Size(111, 41);
            this.see_btn.TabIndex = 8;
            this.see_btn.Text = "See data";
            this.see_btn.UseVisualStyleBackColor = false;
            this.see_btn.Click += new System.EventHandler(this.see_btn_Click);
            // 
            // config_panel
            // 
            this.config_panel.Controls.Add(this.label7);
            this.config_panel.Controls.Add(this.panel5);
            this.config_panel.Location = new System.Drawing.Point(1157, 9);
            this.config_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.config_panel.Name = "config_panel";
            this.config_panel.Size = new System.Drawing.Size(377, 386);
            this.config_panel.TabIndex = 12;
            this.config_panel.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(0, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(371, 34);
            this.label7.TabIndex = 4;
            this.label7.Text = "Edit Configuration File!";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel5.Controls.Add(this.ViewConFile_passwd);
            this.panel5.Controls.Add(this.ViewConFile_name);
            this.panel5.Controls.Add(this.ViewConFile_database);
            this.panel5.Controls.Add(this.ViewConFile_change);
            this.panel5.Controls.Add(this.ViewConFile_datas);
            this.panel5.Location = new System.Drawing.Point(3, 48);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 335);
            this.panel5.TabIndex = 0;
            // 
            // ViewConFile_passwd
            // 
            this.ViewConFile_passwd.Location = new System.Drawing.Point(76, 201);
            this.ViewConFile_passwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewConFile_passwd.Name = "ViewConFile_passwd";
            this.ViewConFile_passwd.Size = new System.Drawing.Size(204, 22);
            this.ViewConFile_passwd.TabIndex = 14;
            this.ViewConFile_passwd.Text = "password";
            this.ViewConFile_passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewConFile_name
            // 
            this.ViewConFile_name.Location = new System.Drawing.Point(76, 145);
            this.ViewConFile_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewConFile_name.Name = "ViewConFile_name";
            this.ViewConFile_name.Size = new System.Drawing.Size(204, 22);
            this.ViewConFile_name.TabIndex = 13;
            this.ViewConFile_name.Text = "name";
            this.ViewConFile_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewConFile_database
            // 
            this.ViewConFile_database.Location = new System.Drawing.Point(76, 94);
            this.ViewConFile_database.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewConFile_database.Name = "ViewConFile_database";
            this.ViewConFile_database.Size = new System.Drawing.Size(204, 22);
            this.ViewConFile_database.TabIndex = 12;
            this.ViewConFile_database.Text = "initial catalog (database)";
            this.ViewConFile_database.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewConFile_change
            // 
            this.ViewConFile_change.BackColor = System.Drawing.Color.Maroon;
            this.ViewConFile_change.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewConFile_change.Location = new System.Drawing.Point(119, 260);
            this.ViewConFile_change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewConFile_change.Name = "ViewConFile_change";
            this.ViewConFile_change.Size = new System.Drawing.Size(117, 39);
            this.ViewConFile_change.TabIndex = 9;
            this.ViewConFile_change.Text = "Change";
            this.ViewConFile_change.UseVisualStyleBackColor = false;
            this.ViewConFile_change.Click += new System.EventHandler(this.ViewConFile_change_Click);
            // 
            // ViewConFile_datas
            // 
            this.ViewConFile_datas.Location = new System.Drawing.Point(76, 39);
            this.ViewConFile_datas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewConFile_datas.Name = "ViewConFile_datas";
            this.ViewConFile_datas.Size = new System.Drawing.Size(204, 22);
            this.ViewConFile_datas.TabIndex = 9;
            this.ViewConFile_datas.Text = "data source";
            this.ViewConFile_datas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1641, 1052);
            this.Controls.Add(this.config_panel);
            this.Controls.Add(this.see_panel);
            this.Controls.Add(this.see_btn);
            this.Controls.Add(this.insert_panel);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.output_txt);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.insert_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.insert_panel.ResumeLayout(false);
            this.category_panel.ResumeLayout(false);
            this.category_panel.PerformLayout();
            this.product_panel.ResumeLayout(false);
            this.product_panel.PerformLayout();
            this.orderitems_panel.ResumeLayout(false);
            this.orderitems_panel.PerformLayout();
            this.client_panel.ResumeLayout(false);
            this.client_panel.PerformLayout();
            this.order_panel.ResumeLayout(false);
            this.order_panel.PerformLayout();
            this.see_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.config_panel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox ViewConFile_database;
        private System.Windows.Forms.TextBox ViewConFile_name;
        private System.Windows.Forms.TextBox ViewConFile_passwd;

        private System.Windows.Forms.Panel config_panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ViewConFile_change;
        private System.Windows.Forms.TextBox ViewConFile_datas;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SeeData_show_poo;
        private System.Windows.Forms.TextBox SeeData_poo_onumber;

        private System.Windows.Forms.TextBox SeeData_co_cusername;
        private System.Windows.Forms.Button SeeData_show_co;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel see_panel;

        private System.Windows.Forms.Button see_btn;

        private System.Windows.Forms.Button Insert_create_np;
        private System.Windows.Forms.Button Insert_create_ncat;

        private System.Windows.Forms.TextBox Insert_ncat_note;

        private System.Windows.Forms.TextBox Insert_np_title;
        private System.Windows.Forms.TextBox Insert_ncat_title;

        private System.Windows.Forms.TextBox Insert_np_price;

        private System.Windows.Forms.Button Insert_add_aito;
        private System.Windows.Forms.TextBox Insert_np_tag;

        private System.Windows.Forms.TextBox Insert_aito_onumber;

        private System.Windows.Forms.TextBox Insert_aito_ptag;

        private System.Windows.Forms.TextBox Insert_nclient_mail;
        private System.Windows.Forms.TextBox Insert_nclient_username;

        private System.Windows.Forms.Label orderItem_insert_label;
        private System.Windows.Forms.Panel category_panel;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel product_panel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel orderitems_panel;

        private System.Windows.Forms.TextBox Insert_no_cusername;

        private System.Windows.Forms.Label client_insert_label;
        private System.Windows.Forms.TextBox Insert_no_number;
        private System.Windows.Forms.TextBox Insert_no_mark;

        private System.Windows.Forms.Label order_insert_label;

        private System.Windows.Forms.Panel client_panel;

        private System.Windows.Forms.Panel order_panel;

        private System.Windows.Forms.Label insert_label;

        private System.Windows.Forms.Button Insert_create_no;
        private System.Windows.Forms.Button Insert_create_nclient;

        private System.Windows.Forms.Panel insert_panel;

        private System.Windows.Forms.Button view_btn;

        private System.Windows.Forms.RichTextBox output_txt;

        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button import_btn;

        private System.Windows.Forms.Button close_button;

        #endregion
    }
}