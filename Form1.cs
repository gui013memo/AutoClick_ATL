using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

/*
 *      Instruções MouseKeyHook:
 *  
 *          1 - Para utilizar função Chamar no metodo "Subscribe" com "+=" e tambem no "Unsibscribe" com "-=" 
 *          
 *          2 - deve conter no codigo:
 *              
 *              private void Form1_Load(object sender, EventArgs e)
 *              
                {
                   Unsubscribe();
                   Subscribe(Hook.GlobalEvents());
                }
 *         
 *  
 * 
 * 
 * 
 * 
 * */

/*
 * TODO:
 *      
 *      Modo BLM Torque         -> Comparacao
 *      
 * Inserir:
 *      Menu "Arquivo"          -> salvar e carregar 
 *      Menu "Configurações"    ->
 *      Menu "Modo"             -> Generico, BLM Torque
 *      Menu "Creditos"         -> Desenvolvedor, link GitHub
 *     
 *      ~ Tela de loading
 * 
 * Melhoria:
 *      Verificar campo "RESTANTE" no momento em que a tecla "espaço" pausa o programa
 *      
 * 
 * 
 *  
 * 
 */


namespace Auto_click_atlas_2
{

    public partial class Form1 : Form
    {


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);


        //private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        //private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        //private const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        //private const int MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        //private const int MOUSEEVENTF_XUP = 0x0100; /* x button down */
        //private const int MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        //private const int MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        //private const int MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */


        /*      GLOBAL VARIABLES       */

        // TESTE PARA O GIT 


        // MEMORIAS

        bool f_btn_record = false;
        byte recordState = 0;

        bool f_stop = false;
        byte stopState = 0;

        byte startState = 0;
        bool f_Start = false;

        bool f_pause = false;


        // MOUSE

        short x, y;


        //GENERAL PURPOUSE
        short interval = 0;
        short repeticoes = 0;
        short restante = 0;
        byte f_mode = 0;
        byte modeSelected = 0;

        // Instructions

        byte instructionQuantity = 0;
        byte instructionNumber = 0;
        Instrucoes[] Instrucoes_Global = new Instrucoes[50];
        Instrucoes[] Instrucoes_1 = new Instrucoes[50];
        Instrucoes[] Instrucoes_2 = new Instrucoes[50];
        Instrucoes[] Instrucoes_3 = new Instrucoes[50];
        Instrucoes[] Instrucoes_4 = new Instrucoes[50];
        Instrucoes[] Instrucoes_5 = new Instrucoes[50];




        /*      GLOBAL VARIABLES       */

        public Form1()
        {
            InitializeComponent();
        }




        /*      ========== KeyMouseHook - functions ==========     */

        private IKeyboardMouseEvents m_Events;
        //private IMouseEvents m_MouseEvents;



        private void Subscribe(IKeyboardMouseEvents events)
        {

            m_Events = events;

            m_Events.MouseMove += M_Events_MouseMove;
            m_Events.MouseClick += M_Events_MouseClick;
            //m_Events.MouseUpExt += M_Events_MouseClickExt;

            m_Events.KeyPress += M_Events_KeyPress;
            m_Events.MouseDownExt += M_Events_MouseDownExt;
        }

        //private void Subscribe2(IMouseEvents events)
        //{

        //}

        //private void Unsubscribe2()
        //{
        //    m_MouseEvents.Dispose();
        //    m_MouseEvents = null;
        //}

        private void Unsubscribe()
        {
            if (m_Events == null) return;
            m_Events.MouseMove -= M_Events_MouseMove;
            m_Events.MouseClick -= M_Events_MouseClick;
            //m_Events.MouseUpExt -= M_Events_MouseClickExt;
            m_Events.KeyPress -= M_Events_KeyPress;
            m_Events.MouseDownExt -= M_Events_MouseDownExt;

            m_Events.Dispose();
            m_Events = null;

        }

        public void PauseBlinking()
        {

            gb_pause.BackColor = Color.Red;
            f_pause = true;

            while (f_pause)
            {
                gb_pause.BackColor = Color.Red;
                System.Threading.Thread.Sleep(100);
                gb_pause.BackColor = Color.White;
                System.Threading.Thread.Sleep(100);
            }

        }

        public void PerformClick(int X, int Y, char Key)
        {


            SetCursorPos(X, Y);

            if (Key == '¬')
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
                System.Threading.Thread.Sleep(100);
                mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

                System.Threading.Thread.Sleep(interval);

            }
            else if (Key == '¨')
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN, X, Y, 2, 0);
                System.Threading.Thread.Sleep(100);
                mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 2, 0);

                System.Threading.Thread.Sleep(interval);

            }
            else if (Key == '$')
            {

                PauseBlinking();

                //gb_pause.BackColor = Color.Red;
                //f_pause = true;

                //while (f_pause)
                //{
                //    gb_pause.BackColor = Color.Red;
                //    System.Threading.Thread.Sleep(100);
                //    gb_pause.BackColor = Color.White;
                //    System.Threading.Thread.Sleep(100);
                //}



                //while(btn_Continue.Focused != true)
                //{
                //    gb_pause.BackColor = Color.Red;
                //}

                //gb_pause.BackColor = Color.White;
            }




        }

        private void Stop_Execution()
        {

            stopState++;

            if (stopState == 1)
            {
                f_stop = true;
                btn_Stop.BackColor = Color.Yellow;
                btn_Stop.Text = "TRAVADO!";
            }
            else if (stopState == 2)
            {
                f_stop = false;
                stopState = 0;
                btn_Stop.BackColor = Color.Red;
                btn_Stop.Text = "Interromper (Space)";

            }
        }

        private void setInstructionList(short x, short y, char key)
        {
            switch (f_mode)
            {
                case 0:
                    Instrucoes_Global[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 1:
                    Instrucoes_1[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 2:
                    Instrucoes_2[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 3:
                    Instrucoes_3[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 4:
                    Instrucoes_4[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 5:
                    Instrucoes_5[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
            }



            //OverfloW
            if (instructionNumber > 50)
            {
                btn_Record.PerformClick();
                instructionNumber = 0;
                btn_Clear.PerformClick();
                MessageBox.Show(new Form { TopMost = true }, "O MAXIMO DE 50 INSTRUCOES FOI ATINGIDO, A LISTA FOI REDEFINIDA!");

            }


        }


        // 

        private void compara()
        {

            //if ()
            //{

            //}

        }


        private void M_Events_MouseMove(object sender, MouseEventArgs e)
        {

            if (cb_enable_btns.Checked == true)
            {
                tb_X.Text = e.X.ToString();
                tb_Y.Text = e.Y.ToString();

                x = ((short)e.X);
                y = ((short)e.Y);
            }

        }



        private void M_Events_MouseClick(object sender, MouseEventArgs e)
        {
            if (f_btn_record == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    instructionQuantity++;
                    lb_instructions_quantity.Text = instructionQuantity.ToString();

                    tb_instrucoes.Text += string.Format("Click L - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                    setInstructionList(x, y, '¬');

                }
                else if (e.Button == MouseButtons.Right)
                {
                    instructionQuantity++;
                    lb_instructions_quantity.Text = instructionQuantity.ToString();

                    tb_instrucoes.Text += string.Format("Click R - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                    setInstructionList(x, y, '¨');
                }

            }
        }

        //private void M_Events_MouseClickExt(object sender, MouseEventExtArgs e)
        //{
        //if (!e.IsMouseButtonDown)
        //{
        //    tb_instrucoes.Text = string.Format("X = {0} - Y = {1} \r\n", e.X, e.Y);
        //    tb_instrucoes.Text += "APERTADO!";
        //    //System.Threading.Thread.Sleep(400);
        //}

        //if (e.IsMouseButtonUp)
        //{
        //    tb_instrucoes.Text += "SOLTO!!";
        //    //System.Threading.Thread.Sleep(400);
        //}


        //}


        private void M_Events_KeyPress(object sender, KeyPressEventArgs e)
        {
            //                   -  Fechar programa com ESC  -
            //if (e.KeyChar == 27 )                              <-- ***Fecha app com "ESC"***
            //  System.Windows.Forms.Application.ExitThread();

            if (cb_enable_btns.Checked)
            {

                //Gera modo 1 
                if (e.KeyChar == '6')
                    btn_modo_1.PerformClick();
                //Gera modo 2
                if (e.KeyChar == '7')
                    btn_modo_2.PerformClick();
                //Gera modo 3
                if (e.KeyChar == '8')
                    btn_modo_3.PerformClick();
                //Gera modo 4
                if (e.KeyChar == '9')
                    btn_modo_4.PerformClick();
                //Gera modo 5
                if (e.KeyChar == '0')
                    btn_modo_5.PerformClick();

                /*          MOUSE              */

                //Click Esquerdo
                if (e.KeyChar == 'e' || e.KeyChar == 'E')
                    btn_Left.PerformClick();


                //Click Direito
                if (e.KeyChar == 'd' || e.KeyChar == 'D')
                {
                    btn_Right.PerformClick();
                }

                /*          MOUSE END           */

                //Pause
                if (e.KeyChar == 'p' || e.KeyChar == 'P')
                {
                    btn_Pause.PerformClick();
                }

                ////Select   **EM DESENVOLVIMENTO**
                //if (e.KeyChar == 's' || e.KeyChar == 'S')
                //{
                //    btn_Select.PerformClick();
                //}


                /* ------------Comandos de Execucao----------- */

                //CLEAN
                if (e.KeyChar == 'l' || e.KeyChar == 'L')
                {
                    btn_Clear.PerformClick();
                    compara();

                }

                //START
                if (f_btn_record == false && f_stop == false && (e.KeyChar == 's' || e.KeyChar == 'S'))
                {
                    btn_Start.PerformClick();
                }

                //STOP
                if (e.KeyChar == ' ')
                {
                    Stop_Execution();
                }

                //RECORD
                if (e.KeyChar == 'g' || e.KeyChar == 'G')
                {
                    btn_Record.PerformClick();
                }

                //CONTINUE
                if (e.KeyChar == 'c' || e.KeyChar == 'C')
                {
                    btn_Continue.PerformClick();
                }

                //MODE SELECT
                if (cb_multi_Instructions.Checked)
                {
                    //Executa modo 1 
                    if (e.KeyChar == '1')
                    {
                        f_pause = false;
                        modeSelected = 1;
                        tb_instrucoes.Text += "MODE 1 SELECIONADO!";
                    }

                    //Executa modo 2
                    if (e.KeyChar == '2')
                    {
                        f_pause = false;
                        modeSelected = 2;
                        tb_instrucoes.Text += "MODE 2 SELECIONADO!";
                    }
                    //Executa modo 3
                    if (e.KeyChar == '3')
                    {
                        f_pause = false;
                        modeSelected = 3;
                        tb_instrucoes.Text += "MODE 3 SELECIONADO!";
                    }
                    //Executa modo 4
                    if (e.KeyChar == '4')
                    {
                        f_pause = false;
                        modeSelected = 4;
                        tb_instrucoes.Text += "MODE 4 SELECIONADO!";
                    }
                    //Executa modo 5
                    if (e.KeyChar == '5')
                    {
                        f_pause = false;
                        modeSelected = 5;
                        tb_instrucoes.Text += "MODE 5 SELECIONADO!";
                    }
                }


            }   /* -----------END------------ */
        }



        private void M_Events_MouseDownExt(object sender, MouseEventExtArgs e)
        {
            /*if (cb_repete.Checked == true)
            {
                tb_acoes.Text += "Verificacao iniciada!";

                Thread thread2 = new Thread(t =>
                {
                    //if (e.IsMouseButtonDown == true)
                    //{
                    //    tb_instrucoes.Text += "APERTANDO!!";
                    //    System.Threading.Thread.Sleep(100);

                    //    M_Events_MouseDownExt(sender, e);
                    //}

                    if (e.IsMouseButtonUp == true)
                    {
                        tb_instrucoes.Text += "SOLTO!";
                        System.Threading.Thread.Sleep(100);

                        M_Events_MouseDownExt(sender, e);
                    }
                })
                { IsBackground = true };
                thread2.Start();

            }*/
        }



        //      ========== KeyMouseHook - END - functions ==========



        /* ---- FUNCOES END ----*/

        //      ======= Botoes =======

        private void btn_modo_1_Click(object sender, EventArgs e)
        {
            if (f_btn_record && cb_multi_Instructions.Checked)
            {
                f_mode = 1;
                instructionNumber = 0;
                tb_instrucoes.Text += "Inicio modo 1";
            }

        }

        private void btn_modo_2_Click(object sender, EventArgs e)
        {
            if (f_btn_record && cb_multi_Instructions.Checked)
            {
                f_mode = 2;
                instructionNumber = 0;
                tb_instrucoes.Text += "Inicio modo 2";
            }
        }

        private void btn_modo_3_Click(object sender, EventArgs e)
        {
            if (f_btn_record && cb_multi_Instructions.Checked)
            {
                f_mode = 3;
                instructionNumber = 0;
                tb_instrucoes.Text += "Inicio modo 3";
            }
        }

        private void btn_modo_4_Click(object sender, EventArgs e)
        {
            if (f_btn_record && cb_multi_Instructions.Checked)
            {
                f_mode = 4;
                instructionNumber = 0;
                tb_instrucoes.Text += "Inicio modo 4";
            }
        }

        private void btn_modo_5_Click(object sender, EventArgs e)
        {
            if (f_btn_record && cb_multi_Instructions.Checked)
            {
                f_mode = 5;
                instructionNumber = 0;
                tb_instrucoes.Text += "Inicio modo 5";
            }
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            if (cb_enable_btns.Checked)
            {
                tb_instrucoes.Text += string.Format(" Click L - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                setInstructionList(x, y, '¬');
            }

        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            if (cb_enable_btns.Checked)
            {
                tb_instrucoes.Text += string.Format(" Click R - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                setInstructionList(x, y, '¨');
            }

        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (cb_enable_btns.Checked && f_btn_record)
            {
                tb_instrucoes.Text += "*** Pausa ***\r\n";
                setInstructionList(x, y, '$');
            }

        }

        //private void btn_Select_Click(object sender, EventArgs e)
        //{
        //    if (cb_enable_btns.Checked && f_btn_record)
        //    {
        //        setInstructionList(x, y, 's');
        //        tb_instrucoes.Text += "### SELECT ###\r\n";


        //    }
        //}

        private void btn_Record_Click(object sender, EventArgs e)
        {

            if (cb_enable_btns.Checked)
            {
                recordState++;

                if (recordState == 1)
                {
                    f_btn_record = true;
                    btn_Record.BackColor = Color.Red;
                    btn_Record.ForeColor = Color.White;
                    btn_Record.Text = "REC (G)";
                }

                else if (recordState > 1)
                {
                    f_btn_record = false;
                    recordState = 0;
                    btn_Record.BackColor = Color.White;
                    btn_Record.ForeColor = Color.Black;
                    btn_Record.Text = "REC (G)";
                }
            }

        }
        //      ======= Botoes END =======


        //      ======= User Functions =======


        private void btn_Start_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(t =>
    {
        startState = 1;


        /*if (f_stop == true)
        {
            thread1.Suspend();
        }*/

        if (startState == 1 && f_stop != true && f_btn_record != true && cb_enable_btns.Checked == true)
        {
            f_Start = true;

            //btn_Start.BackColor = Color.OrangeRed;
            //btn_Start.Text = "Running!";
            //System.Threading.Thread.Sleep(1000);

            btn_Start.Text = "RUNNING!";
            btn_Start.BackColor = Color.ForestGreen; btn_Start.ForeColor = Color.White;
            btn_Start.Refresh();


            //Int16.TryParse(tb_repete.Text, out short repeticoes);
            restante = repeticoes;
            tb_restante.Text = restante.ToString();
            tb_restante.Refresh();
            restante++;



            //if (Instrucoes_1[0] == null)
            //    tb_instrucoes.Text += "Instructions 1 NULO!!!";





            //tb_instrucoes.Text += "Modo multi!";

            do
            {

                //Instruction list global
                for (byte i = 0; i < Instrucoes_Global.Length; i++)
                {

                    lb_currentMode.Text = "P".ToString();

                    if (Instrucoes_Global[i] == null)
                        break;

                    PerformClick(Instrucoes_Global[i].X, Instrucoes_Global[i].Y, Instrucoes_Global[i].Key);
                }

                if (cb_multi_Instructions.Checked && !f_stop)
                {

                    PauseBlinking();

                    switch (modeSelected)
                    {
                        case 1:
                            //Instruction list 1
                            lb_currentMode.Text = '1'.ToString();
                            for (byte i = 0; i < Instrucoes_1.Length; i++)
                            {
                                if (Instrucoes_1[i] == null)
                                    break;

                                PerformClick(Instrucoes_1[i].X, Instrucoes_1[i].Y, Instrucoes_1[i].Key);
                            }
                            break;

                        case 2:
                            //Instruction list 2
                            lb_currentMode.Text = '2'.ToString();
                            for (byte i = 0; i < Instrucoes_2.Length; i++)
                            {
                                if (Instrucoes_2[i] == null)
                                    break;

                                PerformClick(Instrucoes_2[i].X, Instrucoes_2[i].Y, Instrucoes_2[i].Key);
                            }
                            break;

                        case 3:
                            //Instruction list 3
                            lb_currentMode.Text = '3'.ToString();
                            for (byte i = 0; i < Instrucoes_3.Length; i++)
                            {
                                if (Instrucoes_3[i] == null)
                                    break;

                                PerformClick(Instrucoes_3[i].X, Instrucoes_3[i].Y, Instrucoes_3[i].Key);
                            }
                            break;

                        case 4:
                            //Instruction list 4
                            lb_currentMode.Text = '4'.ToString();
                            for (byte i = 0; i < Instrucoes_4.Length; i++)
                            {
                                if (Instrucoes_4[i] == null)
                                    break;

                                PerformClick(Instrucoes_4[i].X, Instrucoes_4[i].Y, Instrucoes_4[i].Key);
                            }
                            break;

                        case 5:
                            //Instruction list 5
                            lb_currentMode.Text = '5'.ToString();
                            for (byte i = 0; i < Instrucoes_5.Length; i++)
                            {
                                if (Instrucoes_5[i] == null)
                                    break;

                                PerformClick(Instrucoes_5[i].X, Instrucoes_5[i].Y, Instrucoes_5[i].Key);
                            }
                            break;
                    }










                }



                repeticoes--;
                tb_restante.Text = repeticoes.ToString();
                tb_restante.Refresh();

            } while (repeticoes > 0 && cb_repete.Checked && !f_stop);




            //else
            //{
            //    do
            //    {
            //        for (byte j = 0; j < Instrucoes_Global.Length; j++)
            //        {

            //            tb_restante.Text = restante.ToString();
            //            tb_restante.Refresh();

            //            if (Instrucoes_Global[j] != null && f_stop != true)
            //                PerformClick(Instrucoes_Global[j].X, Instrucoes_Global[j].Y, Instrucoes_Global[j].Key);
            //        }



        }







        btn_Start.Text = "START (S)";
        btn_Start.BackColor = Color.ForestGreen; btn_Start.ForeColor = Color.White;
        btn_Start.Refresh();

        startState = 0;
        f_Start = false;


        //if (indicesVazios == Instrucoes_Global.Length)
        //  MessageBox.Show(new Form { TopMost = true }, "Não há Instrucoes para executar!!");

    }
    )
            { IsBackground = true };
            thread1.Start();
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            if (f_Start)
            {
                f_pause = false;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_instrucoes.Text = null;  //tb_instrucoes.Text.Remove((instructionNumber - 1) * 26, (instructionNumber - 1) * 30);



            Array.Clear(Instrucoes_Global, 0, Instrucoes_Global.Length);
            Array.Clear(Instrucoes_1, 0, Instrucoes_1.Length);
            Array.Clear(Instrucoes_2, 0, Instrucoes_2.Length);
            Array.Clear(Instrucoes_3, 0, Instrucoes_3.Length);
            Array.Clear(Instrucoes_4, 0, Instrucoes_4.Length);
            Array.Clear(Instrucoes_5, 0, Instrucoes_5.Length);
            lb_instructions_quantity.Text = "0";

            //Array.Clear(Instrucoes_Global, instructionNumber, 1);


            //instructionQuantity--;
            //lb_instructions_quantity.Text = instructionQuantity.ToString();
        }

        /* ---- CHECK BOX ---- */
        private void cb_repete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_repete.Checked == true)
            {
                tb_repete.Enabled = true;
            }
            else
            {
                tb_repete.Enabled = false;
            }
        }
        private void cb_enable_btns_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;  //Para tirar o foco do cb e nao ser checado pela tecla SPACE

            //recordState = 0;
            //f_btn_record = false;
            //btn_Record.BackColor = Color.White;
            //btn_Record.Text = "RECORD (G)";
        }

        /* ---- CHECK BOX END ---- */


        /* ---- TEXT BOX ---- */
        private void tb_Consulta_TextChanged(object sender, EventArgs e)
        {
            if (cb_consulta.Checked)
                compara();
        }


        private void tb_interval_TextChanged(object sender, EventArgs e)
        {
            string digitsOnly = String.Empty;
            foreach (char c in tb_interval.Text)
            {
                // Do not use IsDigit as it will include more than the characters 0 through to 9
                if (c >= '0' && c <= '9') digitsOnly += c;
            }


            Int16.TryParse(digitsOnly, out short intervalo);
            interval = intervalo;

            tb_interval.Text = digitsOnly;


        }

        private void tb_repete_TextChanged(object sender, EventArgs e)
        {


            string digitsOnly = String.Empty;
            foreach (char c in tb_repete.Text)
            {
                // Do not use IsDigit as it will include more than the characters 0 through to 9
                if (c >= '0' && c <= '9') digitsOnly += c;
            }


            Int16.TryParse(digitsOnly, out short repeticaoes_);
            repeticoes = repeticaoes_;

            tb_repete.Text = digitsOnly;
        }

        /* ---- TEXT BOX END---- */


        private void Form1_Load(object sender, EventArgs e)
        {
            //if(cb_multi_Instructions.Checked)
            //{
            //    Instrucoes_Global ins
            //}

            Unsubscribe();
            Subscribe(Hook.GlobalEvents());

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }


    }


}
