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




namespace Auto_click_atlas_2
{

    public partial class Form1 : Form
    {


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);


        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        private const int MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        private const int MOUSEEVENTF_XUP = 0x0100; /* x button down */
        private const int MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        private const int MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */


        /*      GLOBAL VARIABLES       */


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
        short clicksQuantity;


        //GENERAL PURPOUSE
        short interval = 0;
        short repeticoes = 0;
        short restante = 0;


        byte instructionQuantity = 0;
        byte instructionNumber = 0;
        Instrucoes[] Instrucoes = new Instrucoes[50];




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
            m_Events.MouseUpExt += M_Events_MouseClickExt;

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
            m_Events.MouseUpExt -= M_Events_MouseClickExt;
            m_Events.KeyPress -= M_Events_KeyPress;
            m_Events.MouseDownExt -= M_Events_MouseDownExt;

            m_Events.Dispose();
            m_Events = null;
        }



        // 


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

                    tb_instrucoes.Text += string.Format(" Click L - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                    InstructionList(x, y, '¬');

                }
                else if (e.Button == MouseButtons.Right)
                {
                    instructionQuantity++;
                    lb_instructions_quantity.Text = instructionQuantity.ToString();

                    tb_instrucoes.Text += string.Format(" Click R - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                    InstructionList(x, y, '¨');
                }

            }
        }

        private void M_Events_MouseClickExt(object sender, MouseEventExtArgs e)
        {
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


        }


        private void M_Events_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CLOSE
            //if (e.KeyChar == 27 )                              <-- ***Fecha app com "ESC"***
            //  System.Windows.Forms.Application.ExitThread();

            if (cb_enable_btns.Checked == true)
            {
                {// TESTE DA SELECAO
                    if (e.KeyChar == 'q')
                    {

                        mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                    }

                    if (e.KeyChar == 'w')
                    {

                        mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                    }
                }


                //Click Esquerdo
                if (e.KeyChar == 'e' || e.KeyChar == 'E')
                {
                    btn_Left.PerformClick();
                }

                //Click Direito
                if (e.KeyChar == 'd' || e.KeyChar == 'D')
                {
                    btn_Right.PerformClick();
                }

                //Pause
                if (e.KeyChar == 'p' || e.KeyChar == 'P')
                {
                    btn_Pause.PerformClick();
                }

                //Select
                if (e.KeyChar == 's' || e.KeyChar == 'S')
                {
                    btn_Select.PerformClick();
                }


                /* ------------Comandos de Execucao----------- */

                //CLEAN
                if (e.KeyChar == 'l' || e.KeyChar == 'L')
                {
                    btn_Clear.PerformClick();
                }

                //START
                if (f_btn_record == false && f_stop == false && (e.KeyChar == 's' || e.KeyChar == 'S'))
                {
                    btn_Start.PerformClick();
                }

                if (e.KeyChar == 'c' || e.KeyChar == 'C')
                {
                    btn_Continue.PerformClick();
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





        public void Perform_Click(int X, int Y, char Key)
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

                gb_pause.BackColor = Color.Red;
                f_pause = true;

                while (f_pause)
                {
                    gb_pause.BackColor = Color.Red;
                    System.Threading.Thread.Sleep(100);
                    gb_pause.BackColor = Color.White;
                    System.Threading.Thread.Sleep(100);
                }



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

        private void InstructionList(short x, short y, char key)
        {
            Instrucoes[instructionNumber] = new Instrucoes(x, y, key);
            instructionNumber++;
            if (instructionNumber > 50)
            {
                btn_Record.PerformClick();
                instructionNumber = 0;
                btn_Clear.PerformClick();
                MessageBox.Show(new Form { TopMost = true }, "O MAXIMO DE 50 INSTRUCOES FOI ATINGIDO, A LISTA FOI REDEFINIDA!");

            }

        }

        /* ---- FUNCOES END ----*/

        //      ======= Botoes =======

        private void btn_Left_Click(object sender, EventArgs e)
        {
            if (cb_enable_btns.Checked)
            {
                tb_instrucoes.Text += string.Format(" Click L - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                InstructionList(x, y, '¬');
            }

        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            if (cb_enable_btns.Checked)
            {
                tb_instrucoes.Text += string.Format(" Click R - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                InstructionList(x, y, '¨');
            }

        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (cb_enable_btns.Checked && f_btn_record)
            {
                tb_instrucoes.Text += "*** Pausa ***\r\n";
                InstructionList(0, 0, '$');
            }

        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (cb_enable_btns.Checked && f_btn_record)
            {
                InstructionList(x, y, 's');
                tb_instrucoes.Text += "### SELECT ###\r\n";


            }
        }

        private void btn_Record_Click(object sender, EventArgs e)
        {

            if (cb_enable_btns.Checked)
            {
                recordState++;

                if (recordState == 1)
                {
                    f_btn_record = true;
                    btn_Record.BackColor = Color.Red;
                    btn_Record.Text = "RECORDING";
                }

                else if (recordState > 1)
                {
                    f_btn_record = false;
                    recordState = 0;
                    btn_Record.BackColor = Color.White;
                    btn_Record.Text = "RECORD (G)";
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
            byte iteracoes = 0;
            byte indicesVazios = 0;
            restante = repeticoes;
            tb_restante.Text = restante.ToString();
            tb_restante.Refresh();
            restante++;


            do
            {

                for (int j = 0; j < Instrucoes.Length; j++)
                {
                    if (f_pause != true)
                    {
                        tb_restante.Text = restante.ToString();
                        tb_restante.Refresh();

                        if (Instrucoes[j] != null && f_stop != true)
                        {
                            if (Instrucoes[j].Key == 's')
                            {
                                SetCursorPos(Instrucoes[j - 2].X, Instrucoes[j - 2].Y);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, Instrucoes[j - 2].X, Instrucoes[j - 2].Y, 0, 0); // Inicia o click 2 posicoes atras no array
                                SetCursorPos(Instrucoes[j - 1].X, Instrucoes[j - 1].Y);
                                mouse_event(MOUSEEVENTF_LEFTUP, Instrucoes[j - 2].X, Instrucoes[j - 2].Y, 0, 0);
                            }
                            else
                            {
                                Perform_Click(Instrucoes[j].X, Instrucoes[j].Y, Instrucoes[j].Key);
                            }

                        }
                        else
                        {
                            indicesVazios++;
                        }

                    }

                }

                iteracoes++;

                restante--;
                tb_restante.Text = restante.ToString();
                tb_restante.Refresh();

            } while (iteracoes <= repeticoes && cb_repete.Checked);


            btn_Start.Text = "START (S)";
            btn_Start.BackColor = Color.ForestGreen; btn_Start.ForeColor = Color.White;
            btn_Start.Refresh();

            startState = 0;
            f_Start = false;


            if (indicesVazios == Instrucoes.Length)
                MessageBox.Show(new Form { TopMost = true }, "Não há instrucoes para executar!!");

        }
    })
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
            tb_instrucoes.Clear();
            Array.Clear(Instrucoes, 0, Instrucoes.Length);


            instructionQuantity = 0;
            lb_instructions_quantity.Text = instructionQuantity.ToString();
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

            recordState = 0;
            f_btn_record = false;
            btn_Record.BackColor = Color.White;
            btn_Record.Text = "RECORD (G)";
        }

        /* ---- CHECK BOX END ---- */


        /* ---- TEXT BOX ---- */

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
            Unsubscribe();
            Subscribe(Hook.GlobalEvents());

        }

        private void lb_acoes_Click(object sender, EventArgs e)
        {

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }


    }


}
