using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todoist.src.page;

namespace Todoist.src.test
{
    [TestClass]
    public class Project:TestBase
    {
        MainPageTodoIst mainPage = new MainPageTodoIst();
        LoginPage loginPage = new LoginPage();
        LeftMenu leftMenu = new LeftMenu();

        string username = "colocar email con cuenta creada";
        string password = "password de la cuenta creada";

        [TestMethod]
        public void TodoistTest()
        {
            
            mainPage.loginButton.Click();
            loginPage.emailTextBox.SetText(username);
            loginPage.passwordTextBox.SetText(password);
            loginPage.loginbutton.Click();

            leftMenu.addProjectButton.Click();
            leftMenu.projectName.SetText("New project Mrx");
            leftMenu.confirmAddition.Click();

            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed("New project Mrx"), "ERROR! The project not created");
            leftMenu.ClickProjectName("New project Mrx");
            leftMenu.editProjectButton.Click();


            leftMenu.projectName.SetText("New project red updated");
            leftMenu.confirmProjectUpdate.Click();

            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed("New project red updated"), "ERROR! The project not updated");

            leftMenu.ClickProjectName("New project red updated");
            leftMenu.deleteProjectButton.Click();
            leftMenu.deleteConfirmationButton.Click();

            Assert.IsFalse(leftMenu.ProjectNameIsDisplayed("New project red updated"), "ERROR! The project not deleted");
            
        }
    }
}
