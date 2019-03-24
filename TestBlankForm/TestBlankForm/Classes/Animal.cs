using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TestBlankForm.Classes
{
    public class Animal

    {
        [XmlAttribute(AttributeName = "Videos")]
        public string Videos { get; set; } //yes or no

        [XmlAttribute(AttributeName = "NumberOfPictures")]
        public int NumberOfPictures { get; set; } //seems to be 0-3

        [XmlAttribute(AttributeName = "Danger")]
        public string Danger { get; set; } //yes or no

        [XmlAttribute(AttributeName = "AnimalWeight")]
        public string AnimalWeight { get; set; }

        [XmlAttribute(AttributeName = "Species")] //Dog or Cat
        public string Species { get; set; }

        [XmlAttribute(AttributeName = "PrimaryBreed")]
        public string PrimaryBreed { get; set; }

        [XmlAttribute(AttributeName = "Sex")] //M or F
        public string Sex { get; set; }

        [XmlAttribute(AttributeName = "AnimalName")]
        public string AnimalName { get; set; }

        [XmlAttribute(AttributeName = "Age")]
        public string Age { get; set; }

        //might change this to a date later. depends on if/how we want to sort by age. we could take the birthdate element instead.
        //might look something like this.
        //[XmlIgnore]
        //public DateTime Date { get; set; }

        //[XmlElement]
        //public String ProxyDate
        //{
        //    get { return Date.ToString("D"); }
        //    set { Date = DateTime.Parse(value); }
        //}

        [XmlAttribute(AttributeName = "Color")]
        public string Color { get; set; }

    }
}
