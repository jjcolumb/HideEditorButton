using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HideEditorButton.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class DomainObject1 : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public DomainObject1(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        DomainObject2 dO2;
        DayOfWeek dayOfWeek;
        DateTime birthDay;
        int age;
        string address;
        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set
            {
                SetPropertyValue(nameof(Name), ref name, value);
            }
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Address
        {
            get => address;
            set
            {
                SetPropertyValue(nameof(Address), ref address, value);
            }
        }
        public int Age
        {
            get => age;
            set => SetPropertyValue(nameof(Age), ref age, value);
        }

        public DateTime BirthDay
        {
            get => birthDay;
            set => SetPropertyValue(nameof(BirthDay), ref birthDay, value);
        }

        public DayOfWeek DayOfWeek
        {
            get => dayOfWeek;
            set => SetPropertyValue(nameof(DayOfWeek), ref dayOfWeek, value);
        }

        public DomainObject2 DO2
        {
            get => dO2;
            set => SetPropertyValue(nameof(DO2), ref dO2, value);
        }
    }
}