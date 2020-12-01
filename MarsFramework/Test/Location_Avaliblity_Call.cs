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
    class Location_Avaliblity_Call
    {
        class Education_Call
        {
            [TestFixture]
            //[Category("Sprint1")]
            class User : Global.Base
            {
                [Test, Order(1)]
                public void Location_Avaliblity()
                {
                    Thread.Sleep(2000);
                    Location_Avaliblity _Location = new Location_Avaliblity();
                    _Location.Location();

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
