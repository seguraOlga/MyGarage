using Clients.Controller;
using MyGarage.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGarage.Controller
{
    public class initController
    {

        Form1 initForm;
        UserControl initUserControl;
        public initController() {

            //initUserControl = new UserControl();
            initForm = new Form1();
            loadData();
            setListeners();
            initForm.ShowDialog();
            


        }


        private void loadData()
        {
            var inicioView = new initUserControl();
            initForm.Text = "Inici";
            CargarVista(initForm.iniciPage, inicioView);
        }

 
        private void setListeners()
        {
            initForm.DrawerTabControl.SelectedIndexChanged += canviPage;
        }

        private void canviPage(object sender, EventArgs e)
        {
            string tabName = initForm.drawerMenu.SelectedTab.Name;

            if (tabName == "iniciPage")
            {
                var inicioView = new initUserControl();
                initForm.Text = "Inici";
                CargarVista(initForm.iniciPage, inicioView);
            }
            else if (tabName == "clientsPage")
            {
                var clientController = new clientsController();
                var clientView = clientController.GetView();
                initForm.Text = "Clients" +
                    "";
                CargarVista(initForm.clientsPage, clientView);
            }
            else
            {
                 var inicioView = new initUserControl();
                CargarVista(initForm.iniciPage, inicioView);
            }
            
        }

        private void CargarVista(TabPage pagina, UserControl vista)
        {
            pagina.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            pagina.Controls.Add(vista);
        }


    }
}
