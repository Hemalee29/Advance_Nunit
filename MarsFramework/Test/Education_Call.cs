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
    class Education_Call
    {
        [TestFixture]
        //[Category("Sprint1")]
        class User : Global.Base
        {
            [Test, Order(1)]
            public void Education_Add()
            {
                Thread.Sleep(2000);
                Education _Education = new Education(); 
                
                for (int i = 2; i <= 3; i++)
                {
                    _Education.Education_Add(i);
                    
                }

                for (int i = 2; i <= 3; i++)
                {
                    _Education.Check_Education(i);

                }

            }

            [Test, Order(2)]
            public void Education_Edit()
            {
                Thread.Sleep(2000);
                Education _Education = new Education();
               
                for (int i = 2; i <= 3; i++)
                {
                    _Education.Education_Edit(i);
                    
                }

            }
            [Test, Order(3)]
            public void Education_Delete()
            {
                Thread.Sleep(2000);
                Education _Education = new Education();
                _Education.Education_Delete();


            }
        }
    }
}
