using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todoist.src.control;

namespace Todoist.src.page
{
    public class MainPageTodoIst
    {
        public Button loginButton = new Button(By.XPath("//nav//a[text()=\"Log in\"]\r\n"));
    }
}
