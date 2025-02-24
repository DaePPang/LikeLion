using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_04
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 13 Page
             * 이진수
             * 0 과 1로 이루어짐
             * 2진수 (Binary)
             * 프로그래머 계산기 이용하여 사용하기도 함. Window 계산기 - 프로그래머
             * 많이 안나온다
             */

            /*
            
                        Console.Write("2진수를 입력하세요 : ");
                        //이진수를 정수로 변환
                        string binaryInput = Console.ReadLine();        //입력을 받는다. 문자열
                        int decimalValue = Convert.ToInt32(binaryInput, 2);     // 2진수 -> 10진수 변환

                        //정수를 이진수로 변환
                        string binaryOutput = Convert.ToString(decimalValue, 2);    //10진수 -> 2진수로 변환
            
            /*

                        /*
                         *  출력할때(Console.WriteLine), 세가지 방법
                         */

            /*
                            Console.WriteLine($"입력한 이진수 : {binaryInput}");
                            // Console.WriteLine("입력한 이진수 :" + binaryInput);
                            //Console.WriteLine("입력한 이진수 : {0}", binaryInput);

                            Console.WriteLine($"10진수로 변환 : {decimalValue}");
                            // Console.WriteLine("10진수로 변환  :" + dcimalValue);
                            //Console.WriteLine("10진수로 변환 : {0}", decimalValue);

                            Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");
                            // Console.WriteLine("다시 이진수로 변환 :" + binaryOutput);
                            //Console.WriteLine("다시 이진수로 변환 : {0}", binaryOutput);
            */


            /*
             * 13 Page
             * Var를 사용하여 변수 선언
             */
            /*
                            var name = "Alice";     //문자열로 추론
                            var age = 25;                   // 정수로 추론
                            var isStudent = true;   //논리값으로 추론
                            Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");
                            Console.WriteLine("이름 : " + name + ", 나이 : " + age + ", 학생 여부 : " + isStudent);
                            Console.WriteLine("이름 : {0}, 나이 : {1}, 학생 여부 : {2}", name, age, isStudent);
            */

            /*
             * 14 Page
             * 5. 변수의 기본값을 default 키워드로 설정하기
             * Default를 사용하지만, 주로 0를 이용함
             * Default 키워드를 사용한 기본값 설정
             */

            /*
                            int defaultInt = default;                       // 기본값 : 0 -> int여서 0으로 세팅됨
                            string defaultString = default;         // 기본값 : null -> string이여서 Null로 세팅됨
                            bool defaultBool = default;                 // 기본값 : false -> bool이여서 false로 세팅됨

                            Console.WriteLine($"정수 기본값 : {defaultInt}");        //출력 : 0
                            //Console.WriteLine("정수 기본값 : "+defaultInt);
                            //Console.WriteLine("정수 기본값 : {0}",defaultInt);

                            Console.WriteLine($"문자열 기본값 : {defaultString}");    //출력 :Null -> null 값이여서 빈값
                            //Console.WriteLine("정수 기본값 : " + defaultString);
                            //Console.WriteLine("정수 기본값 : {0}", defaultString);

                            Console.WriteLine($"논리값 기본값 : {defaultBool}");      //출력 : false
                            //Console.WriteLine("정수 기본값 : " + defaultBool);
                            //Console.WriteLine("정수 기본값 : {0}", defaultBool);
            */

            /*
             * 15 Page
             * 연산자 (응용되는 단계)
             * 연산자는 값을 계싼하거나 조작할 때 사용됩니다.
             * 단항, 산술, 관계형, 논리, 비트 연산자 등 다양한 종류가 있습니다.
             */
            /*
                        int a = 5, b = 3;
                        int c = 5, d = 2;
                        int sum, min, mul, div, rest = 0;
                        sum = a + b;                     //산술 연산자 사용 +
                        min = a - b;                       //산술 연산자 사용 - 
                        mul = a * b;                       //산술 연산자 사용 *
                        div = a / b;                         //산술 연산자 사용 /

                        Console.WriteLine($"합 : {sum}");
                        //Console.WriteLine("합 : " + sum);
                        //Console.WriteLine("합 : {0}",sum);

                        Console.WriteLine($"빼기 : {min}");
                        //Console.WriteLine("빼기 : " + min);
                        //Console.WriteLine("빼기: {0}", min);

                        Console.WriteLine($"곱 : {mul}");
                        //Console.WriteLine("곱 : " + mul);
                        //Console.WriteLine("곱 : {0}", mul);

                        Console.WriteLine($"나누기 : {div}");
                        //Console.WriteLine("나누기 : " + div);
                        //Console.WriteLine("나누기 : {0}", div);


                        rest = c % d;                     //나머지를 구하는 것. -> 5 / 2  = 2... 1 그래서 출력값은 1
                                                                        // 짝수, 홀수 구할때 많이 사용함.

                        Console.WriteLine($"나머지 : {rest}");
                        //Console.WriteLine("나머지 : " + rest);
                        //Console.WriteLine("나머지 : {0}", rest);

                        // 짝수, 홀수 구하기

                        int Num0 = 0;
                        int Num1 = 9;
                        Num0 = Num1 % 2; // 2로 나눴을 때, 값이 0이 나오면 짝수, 1이 나오면 홀수

                        Console.WriteLine($"짝수, 홀수 판별 : {Num0}");
                        //Console.WriteLine("짝수, 홀수 판별 : " + Num0);
                        //Console.WriteLine("짝수, 홀수 판별 : {0}", Num0);

                        // 관계형 연산자
                        bool isEqual = false;
                        bool isNotEqual = false;
                        int e = 5, f = 5, g = 6;
                        isEqual = (e == f);    // e와 f가 같은가?
                        isNotEqual = (e == g);    // e와 f가 같은가?

                        Console.WriteLine($"관계형 연산자 : {isEqual}");
                        //Console.WriteLine("관계형 연산자 : " + isEqual);
                        //Console.WriteLine("관계형 연산자 : {0}", isEqual);

                        Console.WriteLine($"관계형 연산자 : {isNotEqual}");
                        //Console.WriteLine("관계형 연산자 : " + isNotEqual);
                        //Console.WriteLine("관계형 연산자 : {0}", isNotEqual);
            */


        }
    }
}
