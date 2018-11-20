using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A107222011_99商店折扣計算
{
    //專案:折扣計算99商店
    //日期:2018.11.20
    //姓名:A107222011 林紘毅

    class Discount
    {
        static void Main(string[] args)
        {
            int Q;
            string isMember;
            introduction();
            try
            {
                Console.WriteLine("請輸入您要購買的件數:");
                Q = int.Parse(Console.ReadLine());
                Console.WriteLine("請問您是否為會員(是請輸入y, 否請輸入n):");
                isMember = Console.ReadLine();
                Console.WriteLine("最後價格:" + discount(Q, isMember) + "元");
                Console.WriteLine("感謝惠顧!!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            
        }

        static void introduction()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("              *　　　　　　　　　*              ");
            Console.WriteLine("            *　　*　　　　　   *    *           ");
            Console.WriteLine("            *　　*　　　　　　 *    *           ");
            Console.WriteLine("             *  *　　　　　　   *  *            ");
            Console.WriteLine("               *　　　　　　      *             ");
            Console.WriteLine("              *　　　　　　      *              ");
            Console.WriteLine("             *　　　　　　      *               ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("　              　9 9 元 商 店                  ");
            Console.WriteLine("      99元商店內所有商品每件原價都是99元        ");
            Console.WriteLine("             適逢週年慶有打折活動               ");
            Console.WriteLine("================================================");
        }

        static int discount(int Q, string isMember)
        {
            int price = 99;
            int total = price * Q;
            double discountedPrice = 0;

            if (isMember == "y" || isMember == "Y")
            {
                if (Q >= 0 && Q < 8)
                {
                    discountedPrice = total;
                }
                else if (Q >= 8 && Q <= 35)
                {
                    discountedPrice = total * 0.72;
                }
                else if (Q >= 36 && Q <= 89)
                {
                    discountedPrice = total * 0.63;
                }
                else if (Q >= 90)
                {
                    discountedPrice = total * 0.54;
                }
            }
            else if (isMember == "n" || isMember == "N")
            {
                if (Q >= 0 && Q < 12)
                {
                    discountedPrice = total;
                }
                else if (Q >= 12 && Q <= 32)
                {
                    discountedPrice = total * 0.87;
                }
                else if (Q >= 33 && Q <= 95)
                {
                    discountedPrice = total * 0.76;
                }
                else if (Q >= 96)
                {
                    discountedPrice = total * 0.65;
                }
            }
            return Convert.ToInt32(Math.Round(discountedPrice, MidpointRounding.AwayFromZero));
        }
    }
}
