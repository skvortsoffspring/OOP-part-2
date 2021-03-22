using System;
using System.Xml.Serialization;

namespace Lab_02_OOP
{
    [Serializable]
    public enum TypeDeposit
    {
        [XmlEnum("notSelect")]
        NotSelect,
        [XmlEnum("shortTerm")]
        ShortTerm,
        [XmlEnum("LongTerm")]
        LongTerm,
        [XmlEnum("Indefinite")]
        Indefinite
    }
    
    [XmlRoot(Namespace = "classScore")]
    [XmlType("score")]
    public class Score
    {
        public Owner Owner
        {
            get => _owner;
            set => _owner = value;
        }

        private Owner _owner = new Owner();
        private int _number;
        private TypeDeposit _typeDeposit;
        private double _balance;
        private DateTime _dateOpened;
        private bool _connectSms;
        private bool _connectBanking;

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
            _owner.FirstName = firstName;
            _owner.LastName = lastName;
            _owner.Patronymic = patrimonyc;
            _owner.NumberPassport = numberPassport;
            _owner.SeriesPassport = seriesPassport;
            _number = number;
            _typeDeposit = typeDeposit;
            _balance = balance;
            _dateOpened = dateOpened;
            _connectSms = connectSms;
            _connectBanking = connectBanking;
        }

        [XmlElement(ElementName = "number")]
        public int Number
        {
            get => _number;
            set => _number = value;
        }
        
        [XmlElement(ElementName = "typeDeposit")]
        public TypeDeposit TypeDeposit
        {
            get => _typeDeposit;
            set => _typeDeposit = value;
        }

        [XmlElement(ElementName = "balance")]
        public double Balance
        {
            get => _balance;
            set => _balance = value;
        }

        [XmlElement(ElementName = "date opened")]
        public DateTime DateOpened
        {
            get => _dateOpened;
            set => _dateOpened = value;
        }

        [XmlElement(ElementName = "SMS")]
        public bool ConnectSms
        {
            get => _connectSms;
            set => _connectSms = value;
        }

        [XmlElement(ElementName = "banking")]
        public bool ConnectBanking
        {
            get => _connectBanking;
            set => _connectBanking = value;
        }
    }
}
