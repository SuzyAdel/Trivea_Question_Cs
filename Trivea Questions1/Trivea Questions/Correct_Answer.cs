using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivea_Questions
{
    internal class Correct_Answer:ArayLyst
    {
        public ArayLyst ansflag;
        public ArayLyst anscity;
        public ArayLyst ansmath;
        public Correct_Answer():base(1)
        {
            ansflag = new ArayLyst(19);

            anscity=new ArayLyst(9);
            ansmath=new ArayLyst(11);
            //Math
            ansmath.Add("1");//0
            ansmath.Add("33");//1
            ansmath.Add("6");//2
            ansmath.Add("4");//3
            ansmath.Add("102");//4
            ansmath.Add("105");//5
            ansmath.Add("26");//6
            ansmath.Add("67");//7
            ansmath.Add("21");//8
            ansmath.Add("89");//9
            ansmath.Add("90");//10 , size=11
            //City
            anscity.Add("Paris");//0
            anscity.Add("New York");//1
            anscity.Add("Cairo");//2
            anscity.Add("Riyadh");//3
            anscity.Add("Jeddah");//4
            anscity.Add("Alexandria");//5
            anscity.Add("Tokyo");//6
            anscity.Add("Dusseldorf");//7
            anscity.Add("Sydney");//8 size=9

            //Flag
            ansflag.Add("Jordan");//0
            ansflag.Add("Mexico");//1
            ansflag.Add("Canada");//2
            ansflag.Add("Morroco");//3
            ansflag.Add("Australia");//4
            ansflag.Add("Argentina");//5
            ansflag.Add("France");//6
            ansflag.Add("Germany");//7
            ansflag.Add("Hungary");//8
            ansflag.Add("Azerbijan");//9
            ansflag.Add("Liberia");//10
            ansflag.Add("Egypt");//11
            ansflag.Add("United Kingdom");//12
            ansflag.Add("Iran");//13
            ansflag.Add("Macdonia");//14
            ansflag.Add("Sudan");//15
            ansflag.Add("North Korea");//16
            ansflag.Add("South Korea");//17
            ansflag.Add("Japan");//18, size 19



        }
    }
}
