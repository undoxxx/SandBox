using System;
using System.Collections.Generic; //これがないとダメ
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // P334 連想配列
            /*
            var dic = new Dictionary<string, string>();
            
            dic["ミカン"] = "果物屋";
            dic["ダイコン"] = "八百屋";

            Console.WriteLine(dic["ミカン"]);
            Console.WriteLine(dic["ダイコン"]);

            Console.WriteLine();

            foreach (var shop in dic)
            {
                Console.WriteLine(shop);
            }

            Console.WriteLine(); 

            foreach (var shop in dic)
            {
                Console.WriteLine(shop.Value);
            }
            */

            // 練習問題
            // 県庁所在地を連想配列で定義する
            // キー（添え字）：県名。値：県庁所在地。

            var dicPref = new Dictionary<string, string>();

            dicPref["北海道"] = "札幌市";
            dicPref["青森県"] = "青森市";
            dicPref["秋田県"] = "秋田市";
            dicPref["岩手県"] = "盛岡市";
            dicPref["山形県"] = "山形市";
            dicPref["宮城県"] = "仙台市";
            dicPref["福島県"] = "福島市";

            foreach (var pref in dicPref)
            {
                Console.Write(pref.Key);
                Console.Write(" : ");
                Console.Write(pref.Value);
                Console.WriteLine(); 
            }

            Console.ReadLine();
        }
    }
}
