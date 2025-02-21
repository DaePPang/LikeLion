using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //로딩바 시작화면
            //게임 스토리

            Console.CursorVisible = false;

            Thread.Sleep(10000);

            Console.Write("■□□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■□□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■□□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■■□");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("■■■■■");
            Thread.Sleep(1000);
            Console.Clear();

            char[] progs = { '/', 'ㅡ', '＼','|' };
            for(int i = 0; i < 100; i++)
            {
                Console.Write(progs[i % 4]);
                Console.SetCursorPosition(0, Console.CursorTop);
                System.Threading.Thread.Sleep(80);

            }
            Console.WriteLine(" 꼬물꼬물 애벌레의 달콤한 모험 ");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("옛날 옛적, 작은 애벌레가 살았어요.");
            Console.ReadLine();
            Console.WriteLine("이 애벌레는 매일 푸른 나뭇잎을 먹으며 살았지만, 하늘을 자유롭게 날아다니는 나비들을 보며 늘 동경했답니다.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("어느 날, 할머니 나비에게서 전해 들은 이야기가 있었어요.");
            Console.ReadLine();
            Console.WriteLine("저 멀리 숲 깊은 곳에 황금빛으로 빛나는 신비한 사과가 있단다.\n그 사과를 먹은 애벌레는 가장 아름다운 나비로 변신할 수 있지.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("그 날부터 우리의 작은 애벌레는 황금 사과를 찾아 모험을 떠나기로 했답니다.\n과연 애벌레는 황금 사과를 찾을 수 있을까요?");
            Console.ReadLine();
            Console.WriteLine("그리고 정말로 아름다운 나비가 될 수 있을까요?");
            Console.ReadLine();
            Console.Clear();

            Console.Write("마 참 내 !! 드디어 등장!!");
            Console.WriteLine("\n\n");
            Console.Write("            =================================");
            Console.WriteLine("\n\n\n            꼬물꼬물 애벌레의 달콤한 모험 !!");
            Console.WriteLine("\n\n\n            =================================");



        }
    }
}
