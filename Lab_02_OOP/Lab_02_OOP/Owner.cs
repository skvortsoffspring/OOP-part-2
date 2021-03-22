using System;
using System.Xml.Serialization;

namespace Lab_02_OOP
{
    [Serializable]
    public class Owner
    {
        private string _firstName;
        private string _lastName;
        private string _patronymic;
        private DateTime _dateBirthDay;
        private string _seriesPassport;
        private string _numberPassport;

        [XmlElement(ElementName = "firstName")]
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        
        [XmlElement(ElementName = "lastName")]
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        [XmlElement(ElementName = "patrymonic")]
        public string Patronymic
        {
            get => _patronymic;
            set => _patronymic = value;
        }

        [XmlElement(ElementName = "birthday")]
        public DateTime DateBirthDay
        {
            get => _dateBirthDay;
            set => _dateBirthDay = value;
        }

        [XmlElement(ElementName = "seriesPassport")]
        public string SeriesPassport
        {
            get => _seriesPassport;
            set => _seriesPassport = value;
        }

        [XmlElement(ElementName = "numberPassport")]
        public string NumberPassport
        {
            get => _numberPassport;
            set => _numberPassport = value;
        }
        
        public Owner(string firstName, string lastName, string patronymic, DateTime dateBirthDay, string seriesPassport, string numberPassport)
        
        {
            _firstName = firstName;
            _lastName = lastName;
            _patronymic = patronymic;
            _dateBirthDay = dateBirthDay;
            _seriesPassport = seriesPassport;
            _numberPassport = numberPassport;
        }

        public Owner()
        {
        }
    }
}
