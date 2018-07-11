using System;

using DesignPatternsStuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsStuffTests
{
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        public void FactoryTest()
        {
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            foreach(Document document in documents)
            {
                string pageNames = string.Empty;

                foreach(Page page in document.Pages)
                {
                    pageNames += page.GetType().Name;
                }

                if (document.GetType().Name == "Resume")
                {
                    Assert.IsTrue(pageNames == "SkillsPageEducationPageExperiencePage");
                }
                else if (document.GetType().Name == "Report")
                {
                    Assert.IsTrue(pageNames == "IntroductionPageResultsPageConclusionPageSummaryPageBibliographyPage");
                }
            }
        }
    }
}
