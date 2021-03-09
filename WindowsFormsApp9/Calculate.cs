using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    class Calculate
    {
        int a;
        public Calculate()
        {
            a = 10;     //mitonim be moteghayer ozve class 
                       //dakhele sazande meghdar dehi konim

            //num1 = 5;     ERROR
        }
        //tafavot a va num1: a moteghayer ozve classe va hame tavabe mitonan
        //azash estefade konan vali num1 faghat dar tavabe tarif shhode ast
        //bekhatere hamin nemitonim kharej az tabe estefade konim
        //chon kharej az tabe tarif nashode

        //bayad sathe dastresi ro public dar nazar
        //begirim ke ghable estefade bashe dide beshe
        
        
        /// <summary>
        /// add two string numbers
        /// </summary>
        /// <param name="a"> string num1 </param>
        /// <param name="b"> string num2 </param>
        /// <returns> an int value</returns>
        public int sum(string a, string b)
        {
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);

            return num1 + num2;
        }
        /// <summary>
        /// add two string numbers
        /// </summary>
        /// <param name="st"> st[0] num1 , st[1] num2 </param>
        /// <returns></returns>
        public int sum(string[] st)
        {
            int num1 = Convert.ToInt32(st[0]);
            int num2 = Convert.ToInt32(st[1]);

            return num1 + num2;
        }
        /// <summary>
        /// add two int numbers
        /// </summary>
        /// <param name="a"> int num1 </param>
        /// <param name="b"> int num2 </param>
        /// <returns></returns>
        public  int sum(int a, int b)
        {
            int sum = a + b;

            return sum;
           // return a + b;     ya intori
        }

        int diff(int a, int b)
        {
            int d;
            d = a - b;
            return d;
        }


    }
}
