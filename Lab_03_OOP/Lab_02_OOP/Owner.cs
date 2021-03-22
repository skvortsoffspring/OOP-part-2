using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;

namespace Lab_02_OOP
{
    [Serializable]
    public class Owner: ValidationAttribute
    {
        private DateTime _dateBirthDay;
        private string _firstName;
        private string _lastName;
        private string _numberPassport;
        private string _patronymic;
        private string _seriesPassport;

        public Owner(string firstName, string lastName, string patronymic, DateTime dateBirthDay, string seriesPassport,
            string numberPassport)

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

        [XmlElement(ElementName = "firstName")]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        [XmlElement(ElementName = "patrymonic")]
        [Required(ErrorMessage = "Поле не может быть пустым")]
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
        [StringLength(2)]
        [Required (ErrorMessage = "Для серии должны быть равна двум")]
        public string SeriesPassport
        {
            get => _seriesPassport;
            set => _seriesPassport = value;
        }
        [Range(1000000,9999999,ErrorMessage = "Неверный диапозон номера паспорта")]
        [XmlElement(ElementName = "numberPassport")]
        public string NumberPassport
        {
            get => _numberPassport;
            set => _numberPassport = value;
        }

        public override bool IsValid(object value)
        {
            var obj = value as Score;

            if (obj == null) return false;
            var array = new[] {"AB", "BM", "HB", "KH", "MP", "MC", "KB", "PP", "SP", "DP"};
            return array.Any(temp => temp == obj.Owner._seriesPassport.ToUpper());
        }
    }
}