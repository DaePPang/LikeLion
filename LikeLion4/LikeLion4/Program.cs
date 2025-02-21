using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3. 문자열
            Console.WriteLine("3. 문자열");
            string greeting;    // 문자열 변수 선언
            greeting = "Hello, World!";     // 변수에 값을 저장


            //출력 부
            Console.WriteLine(greeting);    //   출력 : Hello, World!

            /*------------------*/

            Console.WriteLine("");
            Console.WriteLine("<------->");
            Console.WriteLine("");

            /*------------------*/

            // 4. 변수 선언과 초기화를 한번에 수행
            Console.WriteLine("4. 변수 선언과 초기화를 한번에 수행");
            int score = 100;                             // 정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5;    // 실수형 변수 선언과 초기화
            string city = "Seoul";                  // 문자열 변수 선언과 초기화
           
            //출력 부
            Console.WriteLine(score);               // 출력: 100
            Console.WriteLine(temperature); // 출력: 36.5
            Console.WriteLine(city);                   // 출력: Seoul


            /*------------------*/

            Console.WriteLine("");
            Console.WriteLine("<------->");
            Console.WriteLine("");

            /*------------------*/
            // 5. 형식이 같은 변수 여러 개를 한 번에 선언하기
            Console.WriteLine("5. 형식이 같은 변수 여러 개를 한 번에 선언하기");
            int x = 10, y = 20, z = 30;                 // 정수형 변수 x, y, z를 선언하고 각각 초기화

            // 출력부
            Console.WriteLine(x);                      // 출력: 10
            Console.WriteLine(y);                     // 출력: 20
            Console.WriteLine(z);                      // 출력: 30

            /*------------------*/

            Console.WriteLine("");
            Console.WriteLine("<------->");
            Console.WriteLine("");

            /*------------------*/

            //6. 상수 사용하기
            Console.WriteLine("6. 상수 사용하기");
            const double Pi = 3.141592;         // 상수 Pi 선언 및 초기화
            const int MaxScore = 100;            // 정수형 상수 선언

            //출력
            Console.WriteLine(" Pi = " + Pi);
            Console.WriteLine(" MaxScore = " + MaxScore);

            /*------------------*/

            Console.WriteLine("");
            Console.WriteLine("<------->");
            Console.WriteLine("");

            /*------------------*/
            /* 퀴즈 */

            int att = 16755, hp = 78103, stat1 = 36, stat2 = 1017, stat3 = 41, stat4 = 611, stat5 = 22, stat6 = 39;
            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력     : "+att);
            Console.WriteLine("최대 생명력     : "+hp);
            Console.WriteLine("");
            Console.WriteLine("전투 특성");
            Console.WriteLine("치명     : "+stat1);
            Console.WriteLine("특화     : "+stat2);
            Console.WriteLine("제압     : "+stat3);
            Console.WriteLine("신속     : "+stat4);
            Console.WriteLine("인내     : "+stat5);
            Console.WriteLine("숙련     : "+stat6);

        }
    }
}
