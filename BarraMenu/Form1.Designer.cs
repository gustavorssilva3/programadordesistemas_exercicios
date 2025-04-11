
namespace SlideBar
{
    partial class frmSideBar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.MenuTransition = new System.Windows.Forms.Timer(this.components);
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlHistorico = new System.Windows.Forms.Panel();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.BtnSlide = new System.Windows.Forms.PictureBox();
            this.pnlContas = new System.Windows.Forms.Panel();
            this.btnContas = new System.Windows.Forms.Button();
            this.pnlPerfilUsuario = new System.Windows.Forms.Panel();
            this.btnPerfilUsuario = new System.Windows.Forms.Button();
            this.pnlRelatorios = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.Panel();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnSubMenu = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.FlowPanelSlide = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDashboard.SuspendLayout();
            this.pnlHistorico.SuspendLayout();
            this.pnlSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).BeginInit();
            this.pnlContas.SuspendLayout();
            this.pnlPerfilUsuario.SuspendLayout();
            this.pnlRelatorios.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.FlowPanelSlide.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.Interval = 10;
            this.SidebarTransition.Tick += new System.EventHandler(this.SidebarTransition_Tick);
            // 
            // MenuTransition
            // 
            this.MenuTransition.Interval = 10;
            this.MenuTransition.Tick += new System.EventHandler(this.MenuTransition_Tick);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.btnDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(0, 93);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(214, 56);
            this.pnlDashboard.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::SlideBar.Properties.Resources.icons8_dashboard_32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-15, -9);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(251, 75);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "                    Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlHistorico
            // 
            this.pnlHistorico.Controls.Add(this.btnHistorico);
            this.pnlHistorico.Location = new System.Drawing.Point(0, 205);
            this.pnlHistorico.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistorico.Name = "pnlHistorico";
            this.pnlHistorico.Size = new System.Drawing.Size(214, 56);
            this.pnlHistorico.TabIndex = 5;
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Black;
            this.btnHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Image = global::SlideBar.Properties.Resources.icons8_clock_32;
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(-15, -9);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHistorico.Size = new System.Drawing.Size(251, 75);
            this.btnHistorico.TabIndex = 2;
            this.btnHistorico.Text = "                    Historico";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.UseVisualStyleBackColor = false;
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.Black;
            this.pnlSlide.Controls.Add(this.BtnSlide);
            this.pnlSlide.Location = new System.Drawing.Point(0, 0);
            this.pnlSlide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(214, 39);
            this.pnlSlide.TabIndex = 3;
            // 
            // BtnSlide
            // 
            this.BtnSlide.Image = global::SlideBar.Properties.Resources.icons8_menu_32__1_;
            this.BtnSlide.Location = new System.Drawing.Point(14, 3);
            this.BtnSlide.Name = "BtnSlide";
            this.BtnSlide.Size = new System.Drawing.Size(32, 32);
            this.BtnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnSlide.TabIndex = 1;
            this.BtnSlide.TabStop = false;
            this.BtnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // pnlContas
            // 
            this.pnlContas.Controls.Add(this.btnContas);
            this.pnlContas.Location = new System.Drawing.Point(0, 149);
            this.pnlContas.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContas.Name = "pnlContas";
            this.pnlContas.Size = new System.Drawing.Size(214, 56);
            this.pnlContas.TabIndex = 4;
            // 
            // btnContas
            // 
            this.btnContas.BackColor = System.Drawing.Color.Black;
            this.btnContas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContas.ForeColor = System.Drawing.Color.White;
            this.btnContas.Image = global::SlideBar.Properties.Resources.icons8_box_32__1_;
            this.btnContas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContas.Location = new System.Drawing.Point(-15, -9);
            this.btnContas.Name = "btnContas";
            this.btnContas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnContas.Size = new System.Drawing.Size(251, 75);
            this.btnContas.TabIndex = 2;
            this.btnContas.Text = "                    Contas";
            this.btnContas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContas.UseVisualStyleBackColor = false;
            // 
            // pnlPerfilUsuario
            // 
            this.pnlPerfilUsuario.Controls.Add(this.btnPerfilUsuario);
            this.pnlPerfilUsuario.Location = new System.Drawing.Point(0, 261);
            this.pnlPerfilUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPerfilUsuario.Name = "pnlPerfilUsuario";
            this.pnlPerfilUsuario.Size = new System.Drawing.Size(214, 56);
            this.pnlPerfilUsuario.TabIndex = 6;
            // 
            // btnPerfilUsuario
            // 
            this.btnPerfilUsuario.BackColor = System.Drawing.Color.Black;
            this.btnPerfilUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPerfilUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilUsuario.ForeColor = System.Drawing.Color.White;
            this.btnPerfilUsuario.Image = global::SlideBar.Properties.Resources.icons8_user_32;
            this.btnPerfilUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilUsuario.Location = new System.Drawing.Point(-15, -9);
            this.btnPerfilUsuario.Name = "btnPerfilUsuario";
            this.btnPerfilUsuario.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPerfilUsuario.Size = new System.Drawing.Size(251, 75);
            this.btnPerfilUsuario.TabIndex = 2;
            this.btnPerfilUsuario.Text = "                    Perfil do Usuário";
            this.btnPerfilUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilUsuario.UseVisualStyleBackColor = false;
            // 
            // pnlRelatorios
            // 
            this.pnlRelatorios.Controls.Add(this.btnRelatorios);
            this.pnlRelatorios.Location = new System.Drawing.Point(0, 317);
            this.pnlRelatorios.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRelatorios.Name = "pnlRelatorios";
            this.pnlRelatorios.Size = new System.Drawing.Size(214, 56);
            this.pnlRelatorios.TabIndex = 7;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.Black;
            this.btnRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Image = global::SlideBar.Properties.Resources.icons8_graph_32;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(-15, -9);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(251, 75);
            this.btnRelatorios.TabIndex = 2;
            this.btnRelatorios.Text = "                    Relatorios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.Black;
            this.menuContainer.Controls.Add(this.pnlSubMenu);
            this.menuContainer.Controls.Add(this.pnlMenu);
            this.menuContainer.Location = new System.Drawing.Point(0, 39);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(214, 54);
            this.menuContainer.TabIndex = 9;
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.Gray;
            this.pnlSubMenu.Controls.Add(this.btnSubMenu);
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 55);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(214, 56);
            this.pnlSubMenu.TabIndex = 8;
            // 
            // btnSubMenu
            // 
            this.btnSubMenu.BackColor = System.Drawing.Color.Black;
            this.btnSubMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenu.ForeColor = System.Drawing.Color.White;
            this.btnSubMenu.Image = global::SlideBar.Properties.Resources.icons8_arrow_24;
            this.btnSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu.Location = new System.Drawing.Point(-4, -9);
            this.btnSubMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubMenu.Name = "btnSubMenu";
            this.btnSubMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSubMenu.Size = new System.Drawing.Size(251, 75);
            this.btnSubMenu.TabIndex = 2;
            this.btnSubMenu.Text = "                    Sub Menu";
            this.btnSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu.UseVisualStyleBackColor = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(214, 56);
            this.pnlMenu.TabIndex = 7;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::SlideBar.Properties.Resources.icons8_home_32;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-15, -9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(251, 75);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "                    Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // FlowPanelSlide
            // 
            this.FlowPanelSlide.BackColor = System.Drawing.Color.Black;
            this.FlowPanelSlide.Controls.Add(this.pnlSlide);
            this.FlowPanelSlide.Controls.Add(this.menuContainer);
            this.FlowPanelSlide.Controls.Add(this.pnlDashboard);
            this.FlowPanelSlide.Controls.Add(this.pnlContas);
            this.FlowPanelSlide.Controls.Add(this.pnlHistorico);
            this.FlowPanelSlide.Controls.Add(this.pnlPerfilUsuario);
            this.FlowPanelSlide.Controls.Add(this.pnlRelatorios);
            this.FlowPanelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowPanelSlide.Location = new System.Drawing.Point(0, 0);
            this.FlowPanelSlide.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanelSlide.Name = "FlowPanelSlide";
            this.FlowPanelSlide.Size = new System.Drawing.Size(200, 423);
            this.FlowPanelSlide.TabIndex = 10;
            // 
            // frmSideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(828, 423);
            this.Controls.Add(this.FlowPanelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmSideBar";
            this.Text = "Menu";
            this.pnlDashboard.ResumeLayout(false);
            this.pnlHistorico.ResumeLayout(false);
            this.pnlSlide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).EndInit();
            this.pnlContas.ResumeLayout(false);
            this.pnlPerfilUsuario.ResumeLayout(false);
            this.pnlRelatorios.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.FlowPanelSlide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SidebarTransition;
        private System.Windows.Forms.Timer MenuTransition;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlHistorico;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.PictureBox BtnSlide;
        private System.Windows.Forms.Panel pnlContas;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Panel pnlPerfilUsuario;
        private System.Windows.Forms.Button btnPerfilUsuario;
        private System.Windows.Forms.Panel pnlRelatorios;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Button btnSubMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelSlide;
    }
}

