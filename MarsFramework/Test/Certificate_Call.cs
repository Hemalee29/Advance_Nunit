﻿using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Test
{
    class Certificate_Call
    {
        [TestFixture]
        //[Category("Sprint1")]
        class User : Global.Base
        {
            [Test, Order(1)]
            public void Certificate_Add()
            {
                Thread.Sleep(2000);
                Certificate _certificate = new Certificate();
                for (int i = 2; i <= 3; i++)
                {
                    _certificate.Certificate_Add(i);
                    
                }

                for (int i = 2; i <= 3; i++)
                {
                    _certificate.Check_Certificate(i);

                }


            }

            [Test, Order(2)]
            public void Certificate_Edit()
            {
                Thread.Sleep(2000);
                Certificate _certificate = new Certificate();
                for (int i = 2; i <= 3; i++)
                {
                    _certificate.Certificate_Edit(i);



                }


            }
            [Test, Order(3)]
            public void Certificate_Delete()
            {
                Thread.Sleep(2000);
                Certificate _certificate = new Certificate();
                _certificate.Certificate_Delete();


            }
        }
    }
}
