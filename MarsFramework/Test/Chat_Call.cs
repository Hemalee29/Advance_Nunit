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
    internal class Chat_Call
    {
        [TestFixture]
        //[Category("Sprint1")]
        class User : Global.Base
        {
            [Test, Order(1)]
            public void Chat()
            {
                Thread.Sleep(2000);
                Chat _Chat = new Chat();
                _Chat.chat();

            }

        }
    }
}