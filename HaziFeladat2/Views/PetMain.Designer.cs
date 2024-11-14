namespace HaziFeladat2.Views
{
    partial class PetMain
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
            menuStrip1 = new MenuStrip();
            petsToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            szeretedToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            saveFileDialog1 = new SaveFileDialog();
            databaseToolStripMenuItem = new ToolStripMenuItem();
            selectDatabaseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { petsToolStripMenuItem, aboutToolStripMenuItem, databaseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // petsToolStripMenuItem
            // 
            petsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listToolStripMenuItem, addToolStripMenuItem, exportToolStripMenuItem });
            petsToolStripMenuItem.Name = "petsToolStripMenuItem";
            petsToolStripMenuItem.Size = new Size(41, 20);
            petsToolStripMenuItem.Text = "Pets";
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(108, 22);
            listToolStripMenuItem.Text = "List";
            listToolStripMenuItem.Click += listToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(108, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(108, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { szeretedToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // szeretedToolStripMenuItem
            // 
            szeretedToolStripMenuItem.Name = "szeretedToolStripMenuItem";
            szeretedToolStripMenuItem.Size = new Size(185, 22);
            szeretedToolStripMenuItem.Text = "Szereted az állatokat?";
            szeretedToolStripMenuItem.Click += szeretedToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.Brown;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 426);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // databaseToolStripMenuItem
            // 
            databaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectDatabaseToolStripMenuItem });
            databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            databaseToolStripMenuItem.Size = new Size(67, 20);
            databaseToolStripMenuItem.Text = "Database";
            // 
            // selectDatabaseToolStripMenuItem
            // 
            selectDatabaseToolStripMenuItem.Name = "selectDatabaseToolStripMenuItem";
            selectDatabaseToolStripMenuItem.Size = new Size(180, 22);
            selectDatabaseToolStripMenuItem.Text = "SelectDatabase";
            selectDatabaseToolStripMenuItem.Click += selectDatabaseToolStripMenuItem_Click;
            // 
            // PetMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PetMain";
            Text = "PetMain";
            Load += PetMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem petsToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem szeretedToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem selectDatabaseToolStripMenuItem;
    }
}