﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Diia_UITests.Features.MainPage
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Header")]
    [NUnit.Framework.CategoryAttribute("MainPage")]
    [NUnit.Framework.CategoryAttribute("Header")]
    public partial class HeaderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "MainPage",
                "Header"};
        
#line 1 "Header.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/MainPage", "Header", "As a user\r\nI want the header on the site\r\nIn order to access the main services of" +
                    " the site", ProgrammingLanguage.CSharp, new string[] {
                        "MainPage",
                        "Header"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
#line 8
 testRunner.Given("Main page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the ability to open the Service pages using the link in the header services" +
            " section")]
        [NUnit.Framework.CategoryAttribute("MainPage")]
        [NUnit.Framework.CategoryAttribute("Header")]
        [NUnit.Framework.CategoryAttribute("HeaderMenu")]
        [NUnit.Framework.TestCaseAttribute("Довідки та витяги", null)]
        [NUnit.Framework.TestCaseAttribute("Навколишнє середовище", null)]
        [NUnit.Framework.TestCaseAttribute("Безпека та правопорядок", null)]
        [NUnit.Framework.TestCaseAttribute("Сім’я", null)]
        [NUnit.Framework.TestCaseAttribute("Підприємництво", null)]
        [NUnit.Framework.TestCaseAttribute("Транспорт", null)]
        [NUnit.Framework.TestCaseAttribute("Земля, будівництво, нерухомість", null)]
        [NUnit.Framework.TestCaseAttribute("Ліцензії та дозволи", null)]
        [NUnit.Framework.TestCaseAttribute("Здоров\'я", null)]
        [NUnit.Framework.TestCaseAttribute("Пенсії, пільги та допомога", null)]
        [NUnit.Framework.TestCaseAttribute("Земля, будівництво, нерухомість", null)]
        [NUnit.Framework.TestCaseAttribute("Ліцензії та дозволи", null)]
        [NUnit.Framework.TestCaseAttribute("Транспорт", null)]
        [NUnit.Framework.TestCaseAttribute("Медицина та фармацевтика", null)]
        [NUnit.Framework.TestCaseAttribute("Витяги та довідки", null)]
        [NUnit.Framework.TestCaseAttribute("Створення бізнесу", null)]
        public virtual void CheckTheAbilityToOpenTheServicePagesUsingTheLinkInTheHeaderServicesSection(string servicesSubMenuLinkText, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "MainPage",
                    "Header",
                    "HeaderMenu"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ServicesSubMenuLinkText", servicesSubMenuLinkText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the ability to open the Service pages using the link in the header services" +
                    " section", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 12
 testRunner.When("I click the link \'Послуги\' in the header menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.When(string.Format("I click link {0} from Services list", servicesSubMenuLinkText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then(string.Format("Page with title {0} opens", servicesSubMenuLinkText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the closing of the pop-up header menu by clicking on an area outside the he" +
            "ader menu")]
        [NUnit.Framework.CategoryAttribute("MainPage")]
        [NUnit.Framework.CategoryAttribute("Header")]
        [NUnit.Framework.CategoryAttribute("HeaderMenu")]
        public virtual void CheckTheClosingOfThePop_UpHeaderMenuByClickingOnAnAreaOutsideTheHeaderMenu()
        {
            string[] tagsOfScenario = new string[] {
                    "MainPage",
                    "Header",
                    "HeaderMenu"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the closing of the pop-up header menu by clicking on an area outside the he" +
                    "ader menu", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 37
 testRunner.When("I click the link \'Послуги\' in the header menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then("The header pop-up menu expands", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.When("I click on an area outside the header menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.Then("The header pop-up menu collapses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the closing of the pop-up header menu by clicking on the button that opened" +
            " the menu")]
        [NUnit.Framework.CategoryAttribute("MainPage")]
        [NUnit.Framework.CategoryAttribute("Header")]
        [NUnit.Framework.CategoryAttribute("HeaderMenu")]
        public virtual void CheckTheClosingOfThePop_UpHeaderMenuByClickingOnTheButtonThatOpenedTheMenu()
        {
            string[] tagsOfScenario = new string[] {
                    "MainPage",
                    "Header",
                    "HeaderMenu"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the closing of the pop-up header menu by clicking on the button that opened" +
                    " the menu", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 44
 testRunner.When("I click the link \'Послуги\' in the header menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then("The header pop-up menu expands", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.When("I click the link \'Послуги\' in the header menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("The header pop-up menu collapses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the ability to open the News page using the links in the header menu sectio" +
            "n")]
        [NUnit.Framework.CategoryAttribute("MainPage")]
        [NUnit.Framework.CategoryAttribute("Header")]
        [NUnit.Framework.CategoryAttribute("HeaderMenu")]
        public virtual void CheckTheAbilityToOpenTheNewsPageUsingTheLinksInTheHeaderMenuSection()
        {
            string[] tagsOfScenario = new string[] {
                    "MainPage",
                    "Header",
                    "HeaderMenu"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the ability to open the News page using the links in the header menu sectio" +
                    "n", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 50
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 51
 testRunner.When("I click the link \'Новини\' in the header menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.Then("The News page with title \'Новини\' opens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the ability to open the Faq page using the links in the header menu section" +
            "")]
        [NUnit.Framework.CategoryAttribute("MainPage")]
        [NUnit.Framework.CategoryAttribute("Header")]
        [NUnit.Framework.CategoryAttribute("HeaderMenu")]
        public virtual void CheckTheAbilityToOpenTheFaqPageUsingTheLinksInTheHeaderMenuSection()
        {
            string[] tagsOfScenario = new string[] {
                    "MainPage",
                    "Header",
                    "HeaderMenu"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the ability to open the Faq page using the links in the header menu section" +
                    "", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 55
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 56
 testRunner.When("I click the link \'Питання та відповіді\' in the header menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("The Faq page with title \'Поширені запитання\' opens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
