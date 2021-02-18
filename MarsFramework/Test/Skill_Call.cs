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
    class Skill_Call
    {
        [TestFixture]
        //[Category("Sprint1")]
        class User : Global.Base
        {
            [Test, Order(1)]
            public void Skill_Add()
            {
                Thread.Sleep(2000);
                Skill _Skill = new Skill();
                
                

                for (int i = 2; i <= 4; i++)
                {
                    _Skill.Skill_Add(i);
                }

                for (int i = 2; i <= 4; i++)
                {
                    _Skill.Check_Skill(i);
                }
            }

            [Test, Order(2)]
            public void Skill_Edit()
            {
                Thread.Sleep(2000);
                Skill _Skill = new Skill();

 
                for (int i = 2; i <= 4; i++)
                {
                    _Skill.Skill_Edit(i);
                }
            }
            [Test, Order(3)]
            public void Skill_Delete()
            {
                Thread.Sleep(2000);
                Skill _Skill = new Skill();
                _Skill.Skill_Delete();


            }
        }
    }
}
