namespace PizzaMaker
{
    partial class FrmPizzaMaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpIngredients = new System.Windows.Forms.GroupBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbPeppers = new System.Windows.Forms.CheckBox();
            this.chbSausage = new System.Windows.Forms.CheckBox();
            this.chbPineapple = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbBacon = new System.Windows.Forms.CheckBox();
            this.chbPepperoni = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbStrangeAddOns = new System.Windows.Forms.ListBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdoGlutenFree = new System.Windows.Forms.RadioButton();
            this.rdoStuffedCrust = new System.Windows.Forms.RadioButton();
            this.rdoDeepDish = new System.Windows.Forms.RadioButton();
            this.rdoThinCrust = new System.Windows.Forms.RadioButton();
            this.grpExtraGoodies = new System.Windows.Forms.GroupBox();
            this.lblCheese = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hsbCheese = new System.Windows.Forms.HScrollBar();
            this.lblSauce = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hsbSauce = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.picPizzaBoxColor = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPizzaPrice = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnCreatePizza = new System.Windows.Forms.Button();
            this.btnSeeFullOrder = new System.Windows.Forms.Button();
            this.grpIngredients.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.grpExtraGoodies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Leave += new System.EventHandler(this.TxtNameLeaveEH);
            // 
            // grpIngredients
            // 
            this.grpIngredients.Controls.Add(this.chbTomatoes);
            this.grpIngredients.Controls.Add(this.chbPeppers);
            this.grpIngredients.Controls.Add(this.chbSausage);
            this.grpIngredients.Controls.Add(this.chbPineapple);
            this.grpIngredients.Controls.Add(this.chbMushrooms);
            this.grpIngredients.Controls.Add(this.chbOlives);
            this.grpIngredients.Controls.Add(this.chbBacon);
            this.grpIngredients.Controls.Add(this.chbPepperoni);
            this.grpIngredients.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpIngredients.Location = new System.Drawing.Point(13, 50);
            this.grpIngredients.Name = "grpIngredients";
            this.grpIngredients.Size = new System.Drawing.Size(248, 126);
            this.grpIngredients.TabIndex = 2;
            this.grpIngredients.TabStop = false;
            this.grpIngredients.Text = "Ingredients";
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbTomatoes.Location = new System.Drawing.Point(127, 97);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(77, 19);
            this.chbTomatoes.TabIndex = 7;
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.ChbIngredientCheckedChangedEH);
            // 
            // chbPeppers
            // 
            this.chbPeppers.AutoSize = true;
            this.chbPeppers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbPeppers.Location = new System.Drawing.Point(127, 72);
            this.chbPeppers.Name = "chbPeppers";
            this.chbPeppers.Size = new System.Drawing.Size(68, 19);
            this.chbPeppers.TabIndex = 6;
            this.chbPeppers.Text = "Peppers";
            this.chbPeppers.UseVisualStyleBackColor = true;
            this.chbPeppers.CheckedChanged += new System.EventHandler(this.ChbIngredientCheckedChangedEH);
            // 
            // chbSausage
            // 
            this.chbSausage.AutoSize = true;
            this.chbSausage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbSausage.Location = new System.Drawing.Point(127, 47);
            this.chbSausage.Name = "chbSausage";
            this.chbSausage.Size = new System.Drawing.Size(69, 19);
            this.chbSausage.TabIndex = 5;
            this.chbSausage.Text = "Sausage";
            this.chbSausage.UseVisualStyleBackColor = true;
            this.chbSausage.CheckedChanged += new System.EventHandler(this.ChbIngredientCheckedChangedEH);
            // 
            // chbPineapple
            // 
            this.chbPineapple.AutoSize = true;
            this.chbPineapple.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbPineapple.Location = new System.Drawing.Point(127, 22);
            this.chbPineapple.Name = "chbPineapple";
            this.chbPineapple.Size = new System.Drawing.Size(78, 19);
            this.chbPineapple.TabIndex = 4;
            this.chbPineapple.Text = "Pineapple";
            this.chbPineapple.UseVisualStyleBackColor = true;
            this.chbPineapple.CheckedChanged += new System.EventHandler(this.ChbIngredientCheckedChangedEH);
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbMushrooms.Location = new System.Drawing.Point(6, 97);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(90, 19);
            this.chbMushrooms.TabIndex = 3;
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            this.chbMushrooms.CheckedChanged += new System.EventHandler(this.ChbIngredientCheckedChangedEH);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbOlives.Location = new System.Drawing.Point(6, 72);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(58, 19);
            this.chbOlives.TabIndex = 2;
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.ChbIngredientCheckedChangedEH);
            // 
            // chbBacon
            // 
            this.chbBacon.AutoSize = true;
            this.chbBacon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbBacon.Location = new System.Drawing.Point(6, 47);
            this.chbBacon.Name = "chbBacon";
            this.chbBacon.Size = new System.Drawing.Size(58, 19);
            this.chbBacon.TabIndex = 1;
            this.chbBacon.Text = "Bacon";
            this.chbBacon.UseVisualStyleBackColor = true;
            this.chbBacon.CheckedChanged += new System.EventHandler(this.ChbIngredientCheckedChangedEH);
            // 
            // chbPepperoni
            // 
            this.chbPepperoni.AutoSize = true;
            this.chbPepperoni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbPepperoni.Location = new System.Drawing.Point(6, 22);
            this.chbPepperoni.Name = "chbPepperoni";
            this.chbPepperoni.Size = new System.Drawing.Size(80, 19);
            this.chbPepperoni.TabIndex = 0;
            this.chbPepperoni.Text = "Pepperoni";
            this.chbPepperoni.UseVisualStyleBackColor = true;
            this.chbPepperoni.CheckedChanged += new System.EventHandler(this.ChbIngredientCheckedChangedEH);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Strange Add Ons";
            // 
            // lsbStrangeAddOns
            // 
            this.lsbStrangeAddOns.FormattingEnabled = true;
            this.lsbStrangeAddOns.ItemHeight = 15;
            this.lsbStrangeAddOns.Items.AddRange(new object[] {
            "Hotdogs",
            "Eggplant",
            "Artichoke Hearts",
            "Eggs",
            "Peanut Butter",
            "Prosciutto",
            "Honey",
            "Chili Thread"});
            this.lsbStrangeAddOns.Location = new System.Drawing.Point(13, 209);
            this.lsbStrangeAddOns.Name = "lsbStrangeAddOns";
            this.lsbStrangeAddOns.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbStrangeAddOns.Size = new System.Drawing.Size(120, 124);
            this.lsbStrangeAddOns.TabIndex = 4;
            this.lsbStrangeAddOns.SelectedIndexChanged += new System.EventHandler(this.LsbStrangeAddOnsSelectedIndexChangedEH);
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdoGlutenFree);
            this.grpCrust.Controls.Add(this.rdoStuffedCrust);
            this.grpCrust.Controls.Add(this.rdoDeepDish);
            this.grpCrust.Controls.Add(this.rdoThinCrust);
            this.grpCrust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCrust.Location = new System.Drawing.Point(140, 203);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(121, 130);
            this.grpCrust.TabIndex = 5;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            // 
            // rdoGlutenFree
            // 
            this.rdoGlutenFree.AutoSize = true;
            this.rdoGlutenFree.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoGlutenFree.Location = new System.Drawing.Point(7, 98);
            this.rdoGlutenFree.Name = "rdoGlutenFree";
            this.rdoGlutenFree.Size = new System.Drawing.Size(86, 19);
            this.rdoGlutenFree.TabIndex = 3;
            this.rdoGlutenFree.TabStop = true;
            this.rdoGlutenFree.Text = "Gluten Free";
            this.rdoGlutenFree.UseVisualStyleBackColor = true;
            this.rdoGlutenFree.CheckedChanged += new System.EventHandler(this.RdoCrustCheckedChangedEH);
            // 
            // rdoStuffedCrust
            // 
            this.rdoStuffedCrust.AutoSize = true;
            this.rdoStuffedCrust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoStuffedCrust.Location = new System.Drawing.Point(7, 72);
            this.rdoStuffedCrust.Name = "rdoStuffedCrust";
            this.rdoStuffedCrust.Size = new System.Drawing.Size(93, 19);
            this.rdoStuffedCrust.TabIndex = 2;
            this.rdoStuffedCrust.TabStop = true;
            this.rdoStuffedCrust.Text = "Stuffed Crust";
            this.rdoStuffedCrust.UseVisualStyleBackColor = true;
            this.rdoStuffedCrust.CheckedChanged += new System.EventHandler(this.RdoCrustCheckedChangedEH);
            // 
            // rdoDeepDish
            // 
            this.rdoDeepDish.AutoSize = true;
            this.rdoDeepDish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoDeepDish.Location = new System.Drawing.Point(7, 47);
            this.rdoDeepDish.Name = "rdoDeepDish";
            this.rdoDeepDish.Size = new System.Drawing.Size(79, 19);
            this.rdoDeepDish.TabIndex = 1;
            this.rdoDeepDish.TabStop = true;
            this.rdoDeepDish.Text = "Deep Dish";
            this.rdoDeepDish.UseVisualStyleBackColor = true;
            this.rdoDeepDish.CheckedChanged += new System.EventHandler(this.RdoCrustCheckedChangedEH);
            // 
            // rdoThinCrust
            // 
            this.rdoThinCrust.AutoSize = true;
            this.rdoThinCrust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoThinCrust.Location = new System.Drawing.Point(7, 22);
            this.rdoThinCrust.Name = "rdoThinCrust";
            this.rdoThinCrust.Size = new System.Drawing.Size(80, 19);
            this.rdoThinCrust.TabIndex = 0;
            this.rdoThinCrust.TabStop = true;
            this.rdoThinCrust.Text = "Thin Crust";
            this.rdoThinCrust.UseVisualStyleBackColor = true;
            this.rdoThinCrust.CheckedChanged += new System.EventHandler(this.RdoCrustCheckedChangedEH);
            // 
            // grpExtraGoodies
            // 
            this.grpExtraGoodies.Controls.Add(this.lblCheese);
            this.grpExtraGoodies.Controls.Add(this.label5);
            this.grpExtraGoodies.Controls.Add(this.hsbCheese);
            this.grpExtraGoodies.Controls.Add(this.lblSauce);
            this.grpExtraGoodies.Controls.Add(this.label3);
            this.grpExtraGoodies.Controls.Add(this.hsbSauce);
            this.grpExtraGoodies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpExtraGoodies.Location = new System.Drawing.Point(13, 340);
            this.grpExtraGoodies.Name = "grpExtraGoodies";
            this.grpExtraGoodies.Size = new System.Drawing.Size(248, 100);
            this.grpExtraGoodies.TabIndex = 6;
            this.grpExtraGoodies.TabStop = false;
            this.grpExtraGoodies.Text = "Extra Goodies";
            // 
            // lblCheese
            // 
            this.lblCheese.AutoSize = true;
            this.lblCheese.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheese.Location = new System.Drawing.Point(117, 60);
            this.lblCheese.Name = "lblCheese";
            this.lblCheese.Size = new System.Drawing.Size(19, 15);
            this.lblCheese.TabIndex = 5;
            this.lblCheese.Text = "00";
            this.lblCheese.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount of Cheese";
            // 
            // hsbCheese
            // 
            this.hsbCheese.Location = new System.Drawing.Point(6, 75);
            this.hsbCheese.Name = "hsbCheese";
            this.hsbCheese.Size = new System.Drawing.Size(236, 17);
            this.hsbCheese.TabIndex = 3;
            // 
            // lblSauce
            // 
            this.lblSauce.AutoSize = true;
            this.lblSauce.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSauce.Location = new System.Drawing.Point(117, 23);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.Size = new System.Drawing.Size(19, 15);
            this.lblSauce.TabIndex = 2;
            this.lblSauce.Text = "00";
            this.lblSauce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount of Sauce";
            // 
            // hsbSauce
            // 
            this.hsbSauce.Location = new System.Drawing.Point(6, 38);
            this.hsbSauce.Name = "hsbSauce";
            this.hsbSauce.Size = new System.Drawing.Size(236, 17);
            this.hsbSauce.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Delivery Time";
            // 
            // dtpDeliveryTime
            // 
            this.dtpDeliveryTime.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpDeliveryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryTime.Location = new System.Drawing.Point(13, 471);
            this.dtpDeliveryTime.Name = "dtpDeliveryTime";
            this.dtpDeliveryTime.Size = new System.Drawing.Size(248, 23);
            this.dtpDeliveryTime.TabIndex = 8;
            this.dtpDeliveryTime.ValueChanged += new System.EventHandler(this.DtpDeliveryTimeValueChangedEH);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pizza Box Color";
            // 
            // picPizzaBoxColor
            // 
            this.picPizzaBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPizzaBoxColor.Location = new System.Drawing.Point(13, 525);
            this.picPizzaBoxColor.Name = "picPizzaBoxColor";
            this.picPizzaBoxColor.Size = new System.Drawing.Size(248, 50);
            this.picPizzaBoxColor.TabIndex = 10;
            this.picPizzaBoxColor.TabStop = false;
            this.picPizzaBoxColor.Click += new System.EventHandler(this.PicPizzaBoxColorClickEH);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pizza Price:";
            // 
            // lblPizzaPrice
            // 
            this.lblPizzaPrice.AutoSize = true;
            this.lblPizzaPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPizzaPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPizzaPrice.Location = new System.Drawing.Point(87, 587);
            this.lblPizzaPrice.Name = "lblPizzaPrice";
            this.lblPizzaPrice.Size = new System.Drawing.Size(19, 15);
            this.lblPizzaPrice.TabIndex = 12;
            this.lblPizzaPrice.Text = "$0";
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(13, 616);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 13;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.BtnResetFormClickEH);
            // 
            // btnCreatePizza
            // 
            this.btnCreatePizza.Location = new System.Drawing.Point(94, 616);
            this.btnCreatePizza.Name = "btnCreatePizza";
            this.btnCreatePizza.Size = new System.Drawing.Size(85, 23);
            this.btnCreatePizza.TabIndex = 14;
            this.btnCreatePizza.Text = "Create Pizza";
            this.btnCreatePizza.UseVisualStyleBackColor = true;
            this.btnCreatePizza.Click += new System.EventHandler(this.BtnCreatePizzaClickEH);
            // 
            // btnSeeFullOrder
            // 
            this.btnSeeFullOrder.Location = new System.Drawing.Point(185, 616);
            this.btnSeeFullOrder.Name = "btnSeeFullOrder";
            this.btnSeeFullOrder.Size = new System.Drawing.Size(95, 23);
            this.btnSeeFullOrder.TabIndex = 15;
            this.btnSeeFullOrder.Text = "See Full Order";
            this.btnSeeFullOrder.UseVisualStyleBackColor = true;
            this.btnSeeFullOrder.Click += new System.EventHandler(this.BtnSeeFullOrderClickEH);
            // 
            // FrmPizzaMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 661);
            this.Controls.Add(this.btnSeeFullOrder);
            this.Controls.Add(this.btnCreatePizza);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.lblPizzaPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picPizzaBoxColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDeliveryTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpExtraGoodies);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.lsbStrangeAddOns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpIngredients);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmPizzaMaker";
            this.Text = "Pizza Maker";
            this.grpIngredients.ResumeLayout(false);
            this.grpIngredients.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpExtraGoodies.ResumeLayout(false);
            this.grpExtraGoodies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpIngredients;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbPeppers;
        private System.Windows.Forms.CheckBox chbSausage;
        private System.Windows.Forms.CheckBox chbPineapple;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbBacon;
        private System.Windows.Forms.CheckBox chbPepperoni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbStrangeAddOns;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rdoGlutenFree;
        private System.Windows.Forms.RadioButton rdoStuffedCrust;
        private System.Windows.Forms.RadioButton rdoDeepDish;
        private System.Windows.Forms.RadioButton rdoThinCrust;
        private System.Windows.Forms.GroupBox grpExtraGoodies;
        private System.Windows.Forms.HScrollBar hsbSauce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.Label lblCheese;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hsbCheese;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picPizzaBoxColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPizzaPrice;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnCreatePizza;
        private System.Windows.Forms.Button btnSeeFullOrder;
    }
}
