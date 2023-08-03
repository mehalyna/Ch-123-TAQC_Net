using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace EventExpress.Pages

{

    public class AdminPage : CommonPage

    {
        private string AddCategoryXPath = "//button[normalize-space()='Add category']";

        private string FieldXPath = "//input[@placeholder='Name']";

        private string SelectDropdownCSS = "select[name='categoryGroup']";

        private string ConfirmButtonXpath = "//button[@type='submit']";


        private ButtonElement AddCategory => FindElementByXPath<ButtonElement>(AddCategoryXPath);

        private InputElements Field => FindElementByXPath<InputElements>(FieldXPath);

        private SelectElement GroupDropdown => new SelectElement(FindElement(By.CssSelector(SelectDropdownCSS)));

        private ButtonElement ConfirmButton => FindElementByXPath<ButtonElement>(ConfirmButtonXpath);


        public void ClickAddCategory() => AddCategory.Click();

        public void EnterCategory(string input) => Field.SendKeys(input);

        public void SelectCategory() => GroupDropdown.SelectByIndex(1);

        public void ClickConfirm()

        {

            Wait.Until(d => GroupDropdown.SelectedOption.Text == "Art&Craft");

            ConfirmButton.Click();

        }




    }

}
