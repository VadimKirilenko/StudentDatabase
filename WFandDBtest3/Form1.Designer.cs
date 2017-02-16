namespace WFandDBtest3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label first_NameLabel1;
            System.Windows.Forms.Label last_NameLabel1;
            System.Windows.Forms.Label ageLabel1;
            this.studentDataSet = new WFandDBtest3.StudentDataSet();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new WFandDBtest3.StudentDataSetTableAdapters.StudentInfoTableAdapter();
            this.tableAdapterManager = new WFandDBtest3.StudentDataSetTableAdapters.TableAdapterManager();
            this.studentInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studentInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.first_NameTextBox1 = new System.Windows.Forms.TextBox();
            this.last_NameTextBox1 = new System.Windows.Forms.TextBox();
            this.ageTextBox1 = new System.Windows.Forms.TextBox();
            this.studentInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            idLabel1 = new System.Windows.Forms.Label();
            first_NameLabel1 = new System.Windows.Forms.Label();
            last_NameLabel1 = new System.Windows.Forms.Label();
            ageLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingNavigator)).BeginInit();
            this.studentInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.studentDataSet;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentInfoTableAdapter = this.studentInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = WFandDBtest3.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentInfoBindingNavigator
            // 
            this.studentInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentInfoBindingNavigator.BindingSource = this.studentInfoBindingSource;
            this.studentInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentInfoBindingNavigatorSaveItem});
            this.studentInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentInfoBindingNavigator.Name = "studentInfoBindingNavigator";
            this.studentInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentInfoBindingNavigator.Size = new System.Drawing.Size(921, 25);
            this.studentInfoBindingNavigator.TabIndex = 0;
            this.studentInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // studentInfoBindingNavigatorSaveItem
            // 
            this.studentInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentInfoBindingNavigatorSaveItem.Image")));
            this.studentInfoBindingNavigatorSaveItem.Name = "studentInfoBindingNavigatorSaveItem";
            this.studentInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.studentInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.studentInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentInfoBindingNavigatorSaveItem_Click);
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(31, 139);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 9;
            idLabel1.Text = "Id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(98, 136);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 10;
            // 
            // first_NameLabel1
            // 
            first_NameLabel1.AutoSize = true;
            first_NameLabel1.Location = new System.Drawing.Point(31, 165);
            first_NameLabel1.Name = "first_NameLabel1";
            first_NameLabel1.Size = new System.Drawing.Size(60, 13);
            first_NameLabel1.TabIndex = 11;
            first_NameLabel1.Text = "First Name:";
            // 
            // first_NameTextBox1
            // 
            this.first_NameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "First Name", true));
            this.first_NameTextBox1.Location = new System.Drawing.Point(98, 162);
            this.first_NameTextBox1.Name = "first_NameTextBox1";
            this.first_NameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox1.TabIndex = 12;
            // 
            // last_NameLabel1
            // 
            last_NameLabel1.AutoSize = true;
            last_NameLabel1.Location = new System.Drawing.Point(31, 191);
            last_NameLabel1.Name = "last_NameLabel1";
            last_NameLabel1.Size = new System.Drawing.Size(61, 13);
            last_NameLabel1.TabIndex = 13;
            last_NameLabel1.Text = "Last Name:";
            // 
            // last_NameTextBox1
            // 
            this.last_NameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "Last Name", true));
            this.last_NameTextBox1.Location = new System.Drawing.Point(98, 188);
            this.last_NameTextBox1.Name = "last_NameTextBox1";
            this.last_NameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox1.TabIndex = 14;
            // 
            // ageLabel1
            // 
            ageLabel1.AutoSize = true;
            ageLabel1.Location = new System.Drawing.Point(31, 217);
            ageLabel1.Name = "ageLabel1";
            ageLabel1.Size = new System.Drawing.Size(29, 13);
            ageLabel1.TabIndex = 15;
            ageLabel1.Text = "Age:";
            // 
            // ageTextBox1
            // 
            this.ageTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "Age", true));
            this.ageTextBox1.Location = new System.Drawing.Point(98, 214);
            this.ageTextBox1.Name = "ageTextBox1";
            this.ageTextBox1.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox1.TabIndex = 16;
            // 
            // studentInfoDataGridView
            // 
            this.studentInfoDataGridView.AutoGenerateColumns = false;
            this.studentInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.studentInfoDataGridView.DataSource = this.studentInfoBindingSource;
            this.studentInfoDataGridView.Location = new System.Drawing.Point(278, 47);
            this.studentInfoDataGridView.Name = "studentInfoDataGridView";
            this.studentInfoDataGridView.Size = new System.Drawing.Size(605, 471);
            this.studentInfoDataGridView.TabIndex = 16;
            this.studentInfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentInfoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn4.HeaderText = "Age";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 546);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentInfoDataGridView);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(first_NameLabel1);
            this.Controls.Add(this.first_NameTextBox1);
            this.Controls.Add(last_NameLabel1);
            this.Controls.Add(this.last_NameTextBox1);
            this.Controls.Add(ageLabel1);
            this.Controls.Add(this.ageTextBox1);
            this.Controls.Add(this.studentInfoBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingNavigator)).EndInit();
            this.studentInfoBindingNavigator.ResumeLayout(false);
            this.studentInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox first_NameTextBox1;
        private System.Windows.Forms.TextBox last_NameTextBox1;
        private System.Windows.Forms.TextBox ageTextBox1;
        private System.Windows.Forms.DataGridView studentInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

