using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivea_Questions
{
    class Fixed_Question:ArayLyst
    {
        public ArayLyst question;
        

        public Fixed_Question():base(6)
        {
           question = new ArayLyst(6);
            question.Add("9/3*(1+2)");
            question.Add("7*5-4+2");
            question.Add("Which Country's Flag is this?!");
            question.Add("Which Companiy's Logo is this?!");
            question.Add("What is this City Name?!");
            question.Add("30+4-64/8");

        }
        

    }
}
