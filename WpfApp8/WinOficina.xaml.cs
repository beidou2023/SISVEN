using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using SISVEN_DAO._Implementation;
using SISVEN_DAO._Model;

namespace WpfApp8
{
    /// <summary>
    /// Lógica de interacción para WinOficina.xaml
    /// </summary>
    public partial class WinOficina : Window
    {
        byte option=0;
        OficinaImplementation OficinaImp;

        public WinOficina()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Habilitar(){
            btn_Insert.IsEnabled = false;
            btn_Mod.IsEnabled = false;
            btn_Del.IsEnabled = false;

            btn_Save.IsEnabled = true;
            btn_Cancel.IsEnabled = true;
            
            txb_name.IsEnabled = true;
            txb_oficina.IsEnabled = true;

            txb_name.Focus();
        }

        private void Deshabilitar() {
            btn_Insert.IsEnabled = true;
            btn_Mod.IsEnabled = true;
            btn_Del.IsEnabled = true;

            btn_Save.IsEnabled = false;
            btn_Cancel.IsEnabled = false;

            txb_name.IsEnabled = false;
            txb_oficina.IsEnabled = false;

            txb_name.Text = "";
            txb_oficina.Text = "";
        }

        private void btn_Insert_Click(object sender, RoutedEventArgs e)
        {
            Habilitar();
            this.option = 1;
        }

        private void btn_Mod_Click(object sender, RoutedEventArgs e)
        {
            Habilitar();
            this.option = 2;
        }

        private void btn_Del_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Deshabilitar();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            switch (this.option) {
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        void Select()
        {
            try
            {
                OficinaImp = new OficinaImplementation();
                dgvData.ItemsSource = null;
                dgvData.ItemsSource = OficinaImp.Select().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loades_Loaded(object sender, RoutedEventArgs e)
        {
            Select();
        }
    }
}
