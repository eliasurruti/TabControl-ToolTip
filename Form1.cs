using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int contador = 1;
        int ayudas = 0;
        TabPage paginas = new TabPage();
        public Form1()
        {
            
            InitializeComponent();

            #region Tooltip
            toolTip1.SetToolTip(tabPage1, tabControl1.SelectedTab.Text); //Propiedad SetToolTip
            toolTip1.SetToolTip(tabPage2, tabControl1.SelectedTab.Text);

            toolTip1.ToolTipTitle = "Hola"; //Propiedad ToolTipTitle
            toolTip1.InitialDelay = 200; //Propiedad InitialDelay
            toolTip1.ReshowDelay = 200;    //Propiedad ReshowDelay
            
           
         
            #endregion


            #region TabPage

            //Propiedad Text

            tabPage1.Text = "Pagina 1";
            tabPage2.Text = "Pagina 2";
            tabPage3.Text = "Pagina 3";
            tabPage4.Text = "Pagina 4";


            //Propiedad TabCount

            label7.Text = "Cantidad de Paginas: " + tabControl1.TabCount; 



            //Propiedad BackColor
            
            tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
            tabPage3.BackColor = System.Drawing.Color.PowderBlue;
            tabPage4.BackColor = System.Drawing.Color.Thistle;
            #endregion
        }
        #region TabControl
        private void button6_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(Convert.ToInt32(textBox1.Text)); //Propiedad SelectTab
            textBox1.Text = "";
            
        }
        #endregion
        #region TabControl
        private void button2_Click(object sender, EventArgs e)
        {
            TextBox Nota = new TextBox();
          
            Nota.Size = new Size(300, 500) ;
            
           
            #region TabControl
            
            tabControl1.SelectedTab.Controls.Add(Nota); //Propiedad SelectedTab

            #endregion

            #region ToolTip
            toolTip1.SetToolTip(Nota, "Boton vacio");
            #endregion
        }
        private void btText_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Text = txtTexto.Text;
            txtTexto.Text = "";
            toolTip1.SetToolTip(tabPage1, tabControl1.SelectedTab.Text); //Propiedad SetToolTip
            toolTip1.SetToolTip(tabPage2, tabControl1.SelectedTab.Text);
        }
        #region TabControl
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //EVENTO SelectedIndexChanged
        {
            label1.Text = "id " + Convert.ToString(tabControl1.SelectedIndex +1); //Propiedad SelectedIndex


        }
        #endregion
   
      
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            #region ToolTip

            toolTip1.SetToolTip(paginas, "Pagina vacia");

            #endregion
            #region TabControl
            tabControl1.Controls.Add(paginas); //Propiedad Add
            paginas.Text = "Pagina 1";
            label7.Text = "Cantidad de Paginas: " + tabControl1.TabCount;
            #endregion

        }

      
        
        #region TabControl
        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e) //EVENTO Deselecting
        { 
            label3.Text = "Cambio de pagina " + Convert.ToString(contador); 
            contador++;
        }
        #endregion

      
      

        #region TabControl
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Controls.Clear();   //Propiedad Clear
            
        }
        #endregion

        #region Tooltip
        private void button4_Click(object sender, EventArgs e)
        {
            toolTip1.Active = false; //Propiedad Active
        }
        #endregion
        #region TabControl
        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab); //Propiedad Remove
            
        }
        #endregion
        #region TabControl
        private void tabControl1_ControlRemoved(object sender, ControlEventArgs e) //Eventro ControlRemoved
        {
            label4.Text = "se ha borrado la pagina";
        }
        #endregion
        #region TabControl
        private void tabControl1_ControlAdded(object sender, ControlEventArgs e) //Evento ControlAdded
        {
            label5.Text = "se ha agregado la pagina";
        }
        #endregion
        private void Form1_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label4.Text = "";
        }
        #region Tooltip
        private void toolTip1_Popup(object sender, PopupEventArgs e) //Evento PopUp
        {
            ayudas++;
            label6.Text = "ayudas totales " + Convert.ToString(ayudas);
        }
        #endregion
      
    }



}
