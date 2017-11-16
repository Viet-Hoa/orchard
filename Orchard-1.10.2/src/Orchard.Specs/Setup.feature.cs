﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Setup")]
    public partial class SetupFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Setup.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Setup", "  In order to install orchard\r\n  As a new user\r\n  I want to setup a new site from" +
                    " the default screen", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Root request shows setup form")]
        public virtual void RootRequestShowsSetupForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Root request shows setup form", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "extension",
                        "names"});
            table1.AddRow(new string[] {
                        "Module",
                        @"Orchard.Setup, Orchard.Layouts, Orchard.Pages, Orchard.ContentPicker, Orchard.Blogs, Orchard.MediaLibrary, Orchard.Modules, Orchard.Packaging, Orchard.PublishLater, Orchard.Themes, Orchard.Scripting, Orchard.Widgets, Orchard.Users, Orchard.ContentTypes, Orchard.Roles, Orchard.Comments, Orchard.Resources, Orchard.Tags, TinyMce, Orchard.Recipes, Orchard.Warmup, Orchard.Alias, Orchard.Forms, Orchard.Tokens, Orchard.Autoroute, Orchard.Projections, Orchard.Fields, Orchard.MediaProcessing, Orchard.OutputCache, Orchard.Taxonomies, Orchard.Workflows, Orchard.Scripting.CSharp, Orchard.Conditions"});
            table1.AddRow(new string[] {
                        "Core",
                        "Common, Containers, Dashboard, Feeds, Navigation, Contents, Scheduling, Settings," +
                            " Shapes, XmlRpc, Title"});
            table1.AddRow(new string[] {
                        "Theme",
                        "SafeMode"});
#line 7
    testRunner.Given("I have a clean site with", ((string)(null)), table1, "Given ");
#line 12
    testRunner.When("I go to \"/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
    testRunner.Then("I should see \"Welcome to Orchard\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
        testRunner.And("I should see \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
        testRunner.And("the status should be 200 \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Setup folder also shows setup form")]
        public virtual void SetupFolderAlsoShowsSetupForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setup folder also shows setup form", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "extension",
                        "names"});
            table2.AddRow(new string[] {
                        "Module",
                        @"Orchard.Setup, Orchard.Layouts, Orchard.Pages, Orchard.ContentPicker, Orchard.Blogs, Orchard.MediaLibrary, Orchard.Modules, Orchard.Packaging, Orchard.PublishLater, Orchard.Themes, Orchard.Scripting, Orchard.Widgets, Orchard.Users, Orchard.ContentTypes, Orchard.Roles, Orchard.Comments, Orchard.Resources, Orchard.Tags, TinyMce, Orchard.Recipes, Orchard.Warmup, Orchard.Alias, Orchard.Forms, Orchard.Tokens, Orchard.Autoroute, Orchard.Projections, Orchard.Fields, Orchard.MediaProcessing, Orchard.OutputCache, Orchard.Taxonomies, Orchard.Workflows, Orchard.Scripting.CSharp, Orchard.Conditions"});
            table2.AddRow(new string[] {
                        "Core",
                        "Common, Containers, Dashboard, Feeds, Navigation, Contents, Scheduling, Settings," +
                            " Shapes, XmlRpc, Title"});
            table2.AddRow(new string[] {
                        "Theme",
                        "SafeMode"});
#line 18
    testRunner.Given("I have a clean site with", ((string)(null)), table2, "Given ");
#line 23
    testRunner.When("I go to \"/Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
    testRunner.Then("I should see \"Welcome to Orchard\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
        testRunner.And("I should see \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
        testRunner.And("the status should be 200 \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Some of the initial form values are required")]
        public virtual void SomeOfTheInitialFormValuesAreRequired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Some of the initial form values are required", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "extension",
                        "names"});
            table3.AddRow(new string[] {
                        "Module",
                        @"Orchard.Setup, Orchard.Layouts, Orchard.Pages, Orchard.ContentPicker, Orchard.Blogs, Orchard.MediaLibrary, Orchard.Modules, Orchard.Packaging, Orchard.PublishLater, Orchard.Themes, Orchard.Scripting, Orchard.Widgets, Orchard.Users, Orchard.ContentTypes, Orchard.Roles, Orchard.Comments, Orchard.Resources, Orchard.Tags, TinyMce, Orchard.Recipes, Orchard.Warmup, Orchard.Alias, Orchard.Forms, Orchard.Tokens, Orchard.Autoroute, Orchard.Projections, Orchard.Fields, Orchard.MediaProcessing, Orchard.OutputCache, Orchard.Taxonomies, Orchard.Workflows, Orchard.Scripting.CSharp, Orchard.Conditions"});
            table3.AddRow(new string[] {
                        "Core",
                        "Common, Containers, Dashboard, Feeds, Navigation, Contents, Scheduling, Settings," +
                            " Shapes, XmlRpc, Title"});
            table3.AddRow(new string[] {
                        "Theme",
                        "SafeMode"});
#line 29
    testRunner.Given("I have a clean site with", ((string)(null)), table3, "Given ");
#line 34
    testRunner.When("I go to \"/Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
        testRunner.And("I hit \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
    testRunner.Then("I should see \"Site name is required.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
        testRunner.And("I should see \"Password is required.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
        testRunner.And("I should see \"Password confirmation is required.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling setup on a brand new install")]
        public virtual void CallingSetupOnABrandNewInstall()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling setup on a brand new install", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "extension",
                        "names"});
            table4.AddRow(new string[] {
                        "Module",
                        @"Orchard.Setup, Orchard.Layouts, Orchard.Pages, Orchard.ContentPicker, Orchard.Blogs, Orchard.MediaLibrary, Orchard.Modules, Orchard.Packaging, Orchard.PublishLater, Orchard.Themes, Orchard.Scripting, Orchard.Widgets, Orchard.Users, Orchard.ContentTypes, Orchard.Roles, Orchard.Comments, Orchard.Resources, Orchard.Tags, TinyMce, Orchard.Recipes, Orchard.Warmup, Orchard.Alias, Orchard.Forms, Orchard.Tokens, Orchard.Autoroute, Orchard.Projections, Orchard.Fields, Orchard.MediaProcessing, Orchard.OutputCache, Orchard.Taxonomies, Orchard.Workflows, Orchard.Scripting.CSharp, Orchard.Conditions"});
            table4.AddRow(new string[] {
                        "Core",
                        "Common, Containers, Dashboard, Feeds, Navigation, Contents, Scheduling, Settings," +
                            " Shapes, XmlRpc, Title"});
            table4.AddRow(new string[] {
                        "Theme",
                        "SafeMode, TheAdmin, TheThemeMachine"});
#line 41
    testRunner.Given("I have a clean site with", ((string)(null)), table4, "Given ");
#line 46
        testRunner.And("I am on \"/Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "SiteName",
                        "My Site"});
            table5.AddRow(new string[] {
                        "AdminPassword",
                        "6655321"});
            table5.AddRow(new string[] {
                        "ConfirmPassword",
                        "6655321"});
#line 47
    testRunner.When("I fill in", ((string)(null)), table5, "When ");
#line 52
        testRunner.And("I hit \"Finish Setup\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
        testRunner.And("I go to \"/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
    testRunner.Then("I should see \"My Site\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
        testRunner.And("I should see \"Welcome, <strong><a href=\"/Users/Account/ChangePassword\">admin</a><" +
                    "/strong>!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
