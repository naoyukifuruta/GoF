/**
 * 参考
 * https://qiita.com/a1146234/items/bba88081b0f84d70da1f
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            IAlly nakao = new Brave("勇者");
            string[] nakaoMagic = { "メラ", "ギラ" };
            string[] nakaoSkill = { "一閃突", "ナイフ投げ" };
            string[] nakaoItem = { "薬草" };
            nakao.SetMagic(nakaoMagic);
            nakao.SetSkill(nakaoSkill);
            nakao.SetItem(nakaoItem);

            string monsterName = "スライム";
            string[] monsterSkill = { "こうげき", "ホイミ", "スタンガン", "恐喝", "ガン付", "呪い" };

            IState[] states = { Poison.getInstance(), Sleep.getInstance(), Paralyzed.getInstance(), Confused.getInstance(), Silence.getInstance(), Curse.getInstance(), Poison.getInstance() };

            int escape = 0;

            Console.WriteLine(monsterName + "が現れた。");

            while (true)
            {
                Console.WriteLine("どうする？ [0:戦う][1:魔法][2:特技][3:防御][4:道具][5:逃走]");
                int command;
                do
                {
                    command = ReadInt(states.Length);
                } while (command == -1);
                switch (command)
                {
                    case 0:
                        nakao.Attack(monsterName);
                        break;
                    case 1:
                        Console.WriteLine("使用する魔法は？");
                        printArray(nakaoMagic);
                        do
                        {
                            command = ReadInt(nakaoMagic.Length);
                        } while (command == -1);
                        nakao.Magic(command, monsterName);
                        break;
                    case 2:
                        Console.WriteLine("使用するスキルは？");
                        printArray(nakaoSkill);
                        do
                        {
                            command = ReadInt(nakaoSkill.Length);
                        } while (command == -1);
                        nakao.Skill(command, monsterName);
                        break;
                    case 3:
                        nakao.Defence();
                        break;
                    case 4:
                        Console.WriteLine("使用するアイテムは？");
                        printArray(nakaoItem);
                        do
                        {
                            command = ReadInt(nakaoItem.Length);
                        } while (command == -1);
                        nakao.Item(command);
                        break;
                    case 5:
                        escape = nakao.Escape();
                        break;
                }

                if (escape == 1)
                {
                    return;
                }

                int enemyCommand = rnd.Next(6);
                Console.WriteLine(monsterName + "は" + monsterSkill[enemyCommand] + "スキルを使用した。");
                nakao.ChangeState(states[enemyCommand]);
                command = -1;
            }
        }

        public static int ReadInt(int max)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= max)
                {
                    Console.WriteLine("コマンド選んで！");
                    return -1;
                }
                return num;
            }
            catch (Exception)
            {
                Console.WriteLine("数字入力して！");
                return -1;
            }
        }

        public static void printArray(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(i + " : " + str[i]);
            }
        }
    }
}
