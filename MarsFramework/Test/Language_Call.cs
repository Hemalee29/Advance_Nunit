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
                for(int i=2; i<=5; i++)
                {
                    _Language.Langauge_Add(i);
                    //_Language.Check_Language(i);
                }

                for (int i=2; i<=5; i++)
                {
                    //_Language.Langauge_Add(i);
                    _Language.Check_Language(i);
                    break;
                }
            }

            [Test, Order(2)]
            public void Langauge_Edit()
            {
                Thread.Sleep(2000);
                Langauge _Language = new Langauge();
                //for (int i=2; i<=5; i++)
                //{
                    _Language.Language_Edit(3);
                //}

                
                    //_Language.Check_Edit_Language(3);
               


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