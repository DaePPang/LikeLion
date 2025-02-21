using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study3
{
    class Program
    {
        static void Main(string[] args)
        {
            //리터럴 : 코드에서 고정된 값을 의미한다.

            //int num = 10;                                                           // 정수형 리터럴        
            //double pi = 3.14;                                                   // 실수형 리터럴
            //char letter = 'A';                                                   // 문자형 리터럴
            //String name = "Alice";                                        // 문자열 리터럴

            //Console.WriteLine(num);                                 // 출력 값 = 10
            //Console.WriteLine(pi);                                      // 출력 값 = 3.14
            //Console.WriteLine(letter);                              // 출력 값 = A
            //Console.WriteLine(name);                              // 출력 값 = Alice  

            /*
             *  강사님 말씀 : double 대신 Float 자주 사용함
             *  - 문자 하나 넣을 때, [ ex) A ] ' '를 사용하고, 
             *     단어 하나 넣을 때, [ ex) Apple ] " "를 사용합니다. 
             *  
             *  
             */

            /*
             * 깜짝 과제
             *  캐릭터
             *  hp : 100
             *  att : 56.7
             *  캐릭터이름 : ??
             *  등급 : S
             */

            int hp = 100;
            double att = 56.7;
            String ChName = "김빵빵";
            char grade = 'S';

            Console.WriteLine("캐릭터");
            Console.WriteLine("HP : "+hp);
            Console.WriteLine("공격력 : "+att);
            Console.WriteLine("이름 : "+ChName);
            Console.WriteLine("등급 : "+grade); 


        }
    }
}
