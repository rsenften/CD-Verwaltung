using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // Wählen Sie zum Generieren von Code für den Test im Kontextmenü "Code für Coded UI-Test generieren" aus, und wählen Sie eine der Menüelemente aus.
            //this.UIMap.TestFallErstellen();
            this.UIMap.Test_Erstellen();
            this.UIMap.Test_Erstellen_Assert();
            this.UIMap.Test_Bearbeiten_Arrange_Act();
            this.UIMap.Test_Bearbeiten_Assert();
            //this.UIMap.Negativ_Test_Erstellen();
            //this.UIMap.Negativ_Test_Erstellen_Assert();
            this.UIMap.Negativ_Test_Erstellen_Arrange_Act();
            this.UIMap.Negativ_Test_Erstellen_Assert_Neu();


        }

        #region Zusätzliche Testattribute

        // Sie können beim Schreiben der Tests folgende zusätzliche Attribute verwenden:

        ////Verwenden Sie "TestInitialize", um vor dem Ausführen der einzelnen Tests Code auszuführen 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Wählen Sie zum Generieren von Code für den Test im Kontextmenü "Code für Coded UI-Test generieren" aus, und wählen Sie eine der Menüelemente aus.
        //}

        ////Verwenden Sie "TestCleanup", um nach dem Ausführen der einzelnen Tests Code auszuführen
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Wählen Sie zum Generieren von Code für den Test im Kontextmenü "Code für Coded UI-Test generieren" aus, und wählen Sie eine der Menüelemente aus.
        //}

        #endregion

        /// <summary>
        ///Dient zum Abrufen oder Festlegen des Textkontexts, der Informationen über
        ///den aktuellen Testlauf und dessen Funktionalität bereitstellt.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
