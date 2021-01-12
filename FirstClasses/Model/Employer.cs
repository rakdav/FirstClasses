using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClasses.Model
{
    class Employer
    {
        private string firstName;
        private string post;
        private double oklad;
        public Employer(string firstName, string post, double oklad)
        {
            this.firstName = firstName;
            this.post = post;
            this.oklad = oklad;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Post
        {
            get { return post; }
            set { post = value; }
        }

        public double Oklad
        {
            get { return oklad; }
            set { oklad = value; }
        }

        public void Add()
        {
            this.oklad += this.oklad * 0.15;
        }

        public void Change()
        {
            if (firstName.StartsWith("Иван")) post = "Инженер";
        }
    }
}
