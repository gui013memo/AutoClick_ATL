
namespace Auto_click_atlas_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_instrucoes = new System.Windows.Forms.TextBox();
            this.lb_instrucoes = new System.Windows.Forms.Label();
            this.tb_repete = new System.Windows.Forms.TextBox();
            this.btn_Record = new System.Windows.Forms.Button();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.lb_X = new System.Windows.Forms.Label();
            this.lb_Y = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.tb_interval = new System.Windows.Forms.TextBox();
            this.lb_interval = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lb_stats = new System.Windows.Forms.Label();
            this.tb_restante = new System.Windows.Forms.TextBox();
            this.lb_restante = new System.Windows.Forms.Label();
            this.cb_enable_btns = new System.Windows.Forms.CheckBox();
            this.lb_instructions_quantity = new System.Windows.Forms.Label();
            this.gb_pause = new System.Windows.Forms.GroupBox();
            this.btn_compare_greater = new System.Windows.Forms.Button();
            this.btn_compare_less = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Previsao = new System.Windows.Forms.TextBox();
            this.lb_prazo = new System.Windows.Forms.Label();
            this.lb_Arquivo_IL_util = new System.Windows.Forms.Label();
            this.lb_Arquivo_IL = new System.Windows.Forms.Label();
            this.tb_memoryValue = new System.Windows.Forms.TextBox();
            this.btn_compare_equal = new System.Windows.Forms.Button();
            this.lb_compareResult = new System.Windows.Forms.Label();
            this.tb_Consulta = new System.Windows.Forms.TextBox();
            this.lb_Consulta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_modo = new System.Windows.Forms.Label();
            this.lb_currentMode = new System.Windows.Forms.Label();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.cb_multi_Instructions = new System.Windows.Forms.CheckBox();
            this.lb_Duplo = new System.Windows.Forms.Label();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.lb_multiInstrucoes_2 = new System.Windows.Forms.Label();
            this.btn_modo_1 = new System.Windows.Forms.Button();
            this.btn_modo_2 = new System.Windows.Forms.Button();
            this.btn_modo_3 = new System.Windows.Forms.Button();
            this.btn_modo_4 = new System.Windows.Forms.Button();
            this.btn_modo_5 = new System.Windows.Forms.Button();
            this.cb_consulta = new System.Windows.Forms.CheckBox();
            this.lb_consulta2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_pause.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_instrucoes
            // 
            this.tb_instrucoes.Location = new System.Drawing.Point(6, 82);
            this.tb_instrucoes.Multiline = true;
            this.tb_instrucoes.Name = "tb_instrucoes";
            this.tb_instrucoes.ReadOnly = true;
            this.tb_instrucoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_instrucoes.Size = new System.Drawing.Size(169, 99);
            this.tb_instrucoes.TabIndex = 5;
            // 
            // lb_instrucoes
            // 
            this.lb_instrucoes.AutoSize = true;
            this.lb_instrucoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_instrucoes.Location = new System.Drawing.Point(5, 56);
            this.lb_instrucoes.Name = "lb_instrucoes";
            this.lb_instrucoes.Size = new System.Drawing.Size(88, 21);
            this.lb_instrucoes.TabIndex = 6;
            this.lb_instrucoes.Text = "Instruções";
            // 
            // tb_repete
            // 
            this.tb_repete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_repete.Location = new System.Drawing.Point(310, 197);
            this.tb_repete.Name = "tb_repete";
            this.tb_repete.Size = new System.Drawing.Size(51, 23);
            this.tb_repete.TabIndex = 7;
            this.tb_repete.Text = "0";
            this.tb_repete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_repete.TextChanged += new System.EventHandler(this.tb_repete_TextChanged);
            // 
            // btn_Record
            // 
            this.btn_Record.BackColor = System.Drawing.Color.White;
            this.btn_Record.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Record.FlatAppearance.BorderSize = 10;
            this.btn_Record.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Record.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Record.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Record.ForeColor = System.Drawing.Color.Black;
            this.btn_Record.Location = new System.Drawing.Point(191, 327);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(115, 67);
            this.btn_Record.TabIndex = 10;
            this.btn_Record.Text = "REC (G)";
            this.btn_Record.UseVisualStyleBackColor = false;
            this.btn_Record.Click += new System.EventHandler(this.btn_Record_Click);
            // 
            // tb_X
            // 
            this.tb_X.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_X.Location = new System.Drawing.Point(112, 187);
            this.tb_X.Name = "tb_X";
            this.tb_X.ReadOnly = true;
            this.tb_X.Size = new System.Drawing.Size(51, 23);
            this.tb_X.TabIndex = 11;
            this.tb_X.Text = "0";
            this.tb_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Y
            // 
            this.tb_Y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Y.Location = new System.Drawing.Point(32, 187);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.ReadOnly = true;
            this.tb_Y.Size = new System.Drawing.Size(51, 23);
            this.tb_Y.TabIndex = 12;
            this.tb_Y.Text = "0";
            this.tb_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_X
            // 
            this.lb_X.AutoSize = true;
            this.lb_X.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_X.Location = new System.Drawing.Point(89, 194);
            this.lb_X.Name = "lb_X";
            this.lb_X.Size = new System.Drawing.Size(17, 15);
            this.lb_X.TabIndex = 13;
            this.lb_X.Text = "X:";
            // 
            // lb_Y
            // 
            this.lb_Y.AutoSize = true;
            this.lb_Y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Y.Location = new System.Drawing.Point(9, 194);
            this.lb_Y.Name = "lb_Y";
            this.lb_Y.Size = new System.Drawing.Size(17, 15);
            this.lb_Y.TabIndex = 14;
            this.lb_Y.Text = "Y:";
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Start.FlatAppearance.BorderSize = 10;
            this.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(12, 336);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(172, 67);
            this.btn_Start.TabIndex = 15;
            this.btn_Start.Text = "START (S)";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Gold;
            this.btn_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Stop.FlatAppearance.BorderSize = 20;
            this.btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Stop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Stop.ForeColor = System.Drawing.Color.Black;
            this.btn_Stop.Location = new System.Drawing.Point(11, 409);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(172, 106);
            this.btn_Stop.TabIndex = 16;
            this.btn_Stop.Text = "Stop (Space)";
            this.btn_Stop.UseVisualStyleBackColor = false;
            // 
            // tb_interval
            // 
            this.tb_interval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_interval.Location = new System.Drawing.Point(310, 154);
            this.tb_interval.Name = "tb_interval";
            this.tb_interval.Size = new System.Drawing.Size(51, 23);
            this.tb_interval.TabIndex = 17;
            this.tb_interval.Text = "0";
            this.tb_interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_interval.TextChanged += new System.EventHandler(this.tb_interval_TextChanged);
            // 
            // lb_interval
            // 
            this.lb_interval.AutoSize = true;
            this.lb_interval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_interval.Location = new System.Drawing.Point(310, 180);
            this.lb_interval.Name = "lb_interval";
            this.lb_interval.Size = new System.Drawing.Size(53, 15);
            this.lb_interval.TabIndex = 18;
            this.lb_interval.Text = "Intervalo";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Clear.FlatAppearance.BorderSize = 2;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.Location = new System.Drawing.Point(316, 327);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(78, 67);
            this.btn_Clear.TabIndex = 21;
            this.btn_Clear.Text = "LIMPA (L)";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lb_stats
            // 
            this.lb_stats.AutoSize = true;
            this.lb_stats.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_stats.Location = new System.Drawing.Point(185, -9);
            this.lb_stats.Name = "lb_stats";
            this.lb_stats.Size = new System.Drawing.Size(73, 30);
            this.lb_stats.TabIndex = 22;
            this.lb_stats.Text = "Status";
            // 
            // tb_restante
            // 
            this.tb_restante.Enabled = false;
            this.tb_restante.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_restante.Location = new System.Drawing.Point(188, 46);
            this.tb_restante.Name = "tb_restante";
            this.tb_restante.ReadOnly = true;
            this.tb_restante.Size = new System.Drawing.Size(70, 31);
            this.tb_restante.TabIndex = 23;
            this.tb_restante.Text = "0";
            this.tb_restante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_restante
            // 
            this.lb_restante.AutoSize = true;
            this.lb_restante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_restante.Location = new System.Drawing.Point(189, 19);
            this.lb_restante.Name = "lb_restante";
            this.lb_restante.Size = new System.Drawing.Size(70, 21);
            this.lb_restante.TabIndex = 24;
            this.lb_restante.Text = "Restante";
            // 
            // cb_enable_btns
            // 
            this.cb_enable_btns.AutoSize = true;
            this.cb_enable_btns.BackColor = System.Drawing.Color.Gold;
            this.cb_enable_btns.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cb_enable_btns.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_enable_btns.Location = new System.Drawing.Point(187, 284);
            this.cb_enable_btns.Name = "cb_enable_btns";
            this.cb_enable_btns.Size = new System.Drawing.Size(199, 24);
            this.cb_enable_btns.TabIndex = 27;
            this.cb_enable_btns.Text = "HABILITAR CONTROLES";
            this.cb_enable_btns.UseVisualStyleBackColor = false;
            this.cb_enable_btns.CheckedChanged += new System.EventHandler(this.cb_enable_btns_CheckedChanged);
            // 
            // lb_instructions_quantity
            // 
            this.lb_instructions_quantity.AutoSize = true;
            this.lb_instructions_quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_instructions_quantity.Location = new System.Drawing.Point(126, 56);
            this.lb_instructions_quantity.Name = "lb_instructions_quantity";
            this.lb_instructions_quantity.Size = new System.Drawing.Size(19, 21);
            this.lb_instructions_quantity.TabIndex = 29;
            this.lb_instructions_quantity.Text = "0";
            // 
            // gb_pause
            // 
            this.gb_pause.BackColor = System.Drawing.Color.Transparent;
            this.gb_pause.Controls.Add(this.btn_compare_greater);
            this.gb_pause.Controls.Add(this.btn_compare_less);
            this.gb_pause.Controls.Add(this.label1);
            this.gb_pause.Controls.Add(this.lb_Arquivo_IL_util);
            this.gb_pause.Controls.Add(this.lb_Arquivo_IL);
            this.gb_pause.Controls.Add(this.tb_memoryValue);
            this.gb_pause.Controls.Add(this.btn_compare_equal);
            this.gb_pause.Controls.Add(this.lb_compareResult);
            this.gb_pause.Controls.Add(this.tb_Consulta);
            this.gb_pause.Controls.Add(this.tb_restante);
            this.gb_pause.Controls.Add(this.tb_instrucoes);
            this.gb_pause.Controls.Add(this.lb_instrucoes);
            this.gb_pause.Controls.Add(this.lb_restante);
            this.gb_pause.Controls.Add(this.lb_Consulta);
            this.gb_pause.Controls.Add(this.lb_instructions_quantity);
            this.gb_pause.Controls.Add(this.lb_stats);
            this.gb_pause.Controls.Add(this.groupBox1);
            this.gb_pause.Controls.Add(this.tb_X);
            this.gb_pause.Controls.Add(this.tb_Y);
            this.gb_pause.Controls.Add(this.lb_X);
            this.gb_pause.Controls.Add(this.lb_Y);
            this.gb_pause.Controls.Add(this.tb_interval);
            this.gb_pause.Controls.Add(this.lb_interval);
            this.gb_pause.Controls.Add(this.tb_repete);
            this.gb_pause.Location = new System.Drawing.Point(2, 27);
            this.gb_pause.Name = "gb_pause";
            this.gb_pause.Size = new System.Drawing.Size(440, 241);
            this.gb_pause.TabIndex = 31;
            this.gb_pause.TabStop = false;
            // 
            // btn_compare_greater
            // 
            this.btn_compare_greater.BackColor = System.Drawing.Color.White;
            this.btn_compare_greater.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_compare_greater.FlatAppearance.BorderSize = 2;
            this.btn_compare_greater.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_compare_greater.Location = new System.Drawing.Point(348, 104);
            this.btn_compare_greater.Name = "btn_compare_greater";
            this.btn_compare_greater.Size = new System.Drawing.Size(36, 28);
            this.btn_compare_greater.TabIndex = 56;
            this.btn_compare_greater.Text = "<";
            this.btn_compare_greater.UseVisualStyleBackColor = false;
            // 
            // btn_compare_less
            // 
            this.btn_compare_less.BackColor = System.Drawing.Color.White;
            this.btn_compare_less.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_compare_less.FlatAppearance.BorderSize = 2;
            this.btn_compare_less.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_compare_less.Location = new System.Drawing.Point(308, 104);
            this.btn_compare_less.Name = "btn_compare_less";
            this.btn_compare_less.Size = new System.Drawing.Size(36, 28);
            this.btn_compare_less.TabIndex = 55;
            this.btn_compare_less.Text = ">";
            this.btn_compare_less.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Repetir";
            // 
            // tb_Previsao
            // 
            this.tb_Previsao.Enabled = false;
            this.tb_Previsao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Previsao.Location = new System.Drawing.Point(316, 579);
            this.tb_Previsao.Name = "tb_Previsao";
            this.tb_Previsao.ReadOnly = true;
            this.tb_Previsao.Size = new System.Drawing.Size(78, 31);
            this.tb_Previsao.TabIndex = 52;
            this.tb_Previsao.Text = "0";
            this.tb_Previsao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_prazo
            // 
            this.lb_prazo.AutoSize = true;
            this.lb_prazo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_prazo.Location = new System.Drawing.Point(319, 534);
            this.lb_prazo.Name = "lb_prazo";
            this.lb_prazo.Size = new System.Drawing.Size(68, 21);
            this.lb_prazo.TabIndex = 53;
            this.lb_prazo.Text = "Prazo p/";
            // 
            // lb_Arquivo_IL_util
            // 
            this.lb_Arquivo_IL_util.AutoSize = true;
            this.lb_Arquivo_IL_util.BackColor = System.Drawing.SystemColors.Highlight;
            this.lb_Arquivo_IL_util.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Arquivo_IL_util.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Arquivo_IL_util.Location = new System.Drawing.Point(10, 28);
            this.lb_Arquivo_IL_util.Name = "lb_Arquivo_IL_util";
            this.lb_Arquivo_IL_util.Size = new System.Drawing.Size(16, 21);
            this.lb_Arquivo_IL_util.TabIndex = 51;
            this.lb_Arquivo_IL_util.Text = "-";
            // 
            // lb_Arquivo_IL
            // 
            this.lb_Arquivo_IL.AutoSize = true;
            this.lb_Arquivo_IL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Arquivo_IL.Location = new System.Drawing.Point(6, 0);
            this.lb_Arquivo_IL.Name = "lb_Arquivo_IL";
            this.lb_Arquivo_IL.Size = new System.Drawing.Size(92, 21);
            this.lb_Arquivo_IL.TabIndex = 50;
            this.lb_Arquivo_IL.Text = "Arquivo IL:";
            // 
            // tb_memoryValue
            // 
            this.tb_memoryValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_memoryValue.Location = new System.Drawing.Point(268, 46);
            this.tb_memoryValue.Name = "tb_memoryValue";
            this.tb_memoryValue.Size = new System.Drawing.Size(118, 23);
            this.tb_memoryValue.TabIndex = 49;
            this.tb_memoryValue.Text = "0601-110163-001";
            this.tb_memoryValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_compare_equal
            // 
            this.btn_compare_equal.BackColor = System.Drawing.Color.White;
            this.btn_compare_equal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_compare_equal.FlatAppearance.BorderSize = 2;
            this.btn_compare_equal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_compare_equal.Location = new System.Drawing.Point(268, 104);
            this.btn_compare_equal.Name = "btn_compare_equal";
            this.btn_compare_equal.Size = new System.Drawing.Size(36, 28);
            this.btn_compare_equal.TabIndex = 46;
            this.btn_compare_equal.Text = "==";
            this.btn_compare_equal.UseVisualStyleBackColor = false;
            this.btn_compare_equal.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // lb_compareResult
            // 
            this.lb_compareResult.AutoSize = true;
            this.lb_compareResult.BackColor = System.Drawing.Color.Wheat;
            this.lb_compareResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_compareResult.Location = new System.Drawing.Point(358, 10);
            this.lb_compareResult.Name = "lb_compareResult";
            this.lb_compareResult.Size = new System.Drawing.Size(26, 30);
            this.lb_compareResult.TabIndex = 48;
            this.lb_compareResult.Text = "0";
            // 
            // tb_Consulta
            // 
            this.tb_Consulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Consulta.Location = new System.Drawing.Point(268, 75);
            this.tb_Consulta.Name = "tb_Consulta";
            this.tb_Consulta.Size = new System.Drawing.Size(118, 23);
            this.tb_Consulta.TabIndex = 43;
            this.tb_Consulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Consulta.TextChanged += new System.EventHandler(this.tb_Consulta_TextChanged);
            // 
            // lb_Consulta
            // 
            this.lb_Consulta.AutoSize = true;
            this.lb_Consulta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Consulta.Location = new System.Drawing.Point(264, 14);
            this.lb_Consulta.Name = "lb_Consulta";
            this.lb_Consulta.Size = new System.Drawing.Size(90, 25);
            this.lb_Consulta.TabIndex = 33;
            this.lb_Consulta.Text = "Consulta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lb_modo);
            this.groupBox1.Controls.Add(this.lb_currentMode);
            this.groupBox1.Location = new System.Drawing.Point(189, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 98);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // lb_modo
            // 
            this.lb_modo.AutoSize = true;
            this.lb_modo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_modo.Location = new System.Drawing.Point(6, 1);
            this.lb_modo.Name = "lb_modo";
            this.lb_modo.Size = new System.Drawing.Size(78, 32);
            this.lb_modo.TabIndex = 33;
            this.lb_modo.Text = "Modo";
            // 
            // lb_currentMode
            // 
            this.lb_currentMode.AutoSize = true;
            this.lb_currentMode.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_currentMode.Location = new System.Drawing.Point(-4, 29);
            this.lb_currentMode.Name = "lb_currentMode";
            this.lb_currentMode.Size = new System.Drawing.Size(98, 54);
            this.lb_currentMode.TabIndex = 34;
            this.lb_currentMode.Text = "STD";
            this.lb_currentMode.Click += new System.EventHandler(this.lb_currentMode_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.BackColor = System.Drawing.Color.White;
            this.btn_Continue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Continue.FlatAppearance.BorderSize = 10;
            this.btn_Continue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Continue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Continue.ForeColor = System.Drawing.Color.Black;
            this.btn_Continue.Location = new System.Drawing.Point(12, 255);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(169, 75);
            this.btn_Continue.TabIndex = 32;
            this.btn_Continue.Text = "Avançar (C)";
            this.btn_Continue.UseVisualStyleBackColor = false;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // cb_multi_Instructions
            // 
            this.cb_multi_Instructions.AutoSize = true;
            this.cb_multi_Instructions.Location = new System.Drawing.Point(34, 577);
            this.cb_multi_Instructions.Name = "cb_multi_Instructions";
            this.cb_multi_Instructions.Size = new System.Drawing.Size(15, 14);
            this.cb_multi_Instructions.TabIndex = 32;
            this.cb_multi_Instructions.UseVisualStyleBackColor = true;
            // 
            // lb_Duplo
            // 
            this.lb_Duplo.AutoSize = true;
            this.lb_Duplo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Duplo.Location = new System.Drawing.Point(13, 534);
            this.lb_Duplo.Name = "lb_Duplo";
            this.lb_Duplo.Size = new System.Drawing.Size(50, 21);
            this.lb_Duplo.TabIndex = 33;
            this.lb_Duplo.Text = "Multi ";
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.White;
            this.btn_Pause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pause.FlatAppearance.BorderSize = 2;
            this.btn_Pause.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Pause.Location = new System.Drawing.Point(192, 400);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(114, 33);
            this.btn_Pause.TabIndex = 34;
            this.btn_Pause.Text = "PAUSE (P)";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // lb_multiInstrucoes_2
            // 
            this.lb_multiInstrucoes_2.AutoSize = true;
            this.lb_multiInstrucoes_2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_multiInstrucoes_2.Location = new System.Drawing.Point(7, 555);
            this.lb_multiInstrucoes_2.Name = "lb_multiInstrucoes_2";
            this.lb_multiInstrucoes_2.Size = new System.Drawing.Size(72, 19);
            this.lb_multiInstrucoes_2.TabIndex = 36;
            this.lb_multiInstrucoes_2.Text = "Instruções";
            // 
            // btn_modo_1
            // 
            this.btn_modo_1.BackColor = System.Drawing.Color.LightGreen;
            this.btn_modo_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_modo_1.FlatAppearance.BorderSize = 2;
            this.btn_modo_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modo_1.Location = new System.Drawing.Point(192, 439);
            this.btn_modo_1.Name = "btn_modo_1";
            this.btn_modo_1.Size = new System.Drawing.Size(114, 35);
            this.btn_modo_1.TabIndex = 37;
            this.btn_modo_1.Text = "Modo #1 (6) ";
            this.btn_modo_1.UseVisualStyleBackColor = false;
            this.btn_modo_1.Click += new System.EventHandler(this.btn_modo_1_Click);
            // 
            // btn_modo_2
            // 
            this.btn_modo_2.BackColor = System.Drawing.Color.IndianRed;
            this.btn_modo_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_modo_2.FlatAppearance.BorderSize = 2;
            this.btn_modo_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modo_2.Location = new System.Drawing.Point(191, 480);
            this.btn_modo_2.Name = "btn_modo_2";
            this.btn_modo_2.Size = new System.Drawing.Size(116, 35);
            this.btn_modo_2.TabIndex = 38;
            this.btn_modo_2.Text = "Modo #2 (7)";
            this.btn_modo_2.UseVisualStyleBackColor = false;
            this.btn_modo_2.Click += new System.EventHandler(this.btn_modo_2_Click);
            // 
            // btn_modo_3
            // 
            this.btn_modo_3.BackColor = System.Drawing.Color.White;
            this.btn_modo_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_modo_3.FlatAppearance.BorderSize = 2;
            this.btn_modo_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modo_3.Location = new System.Drawing.Point(316, 400);
            this.btn_modo_3.Name = "btn_modo_3";
            this.btn_modo_3.Size = new System.Drawing.Size(78, 33);
            this.btn_modo_3.TabIndex = 39;
            this.btn_modo_3.Text = "M3 (8)";
            this.btn_modo_3.UseVisualStyleBackColor = false;
            this.btn_modo_3.Click += new System.EventHandler(this.btn_modo_3_Click);
            // 
            // btn_modo_4
            // 
            this.btn_modo_4.BackColor = System.Drawing.Color.White;
            this.btn_modo_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_modo_4.FlatAppearance.BorderSize = 2;
            this.btn_modo_4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modo_4.Location = new System.Drawing.Point(316, 439);
            this.btn_modo_4.Name = "btn_modo_4";
            this.btn_modo_4.Size = new System.Drawing.Size(78, 35);
            this.btn_modo_4.TabIndex = 40;
            this.btn_modo_4.Text = "M4 (9)";
            this.btn_modo_4.UseVisualStyleBackColor = false;
            this.btn_modo_4.Click += new System.EventHandler(this.btn_modo_4_Click);
            // 
            // btn_modo_5
            // 
            this.btn_modo_5.BackColor = System.Drawing.Color.White;
            this.btn_modo_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_modo_5.FlatAppearance.BorderSize = 2;
            this.btn_modo_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modo_5.Location = new System.Drawing.Point(316, 480);
            this.btn_modo_5.Name = "btn_modo_5";
            this.btn_modo_5.Size = new System.Drawing.Size(78, 35);
            this.btn_modo_5.TabIndex = 41;
            this.btn_modo_5.Text = "M5 (0)";
            this.btn_modo_5.UseVisualStyleBackColor = false;
            this.btn_modo_5.Click += new System.EventHandler(this.btn_modo_5_Click);
            // 
            // cb_consulta
            // 
            this.cb_consulta.AutoSize = true;
            this.cb_consulta.Location = new System.Drawing.Point(34, 621);
            this.cb_consulta.Name = "cb_consulta";
            this.cb_consulta.Size = new System.Drawing.Size(15, 14);
            this.cb_consulta.TabIndex = 44;
            this.cb_consulta.UseVisualStyleBackColor = true;
            // 
            // lb_consulta2
            // 
            this.lb_consulta2.AutoSize = true;
            this.lb_consulta2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_consulta2.Location = new System.Drawing.Point(7, 594);
            this.lb_consulta2.Name = "lb_consulta2";
            this.lb_consulta2.Size = new System.Drawing.Size(71, 21);
            this.lb_consulta2.TabIndex = 45;
            this.lb_consulta2.Text = "Consulta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.creditosToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarListaToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // carregarListaToolStripMenuItem
            // 
            this.carregarListaToolStripMenuItem.Name = "carregarListaToolStripMenuItem";
            this.carregarListaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.carregarListaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.carregarListaToolStripMenuItem.Text = "Carregar lista";
            this.carregarListaToolStripMenuItem.Click += new System.EventHandler(this.carregarListaToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditosToolStripMenuItem1});
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.creditosToolStripMenuItem.Text = "&Sobre";
            // 
            // creditosToolStripMenuItem1
            // 
            this.creditosToolStripMenuItem1.Name = "creditosToolStripMenuItem1";
            this.creditosToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.creditosToolStripMenuItem1.Text = "&Creditos";
            this.creditosToolStripMenuItem1.Click += new System.EventHandler(this.creditosToolStripMenuItem1_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "&Config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(316, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Conclusao";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.lb_consulta2);
            this.Controls.Add(this.cb_consulta);
            this.Controls.Add(this.lb_prazo);
            this.Controls.Add(this.tb_Previsao);
            this.Controls.Add(this.btn_modo_5);
            this.Controls.Add(this.btn_modo_4);
            this.Controls.Add(this.btn_modo_3);
            this.Controls.Add(this.btn_modo_2);
            this.Controls.Add(this.btn_modo_1);
            this.Controls.Add(this.lb_multiInstrucoes_2);
            this.Controls.Add(this.cb_enable_btns);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.lb_Duplo);
            this.Controls.Add(this.cb_multi_Instructions);
            this.Controls.Add(this.gb_pause);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Record);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(860, 393);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Auto Clicker ATLAS v4";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_pause.ResumeLayout(false);
            this.gb_pause.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_instrucoes;
        private System.Windows.Forms.TextBox tb_repete;
        private System.Windows.Forms.TextBox tb_instrucoes;
        private System.Windows.Forms.Button btn_Record;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.Label lb_X;
        private System.Windows.Forms.Label lb_Y;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox tb_interval;
        private System.Windows.Forms.Label lb_interval;
        private System.Windows.Forms.Label lb_acoes;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lb_stats;
        private System.Windows.Forms.TextBox tb_restante;
        private System.Windows.Forms.Label lb_restante;
        private System.Windows.Forms.CheckBox cb_fixo;
        private System.Windows.Forms.CheckBox cb_enable_btns;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.TextBox tb_clicks;
        private System.Windows.Forms.Label lb_instructions_quantity;
        private System.Windows.Forms.Label lb_prazo;
        private System.Windows.Forms.GroupBox gb_pause;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.CheckBox cb_multi_Instructions;
        private System.Windows.Forms.Label lb_Duplo;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Label lb_currentMode;
        private System.Windows.Forms.Label lb_modo;
        private System.Windows.Forms.Label lb_multiInstrucoes_2;
        private System.Windows.Forms.Button btn_modo_1;
        private System.Windows.Forms.Button btn_modo_2;
        private System.Windows.Forms.Button btn_modo_3;
        private System.Windows.Forms.Button btn_modo_4;
        private System.Windows.Forms.Button btn_modo_5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Consulta;
        private System.Windows.Forms.Label lb_Consulta;
        private System.Windows.Forms.CheckBox cb_consulta;
        private System.Windows.Forms.Label lb_consulta2;
        private System.Windows.Forms.Button btn_compare_equal;
        private System.Windows.Forms.Label lb_compareResult;
        private System.Windows.Forms.TextBox tb_memoryValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem1;
        private System.Windows.Forms.Label lb_Arquivo_IL;
        private System.Windows.Forms.TextBox tb_Previsao;
        private System.Windows.Forms.Label lb_Arquivo_IL_util;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_compare_greater;
        private System.Windows.Forms.Button btn_compare_less;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

