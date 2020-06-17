using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClickHn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                                    
        }
        
        Random rand = new Random();
        int mspressed;
        int contClick = 0;
        //variaveis de onde será o inicio do ativamento do mouse
        int posicao_inicio_X;
        int posicao_inicio_Y;
        //distancias maxima da posicao de inicio
        int max_distance_right_x;
        int max_distance_leftt_x;
        int max_distance_right_y;
        int max_distance_leftt_y;
        //posicoes do mouse aleatorias. 
        int posicao_random_X;
        int posicao_random_Y;

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);        

        //essa funcao identifica teclas acionadas pelo usuário
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010,
            WHEEL = 0x00000800,
            XDOWN = 0x00000080,
            XUP = 0x00000100
        }   

        private void chkAtivar_CheckedChanged(object sender, EventArgs e)
        {            
                habilitar_controles(!chkAtivar.Checked, groupBox3, groupBox4);
                timer1Click.Enabled = chkAtivar.Checked;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //adiciona os logos na list view
            addLogsListView(contClick.ToString(), timer1Click.Interval.ToString(), posicao_random_X.ToString(), posicao_random_Y.ToString(), mspressed.ToString());

            //define o intervalo do proximo clique
            timer1Click.Interval = rand.Next((int)nudMinWait.Value, (int)nudMaxWait.Value);
            lblNextClick.Text = "Next Click: " + timer1Click.Interval.ToString(); 

            //temporarizador click, manter o mouse pressed com execucao em paralelo dentro do timer
            Task t = Task.Factory.StartNew(() =>
            {
                mspressed = rand.Next((int)nudMinPressed.Value, (int)nudMaxPressed.Value);
                mouse_event((uint)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
                Thread.Sleep(mspressed);
                mouse_event((uint)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
                contClick++;
            });
            lblTotalClicks.Text = "Total Clicks: " + contClick;
        }

        private void addLogsListView(params string[] itens) {
            var listViewItem = new ListViewItem(itens);
           listView1.Items.Add(listViewItem);
            //mantem a rolagem sempre no ultimo item
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();
        }        
        
        private void habilitar_controles(bool enable,  params Control[] controles)
        {
            foreach (Control group in controles) {
                foreach (Control c in group.Controls)
                {
                    if (c is TextBox)
                        (c as TextBox).Enabled = enable;
                    if (c is NumericUpDown)
                        (c as NumericUpDown).Enabled = enable;
                    if (c.HasChildren)
                        habilitar_controles(enable, c);
                }
            }            
        }             

        private void chkMovimentMouse_CheckedChanged(object sender, EventArgs e)
        {
            habilitar_controles(!chkMovimentMouse.Checked, groupBox2, groupBox1, nudMouseSpeed);
            //define a velocidade do mouse
            HWMM.mouseSpeed = (int)nudMouseSpeed.Value;
            //captura as cordenadas do mouse e define o range maximo 
            setPositionsMouse();            
            timer1Moviment.Enabled = chkMovimentMouse.Checked;

        }

        //define a distancia maxima da cordenada inicial do mouse.
        private void setPositionsMouse() {
            posicao_inicio_X = Cursor.Position.X;
            posicao_inicio_Y = Cursor.Position.Y;

            int x = (int)nudMaxDistX.Value;
            int y = (int)nudMaxDistY.Value;

            int limit_pixel_screenX = SystemInformation.VirtualScreen.Width;
            int limit_pixel_screenY = SystemInformation.VirtualScreen.Height;

            max_distance_right_x = posicao_inicio_X + x;
            max_distance_leftt_x = posicao_inicio_X - x;

            max_distance_right_y = posicao_inicio_Y + y;
            max_distance_leftt_y = posicao_inicio_Y - y;

            //se a distancia maxima do mouse a direita ultrapassar o limite do final da tela, definir o limite como distancia máximo
            if (max_distance_right_x > limit_pixel_screenX)
                max_distance_right_x = limit_pixel_screenX - 1;

            if (max_distance_right_y > limit_pixel_screenY)
                max_distance_right_y = limit_pixel_screenY - 1;

            //se a distancia maxima do mouse a esquerda ultrapassar o limite do inicio da tela, definir o limite como distancia máxima
            if (max_distance_leftt_x < 1)
                max_distance_leftt_x = 1;

            if (max_distance_leftt_y < 1)
                max_distance_leftt_y = 1;
        }

        private void mouseRandomMove() { 
            //obtém a localização aleatoria entre os dados definidos dentro dos limites
            posicao_random_X = rand.Next(max_distance_leftt_x, max_distance_right_x);
            posicao_random_Y = rand.Next(max_distance_leftt_y, max_distance_right_y);

            HWMM.MoveMouse(posicao_random_X, posicao_random_Y);
        }

        private void timer1Active_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F7) == -32767)            
                chkAtivar.Checked = !chkAtivar.Checked;

            if (GetAsyncKeyState(Keys.F8) == -32767)
                chkMovimentMouse.Checked = !chkMovimentMouse.Checked;

            lblX.Text = "X: " + Cursor.Position.X.ToString();
            lblY.Text = "Y: " + Cursor.Position.Y.ToString();            
        }

        private void btnClearListView_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            lblTotalClicks.Text = "Total Clicks: ";
        }

        private void timer1Moviment_Tick(object sender, EventArgs e)
        {
            timer1Moviment.Interval = rand.Next((int)nudMinWaitMoviment.Value, (int)nudMaxWaitMoviment.Value);
            mouseRandomMove();
        }

        private void txtMinWait_Leave(object sender, EventArgs e)
        {
            nudMinPressed.Maximum = nudMinWait.Value - 10;
        }

        private void txtMaxWait_Leave(object sender, EventArgs e)
        {
            nudMaxPressed.Maximum = (int)nudMaxWait.Value - 10;
        }
    }
}
 /*
     
    validação no campo maximo do keep pressed click
     
     */