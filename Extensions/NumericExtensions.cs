
   
namespace Verbalize.Extensions
{
    public static class NumericExtension
    {
        public static string Verbalize(this int a)
        {
            string str = "";
            int b = 1000000000;
            while(a >= 10)
            {
                if(a / b != 0)
                {
                    str += Ming(a / b);
                    if(b == 1000000000) {str += "milliard ";}
                    if(b == 1000000) {str += "million ";}
                    if(b == 1000) {str += "ming ";}
                }
                a %= b;
                b /= 1000;
            }
            return str;
        }
        public static string Yuz(int a)
        {
            string str = "";
            str += Ming(a);
            str += "yuz ";
            return str;
        }
        public static string Ming(int a)
        {
            string str = "";
            var birlik = new[] {"", "bir ", "ikki ", "uch ", "to'rt ", "besh ", "olti ", "yetti ", "sakkiz ", "to'qqiz "};
            var onlik = new[] {"o'n ", "yigirma ", "o'ttiz ", "qirq ", "ellik ", "oltmish ", "yetmish ", "sakson ", "toqson "};
            if(a >= 100)
            { 
                str += Yuz(a / 100);
                a %= 100;
            }
            if(a >= 10)
            {
                str += onlik[a / 10 - 1];
                a %= 10;
            }
            str += birlik[a];

            return str;
        }
    }
}