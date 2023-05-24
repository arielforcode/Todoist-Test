using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todoist.src.control;

namespace Todoist.src.page
{
    public class LoginPage
    {
        public TextBox emailTextBox = new TextBox(By.XPath("//input[@id=\"element-0\"]"));
        public TextBox passwordTextBox = new TextBox(By.XPath("//input[@id=\"element-3\"]"));
        public Button loginbutton = new Button(By.XPath("//div[2]//div/form/button"));

    }
}
