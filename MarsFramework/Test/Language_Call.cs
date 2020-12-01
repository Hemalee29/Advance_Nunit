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
    class Language_Call
    {
        [TestFixture]
        //[Category("Sprint1")]
        class User : Global.Base
        {
            [Test, Order(1)]
            public void Langauge_Add()
            {
                Thread.Sleep(2000);
                Langauge _Language = new Langauge();
                _Language.Langauge_Add();

            }

            [Test, Order(2)]
            public void Langauge_Edit()
            {
                Thread.Sleep(2000);
                Langauge _Language = new Langauge();
                _Language.Language_Edit();

            }
            [Test, Order(3)]
            public void Langauge_Delete()
            {
                Thread.Sleep(2000);
                Langauge _Language = new Langauge();
                _Language.Language_Delete();

            }
        }
    }
}