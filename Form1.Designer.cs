
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
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.tb_instrucoes = new System.Windows.Forms.TextBox();
            this.lb_instrucoes = new System.Windows.Forms.Label();
            this.tb_repete = new System.Windows.Forms.TextBox();
            this.cb_repete = new System.Windows.Forms.CheckBox();
            this.btn_Record = new System.Windows.Forms.Button();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.lb_X = new System.Windows.Forms.Label();
            this.lb_Y = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.tb_interval = new System.Windows.Forms.TextBox();
            this.lb_interval = new System.Windows.Forms.Label();
            this.lb_acoes = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lb_stats = new System.Windows.Forms.Label();
            this.tb_restante = new System.Windows.Forms.TextBox();
            this.lb_restante = new System.Windows.Forms.Label();
            this.cb_enable_btns = new System.Windows.Forms.CheckBox();
            this.lb_instructions_quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_pause = new System.Windows.Forms.GroupBox();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.cb_duplo = new System.Windows.Forms.CheckBox();
            this.lb_Duplo = new System.Windows.Forms.Label();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.lb_lista = new System.Windows.Forms.Label();
            this.lb_currentLista = new System.Windows.Forms.Label();
            this.gb_pause.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Left
            // 
            this.btn_Left.BackColor = System.Drawing.Color.White;
            this.btn_Left.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Left.FlatAppearance.BorderSize = 2;
            this.btn_Left.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Left.Location = new System.Drawing.Point(190, 431);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(108, 47);
            this.btn_Left.TabIndex = 2;
            this.btn_Left.Text = "Click Esquerdo (E)";
            this.btn_Left.UseVisualStyleBackColor = false;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.BackColor = System.Drawing.Color.White;
            this.btn_Right.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Right.FlatAppearance.BorderSize = 2;
            this.btn_Right.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Right.Location = new System.Drawing.Point(190, 378);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(108, 47);
            this.btn_Right.TabIndex = 3;
            this.btn_Right.Text = "Click direito (D)";
            this.btn_Right.UseVisualStyleBackColor = false;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // tb_instrucoes
            // 
            this.tb_instrucoes.Location = new System.Drawing.Point(3, 30);
            this.tb_instrucoes.Multiline = true;
            this.tb_instrucoes.Name = "tb_instrucoes";
            this.tb_instrucoes.ReadOnly = true;
            this.tb_instrucoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_instrucoes.Size = new System.Drawing.Size(169, 235);
            this.tb_instrucoes.TabIndex = 5;
            // 
            // lb_instrucoes
            // 
            this.lb_instrucoes.AutoSize = true;
            this.lb_instrucoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_instrucoes.Location = new System.Drawing.Point(21, 4);
            this.lb_instrucoes.Name = "lb_instrucoes";
            this.lb_instrucoes.Size = new System.Drawing.Size(88, 21);
            this.lb_instrucoes.TabIndex = 6;
            this.lb_instrucoes.Text = "Instruções";
            // 
            // tb_repete
            // 
            this.tb_repete.Enabled = false;
            this.tb_repete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_repete.Location = new System.Drawing.Point(310, 566);
            this.tb_repete.Name = "tb_repete";
            this.tb_repete.Size = new System.Drawing.Size(51, 23);
            this.tb_repete.TabIndex = 7;
            this.tb_repete.Text = "0";
            this.tb_repete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_repete.TextChanged += new System.EventHandler(this.tb_repete_TextChanged);
            // 
            // cb_repete
            // 
            this.cb_repete.AutoSize = true;
            this.cb_repete.Location = new System.Drawing.Point(310, 541);
            this.cb_repete.Name = "cb_repete";
            this.cb_repete.Size = new System.Drawing.Size(63, 19);
            this.cb_repete.TabIndex = 8;
            this.cb_repete.Text = "Repetir";
            this.cb_repete.UseVisualStyleBackColor = true;
            this.cb_repete.CheckedChanged += new System.EventHandler(this.cb_repete_CheckedChanged);
            // 
            // btn_Record
            // 
            this.btn_Record.BackColor = System.Drawing.Color.White;
            this.btn_Record.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Record.FlatAppearance.BorderSize = 10;
            this.btn_Record.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Record.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Record.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Record.ForeColor = System.Drawing.Color.Black;
            this.btn_Record.Location = new System.Drawing.Point(190, 305);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(108, 67);
            this.btn_Record.TabIndex = 10;
            this.btn_Record.Text = "REC (G)";
            this.btn_Record.UseVisualStyleBackColor = false;
            this.btn_Record.Click += new System.EventHandler(this.btn_Record_Click);
            // 
            // tb_X
            // 
            this.tb_X.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_X.Location = new System.Drawing.Point(91, 268);
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
            this.tb_Y.Location = new System.Drawing.Point(21, 269);
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
            this.lb_X.Location = new System.Drawing.Point(74, 268);
            this.lb_X.Name = "lb_X";
            this.lb_X.Size = new System.Drawing.Size(17, 15);
            this.lb_X.TabIndex = 13;
            this.lb_X.Text = "X:";
            // 
            // lb_Y
            // 
            this.lb_Y.AutoSize = true;
            this.lb_Y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Y.Location = new System.Drawing.Point(3, 268);
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
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(12, 305);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(172, 67);
            this.btn_Start.TabIndex = 15;
            this.btn_Start.Text = "START (S)";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Stop.FlatAppearance.BorderSize = 10;
            this.btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Stop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.Location = new System.Drawing.Point(12, 378);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(172, 104);
            this.btn_Stop.TabIndex = 16;
            this.btn_Stop.Text = "Interromper (Space)";
            this.btn_Stop.UseVisualStyleBackColor = false;
            // 
            // tb_interval
            // 
            this.tb_interval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_interval.Location = new System.Drawing.Point(310, 512);
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
            this.lb_interval.Location = new System.Drawing.Point(308, 494);
            this.lb_interval.Name = "lb_interval";
            this.lb_interval.Size = new System.Drawing.Size(53, 15);
            this.lb_interval.TabIndex = 18;
            this.lb_interval.Text = "Intervalo";
            // 
            // lb_acoes
            // 
            this.lb_acoes.AutoSize = true;
            this.lb_acoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_acoes.Location = new System.Drawing.Point(232, 120);
            this.lb_acoes.Name = "lb_acoes";
            this.lb_acoes.Size = new System.Drawing.Size(54, 21);
            this.lb_acoes.TabIndex = 20;
            this.lb_acoes.Text = "Clicks";
            this.lb_acoes.Click += new System.EventHandler(this.lb_acoes_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.White;
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Clear.FlatAppearance.BorderSize = 2;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.Location = new System.Drawing.Point(304, 378);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(73, 47);
            this.btn_Clear.TabIndex = 21;
            this.btn_Clear.Text = "LIMPA (L)";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lb_stats
            // 
            this.lb_stats.AutoSize = true;
            this.lb_stats.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_stats.Location = new System.Drawing.Point(241, 4);
            this.lb_stats.Name = "lb_stats";
            this.lb_stats.Size = new System.Drawing.Size(73, 30);
            this.lb_stats.TabIndex = 22;
            this.lb_stats.Text = "Status";
            // 
            // tb_restante
            // 
            this.tb_restante.Enabled = false;
            this.tb_restante.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_restante.Location = new System.Drawing.Point(178, 58);
            this.tb_restante.Name = "tb_restante";
            this.tb_restante.ReadOnly = true;
            this.tb_restante.Size = new System.Drawing.Size(70, 35);
            this.tb_restante.TabIndex = 23;
            this.tb_restante.Text = "0";
            this.tb_restante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_restante
            // 
            this.lb_restante.AutoSize = true;
            this.lb_restante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_restante.Location = new System.Drawing.Point(178, 34);
            this.lb_restante.Name = "lb_restante";
            this.lb_restante.Size = new System.Drawing.Size(70, 21);
            this.lb_restante.TabIndex = 24;
            this.lb_restante.Text = "Restante";
            // 
            // cb_enable_btns
            // 
            this.cb_enable_btns.AutoSize = true;
            this.cb_enable_btns.BackColor = System.Drawing.Color.Gold;
            this.cb_enable_btns.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cb_enable_btns.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_enable_btns.Location = new System.Drawing.Point(160, 262);
            this.cb_enable_btns.Name = "cb_enable_btns";
            this.cb_enable_btns.Size = new System.Drawing.Size(205, 25);
            this.cb_enable_btns.TabIndex = 27;
            this.cb_enable_btns.Text = "HABILITAR CONTROLES";
            this.cb_enable_btns.UseVisualStyleBackColor = false;
            this.cb_enable_btns.CheckedChanged += new System.EventHandler(this.cb_enable_btns_CheckedChanged);
            // 
            // lb_instructions_quantity
            // 
            this.lb_instructions_quantity.AutoSize = true;
            this.lb_instructions_quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_instructions_quantity.Location = new System.Drawing.Point(123, 4);
            this.lb_instructions_quantity.Name = "lb_instructions_quantity";
            this.lb_instructions_quantity.Size = new System.Drawing.Size(19, 21);
            this.lb_instructions_quantity.TabIndex = 29;
            this.lb_instructions_quantity.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(292, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "0";
            // 
            // gb_pause
            // 
            this.gb_pause.BackColor = System.Drawing.Color.White;
            this.gb_pause.Controls.Add(this.lb_currentLista);
            this.gb_pause.Controls.Add(this.lb_lista);
            this.gb_pause.Controls.Add(this.btn_Continue);
            this.gb_pause.Controls.Add(this.tb_restante);
            this.gb_pause.Controls.Add(this.label1);
            this.gb_pause.Controls.Add(this.tb_instrucoes);
            this.gb_pause.Controls.Add(this.lb_instrucoes);
            this.gb_pause.Controls.Add(this.lb_restante);
            this.gb_pause.Controls.Add(this.lb_instructions_quantity);
            this.gb_pause.Controls.Add(this.lb_stats);
            this.gb_pause.Controls.Add(this.tb_X);
            this.gb_pause.Controls.Add(this.cb_enable_btns);
            this.gb_pause.Controls.Add(this.tb_Y);
            this.gb_pause.Controls.Add(this.lb_acoes);
            this.gb_pause.Controls.Add(this.lb_X);
            this.gb_pause.Controls.Add(this.lb_Y);
            this.gb_pause.Location = new System.Drawing.Point(12, 12);
            this.gb_pause.Name = "gb_pause";
            this.gb_pause.Size = new System.Drawing.Size(365, 290);
            this.gb_pause.TabIndex = 31;
            this.gb_pause.TabStop = false;
            // 
            // btn_Continue
            // 
            this.btn_Continue.BackColor = System.Drawing.Color.LightGray;
            this.btn_Continue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Continue.FlatAppearance.BorderSize = 10;
            this.btn_Continue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Continue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Continue.ForeColor = System.Drawing.Color.Black;
            this.btn_Continue.Location = new System.Drawing.Point(187, 149);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(172, 104);
            this.btn_Continue.TabIndex = 32;
            this.btn_Continue.Text = "Continuar (C)";
            this.btn_Continue.UseVisualStyleBackColor = false;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // cb_duplo
            // 
            this.cb_duplo.AutoSize = true;
            this.cb_duplo.Location = new System.Drawing.Point(33, 546);
            this.cb_duplo.Name = "cb_duplo";
            this.cb_duplo.Size = new System.Drawing.Size(15, 14);
            this.cb_duplo.TabIndex = 32;
            this.cb_duplo.UseVisualStyleBackColor = true;
            // 
            // lb_Duplo
            // 
            this.lb_Duplo.AutoSize = true;
            this.lb_Duplo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Duplo.Location = new System.Drawing.Point(12, 522);
            this.lb_Duplo.Name = "lb_Duplo";
            this.lb_Duplo.Size = new System.Drawing.Size(57, 21);
            this.lb_Duplo.TabIndex = 33;
            this.lb_Duplo.Text = "Duplo";
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.White;
            this.btn_Pause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pause.FlatAppearance.BorderSize = 2;
            this.btn_Pause.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pause.Location = new System.Drawing.Point(304, 431);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(71, 47);
            this.btn_Pause.TabIndex = 34;
            this.btn_Pause.Text = "PAUSE (P)";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.White;
            this.btn_Select.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Select.FlatAppearance.BorderSize = 2;
            this.btn_Select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Select.Location = new System.Drawing.Point(304, 308);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(73, 64);
            this.btn_Select.TabIndex = 35;
            this.btn_Select.Text = "SELECT (S)";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // lb_lista
            // 
            this.lb_lista.AutoSize = true;
            this.lb_lista.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_lista.Location = new System.Drawing.Point(270, 36);
            this.lb_lista.Name = "lb_lista";
            this.lb_lista.Size = new System.Drawing.Size(62, 25);
            this.lb_lista.TabIndex = 33;
            this.lb_lista.Text = "Modo";
            // 
            // lb_currentLista
            // 
            this.lb_currentLista.AutoSize = true;
            this.lb_currentLista.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_currentLista.Location = new System.Drawing.Point(289, 61);
            this.lb_currentLista.Name = "lb_currentLista";
            this.lb_currentLista.Size = new System.Drawing.Size(25, 30);
            this.lb_currentLista.TabIndex = 34;
            this.lb_currentLista.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 601);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.lb_Duplo);
            this.Controls.Add(this.cb_duplo);
            this.Controls.Add(this.gb_pause);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Record);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.tb_repete);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.cb_repete);
            this.Controls.Add(this.tb_interval);
            this.Controls.Add(this.lb_interval);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker - By GO!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_pause.ResumeLayout(false);
            this.gb_pause.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Label lb_instrucoes;
        private System.Windows.Forms.TextBox tb_repete;
        private System.Windows.Forms.CheckBox cb_repete;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_pause;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.CheckBox cb_duplo;
        private System.Windows.Forms.Label lb_Duplo;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Label lb_currentLista;
        private System.Windows.Forms.Label lb_lista;
        private System.Windows.Forms.Button btn_Select;
    }
}

