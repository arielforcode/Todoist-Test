using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todoist.src.control
{
    public class Button: ControlSelenium
    {
        public Button(By Locator) : base(Locator)
        {

        }
    }
}
