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
    class Search_Skill_Call
    {
        [TestFixture]
        //[Category("Sprint1")]
        class User : Global.Base
        {
            [Test, Order(1)]
            public void Search_Skill()
            {
                Thread.Sleep(2000);
                Search_Skill _Search_skill = new Search_Skill();
                _Search_skill.Search_skill();

            }
            [Test, Order(2)]
            public void Search_Filter()
            {
                Thread.Sleep(2000);
                Search_Skill _Search_skill = new Search_Skill();
                _Search_skill.Search_Filter();
                

            }

        }
    }
}
