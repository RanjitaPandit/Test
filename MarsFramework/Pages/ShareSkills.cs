using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using MarsFramework.Global;
using OpenQA.Selenium.Support.UI;

namespace MarsFramework.Pages
{
    class ShareSkills
    {
       
        public ShareSkills()
        {
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region Initialize Elements
        [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[1]/div/a[1]")]
        public IWebElement Dashboard { get; set; }

        [FindsBy(How = How.ClassName, Using = "item active")]
        public IWebElement Skills { get; set; }


        //[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/section[1]/div/div[2]/a")]
        [FindsBy(How = How.CssSelector, Using = "div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button")]
        public IWebElement ShareSkill { get; set; }

        
        // Title
        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement Title { get; set; }


        // Description

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement Description { get; set; }

        // Select Category

        [FindsBy(How = How.Name, Using = "categoryId")]
        public IWebElement Category { get; set; }

        // Select Graphics & Design

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement GraphicsDesign { get; set; }


        //Select SubCategory - Logo Design
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement LogoDesign { get; set; }


        //Select Tag Names
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        public IWebElement Tag { get; set; }

        //Select Service Type -Hourly Basis
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement ServiceTypeHourly { get; set; }

        //Select Service Type -One-off
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement ServiceTypeOnOff { get; set; }

        //Select Location Type - Onsite
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement LocationTypeOnsite { get; set; }

        //Select Location Type - Onsite
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)")]
        public IWebElement LocationTypeOnline { get; set; }

        //Avilable Days -Start Date
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)")]
        public IWebElement StartDate { get; set; }

        //Avilable Days -End Date
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)")]
        public IWebElement EndDate { get; set; }

        //Skill Trade - Skill Exchange
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement SkillExchange { get; set; }

        // Skill Exchange - Required Skills
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        public IWebElement RequiredSkills { get; set; }

        //Skill Trade - Credit
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement Credit { get; set; }


        //Credit - Enter Amount
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.ten.wide.column:nth-child(4) div:nth-child(1) div.ui.right.labeled.input > input:nth-child(2)")]
        public IWebElement CreditAmount { get; set; }

        // Status Active 
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement StatusActive { get; set; }

        // Status Hidden 
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement StatusHidden { get; set; }

        // Save Share Skills
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
        public IWebElement SaveShareSkills { get; set; }

        // Cancel Share Skills
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
        public IWebElement CancelShareSkills { get; set; }

        #endregion

        #region Add new Skill
        public void AddNewSkill()
        {
            string category = "Flyers & Brochures";
            string subcategory = "Others";

            System.Threading.Thread.Sleep(2000);

            ShareSkill.Click();
            System.Threading.Thread.Sleep(1500);

            // Enter Title
            Title.SendKeys("Selenium Tester");


            // Enter Description
            Description.SendKeys("I am a Selenium Expert. Would love to share my knowledge.");

            // Click on Category Dropdown
            Category.Click();


           //  var SelectElement = new SelectElement(subcategory);
           

            // Click on Sub-Category Dropdown
            //SubCategory.Click();

            // var SelectElement1 = new SelectElement(subcategory);

        }
        #endregion
    }
}
