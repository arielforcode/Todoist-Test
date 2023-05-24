using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todoist.src.control;

namespace Todoist.src.page
{
    public class LeftMenu
    {
        public Button addProjectButton = new Button(By.XPath("//div//div[@id='left_menu']//div//div//button[@aria-label='Add project']"));
        public TextBox projectName = new TextBox(By.XPath("//form//div/div//input[@name='name']"));
        public Button confirmAddition = new Button(By.XPath("//form//footer/div/button[2]"));
        public Button editProjectButton = new Button(By.XPath("//div[@class=' popper']//ul//li[4]"));
        public Button confirmProjectUpdate = new Button(By.XPath("//form//footer/div/button[2]"));
        public Button deleteProjectButton = new Button(By.XPath("//div[@class=' popper']//ul//li[13]"));
        public Button deleteConfirmationButton = new Button(By.XPath("//form//footer/div/button[2]"));

        public Boolean ProjectNameIsDisplayed(String projectName)
        {
            Label labelProjectName = new Label(By.XPath("//ul[@id=\"projects_list\"]//li[last()]//span[text()='" + projectName + "']"));
            return labelProjectName.IsControlDisplayed();
        }
        public void ClickProjectName(String projectName)
        {
            Label lastProject = new Label(By.XPath("//ul[@id='projects_list']//li//span[text()='" + projectName + "']//following::button[@aria-label='More project actions']"));
            lastProject.Click();
        }
    }
}
