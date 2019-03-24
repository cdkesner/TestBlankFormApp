using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


//alternate method of storing the animal class.
namespace TestBlankForm.Classes
{
    //maybe wrong place for this??
    XmlDocument xmlDoc = new XmlDocument();
    xmlDoc.Load("http://10.101.4.18/ReportServer?%2FPetPoint%20Reports%2FAnimalInventory&amp;rs%3ACommand=Render&amp;rs%3AFormat=XML&amp;rs%3ASessionID=rl0gfl55fvbti545bkvzixf1&amp;rc%3ASchema=True
");


    public class Animal2
    {
        private XmlElement rawAnimal;

        public Animal2(XmlElement rawXml)
        {
            this.rawAnimal = rawXml;
        }
        
        //create a public get just like age here for each element we *intend* to use.
        public string Age
        {
            get
            {
                return this.rawAnimal.GetAttribute("Age");
            }
        }
    }
}
