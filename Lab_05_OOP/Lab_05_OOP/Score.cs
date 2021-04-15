using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Lab_02_OOP
{
    [Serializable]
    public enum TypeDeposit
    {
        [XmlEnum("notSelect")] NotSelect,
        [XmlEnum("shortTerm")] ShortTerm,
        [XmlEnum("LongTerm")] LongTerm,
        [XmlEnum("Indefinite")] Indefinite
    }

    [XmlRoot(Namespace = "classScore")]
    [XmlType("score")]
    public class Score : IValidatableObject
    {
        [XmlIgnore]
        public INotice Notice {private get; set;}
        
        public Score()
        {
        }

        public Score(
            string firstName,
            string lastName,
            string patrimonyc,
            string seriesPassport,
            string numberPassport,
            DateTime dateTime,
            int number,
            TypeDeposit typeDeposit,
            double balance,
            DateTime dateOpened,
            bool connectSms,
            bool connectBanking
        )
        {
            Owner.FirstName = firstName;
            Owner.LastName = lastName;
            Owner.Patronymic = patrimonyc;
            Owner.NumberPassport = numberPassport;
            Owner.SeriesPassport = seriesPassport;
            Number = number;
            TypeDeposit = typeDeposit;
            Balance = balance;
            DateOpened = dateOpened;
            ConnectSms = connectSms;
            ConnectBanking = connectBanking;
           
        }

        public Owner Owner { get; set; } = new Owner();
        [RegularExpression(@"^[0-9]\d{7}$", ErrorMessage ="Номер счета должен быть не меньше 7 символов")]
        [XmlElement(ElementName = "number")] public int Number { get; set; }

        [XmlElement(ElementName = "typeDeposit")]
        public TypeDeposit TypeDeposit { get; set; }

        [XmlElement(ElementName = "balance")] public double Balance { get; set; }

        [XmlElement(ElementName = "date opened")]
        public DateTime DateOpened { get; set; }

        [XmlElement(ElementName = "SMS")] public bool ConnectSms { get; set; }

        [XmlElement(ElementName = "banking")] public bool ConnectBanking { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errorList = new List<ValidationResult>();
            if (Owner.LastName.Length == 0) errorList.Add(new ValidationResult("Не указана фамилия."));
            if (Owner.FirstName.Length == 0) errorList.Add(new ValidationResult("Не указано имя."));
            if (Owner.Patronymic.Length == 0) errorList.Add(new ValidationResult("Не указано отчество."));
            if (Owner.SeriesPassport.Length == 0) errorList.Add(new ValidationResult("Не указана серия."));
            if (Owner.SeriesPassport.Length != 2) errorList.Add(new ValidationResult("Не верный формат (верный XX)."));
            if (Owner.NumberPassport.Length == 0) errorList.Add(new ValidationResult("Не указан номер паспорта."));
            if (TypeDeposit == TypeDeposit.NotSelect) errorList.Add(new ValidationResult("Выберите тип дипозита"));
            return errorList;
        }

        private void TestScore()
        {
            if (ConnectBanking && ConnectSms)
            {
                Notice = new NoticeVip();
            }
            else
            {
                Notice = new NoticeNormal();
            }
        }

        public void SendEmail()
        {
            TestScore();
            Notice.SendEmail();
        }

        public void SendSms()
        {
            TestScore();
            Notice.SendSms();
        }
        
    }
}