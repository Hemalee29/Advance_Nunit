using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Test
{
    class Change_Password_Call
    {
        [TestFixture]
        //[Category("Sprint1")]
        class User : Global.Base
        {
            [Test, Order(1)]
            public void Change_Password()
            {
                Thread.Sleep(2000);
                Change_Password _Change_password = new Change_Password();
                _Change_password.Change_password();

            }
        }
    }
}
