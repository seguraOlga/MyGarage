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
            clientUserController = new clientsUserControl();
        }

        public UserControl GetView()
        {
            return clientUserController;
        }
    }
}
