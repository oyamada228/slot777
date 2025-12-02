using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot777
{

class SlotMachine
    {
        static Random random = new Random();

        static void Main()
        {
            Console.WriteLine("スロットマシンへようこそ！");
            Console.WriteLine("ボタンを押すにはEnterキーを押してください。");
            while (true)
            {
                Console.ReadLine(); // ユーザーの入力待ち
                string[] symbols = { "🍒", "🍋", "🔔", "⭐", "7" };
                string[] result = new string[3];

                // ランダムにシンボルを選択
                for (int i = 0; i < 3; i++)
                {
                    result[i] = symbols[random.Next(symbols.Length)];
                }

                // 結果を表示
                Console.WriteLine($"| {result[0]} | {result[1]} | {result[2]} |");

                // 揃ったか判定
                if (result[0] == result[1] && result[1] == result[2])
                {
                    Console.WriteLine("おめでとうございます！揃いました！");
                }
                else
                {
                    Console.WriteLine("残念！また挑戦してください。");
                }

                Console.WriteLine("もう一度プレイしますか？ (y/n)");
                string input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    break;
                }
            }
            Console.WriteLine("ゲーム終了。ありがとうございました！");
        }
    }
   
}

