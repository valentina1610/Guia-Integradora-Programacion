using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionGUIAej5.Models;
using ProgramacionGUIAej5.Views;

namespace ProgramacionGUIAej5.Controllers
{
    public class UserController
    {
        public User AddUser() => UserView.AddUser();

    }
}
