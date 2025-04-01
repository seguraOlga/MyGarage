using Clients.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clients.Controller
{
    public class clientsController
    {
        private UserControl clientUserController;

        public clientsController()
        {
            setListeners();
            clientUserController = new clientsUserControl();
            

        }


        public UserControl GetView()
        {
            return clientUserController;
        }


        private void setListeners()
        {
            

        }
    }
}
