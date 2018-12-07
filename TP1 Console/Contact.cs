using System;

namespace TP1_Console
{
    public class Contact
    {
        DateTime Naissance { get; set; }
        public int Age {
            get { return CalculAge(Naissance); }
        }

        public Contact(DateTime naisssance)
        {
            this.Naissance = naisssance;
        }

        int CalculAge(DateTime anniversaire)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - anniversaire.Year;
            if (anniversaire > now.AddYears(-age))
                age--;
            return age;
        }
    }
}
