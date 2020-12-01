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
    class Manage_Request_Call
    {
        class ManageRequest_Call
        {
            [TestFixture]
            //[Category("Sprint1")]
            class User : Global.Base
            {
                [Test, Order(1)]
                public void Manage_Request()
                {
                    Thread.Sleep(2000);
                    Manage_Request _Manage_Request = new Manage_Request();
                    _Manage_Request.Recevied_Request();

                }

                //[Test, Order(2)]
                //public void Education_Edit()
                //{
                //    Thread.Sleep(2000);



                //}
                //[Test, Order(3)]
                //public void Education_Delete()
                //{
                //    Thread.Sleep(2000);



            }
        }
    }
}
