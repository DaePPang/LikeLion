using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study5
{
    class Program
    {
        static void Main(string[] args)
        {
           /* // 숫자 데이터 형식 : 정수와 실수를 다룰 때 사용하는 다양한 타입
            int integerNum = 10;                        // 정수 데이터
            float floatNum = 3.14f;                    // 단정밀도 실수    *  float은 f를 붙어야한다.
            double doubleNum = 3.14159;     // 배정밀도 실수

            //출력부
            Console.WriteLine(integerNum);      // 출력값 10
            Console.WriteLine(floatNum);           // 출력값 3.14
            Console.WriteLine(doubleNum);      // 출력값 3.14159

            Console.WriteLine("\n<---->\n");

            //정수 데이터 형식 : 소수점 없이 숫자를 저장하며, 음수와 양수를 모두 다룹니다.
            int intValue = -100;                            //4바이트 크기의 정수
            long longValue = 1234567890L;   //8바이트 크기의 정수

            Console.WriteLine(intValue);
            Console.WriteLine(longValue);

            Console.WriteLine("\n<---->\n");

            //부호 있는 정수 : 음수와 양수를 모두 표현 가능
            sbyte signedByte = -50;                         //1바이트 크기
            short signedShort = -32000;                //2바이트 크기
            int signedInt = -2000000000;              //4바이트 크기

            Console.WriteLine(signedByte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signedInt);

            Console.WriteLine("\n<---->\n");

            //부호 없는 정수 : 0 이상의 정수만 표현 가능
            byte unsignedByte = 255;                    //1바이트 크기
            ushort unsignedShort = 65000;          //2바이트 크기
            uint unsignedInt = 4000000000;  //4바이트 크기

            Console.WriteLine(unsignedByte);
            Console.WriteLine(unsignedShort);
            Console.WriteLine(unsignedInt);

            Console.WriteLine("\n<---->\n");

            //float : 단정밀도 (정밀도 낮음, 메모리 적게 사용).
            //double : 배정밀도(정밀도 높음, 일반적으로 사용). 이 두 가지 많이 이용

            //실수 데이터 형식 : 소수점을 포함한 숫자를 표현
            float singlePrecision = 3.14f;                                                                             // 단정밀도 실수 4바이트
            double doublePrecision = 3.1415926536;                                                    // 배정밀도 실수 8바이트
            decimal highPrecision = 3.1415926535897932384626433833m;    // 고정밀도 실수 16바이트

            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(highPrecision);

            Console.WriteLine("\n<---->\n");*/

/*
            //접미사 사용 : 숫자의 데이터 형식을 명시
            int integerValue = 100;                     //기본 정수형 int
            long longValue = 100L;                     //정수형 long
            float floatValue = 3.14f;                   //실수형 float
            double doubleValue = 3.14;           //기본 실수형 double
            decimal decimalValue = 3.14m;    //고정밀도 실수형 decimal

            Console.WriteLine(integerValue); // 출력: 100
            Console.WriteLine(longValue); // 출력: 100
            Console.WriteLine(floatValue); // 출력: 3.14
            Console.WriteLine(doubleValue); // 출력: 3.14
            Console.WriteLine(decimalValue); // 출력: 3.14

            Console.WriteLine("\n<---->\n"); 

            //char 형식 : 단일 문자를 표현
            char letter = 'A';      // 문자 'A' 저장
            char symbol = '#';  // 특수 기호 저장
            char number = '9'; // 숫자 형태의 문자 저장 (문자 '9' , 숫자 9 아님)

            Console.WriteLine(letter);
            Console.WriteLine(symbol);
            Console.WriteLine(number);

            Console.WriteLine("\n<---->\n");

            // string 형식 : 여러 문자를 저장
            string greeting = "Hello, World";   //문자열 저장
            string name = "Alice";                        //이름 저장

            Console.WriteLine(greeting);
            Console.WriteLine(name);

            Console.WriteLine("\n<---->\n");

            //간단한 문제

            Console.WriteLine(greeting + " " + name);

            Console.WriteLine("\n<---->\n");

            //bool 형식 : 참 true 또는 거짓 false
            bool isRunning = true;
            bool isFinished = false;

            Console.WriteLine(isRunning);       //출력 : True
            Console.WriteLine(isFinished);      // 출력 : False

            Console.WriteLine("\n<---->\n");

            //const : 변하지 않는 값을 정의
            const double Pi = 3.14159;  //원주율
            const int MaxScore = 100;   //최대 점수

            Console.WriteLine(Pi);                  //출력 : 3.14159
            Console.WriteLine(MaxScore); //출력 : 100


            Console.WriteLine("\n<---->\n");
            //닷넷 형식 : 기본 형식의 닷넷 표현
*/
            //System.Int32 number = 123;      // int의 닷넷 형식
            //System.String text = "Hello";     // string의 닷넷 형식
            //System.Boolean flag = true;      // bool의 닷넷 형식

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);


            //래퍼 형식
            // int 래퍼 형식의 메서드 활용
/*            int number = 123;
            string numberAsString = number.ToString();

            // bool 래퍼 형식의 메서드 활용
            bool flag = true;
            string flagAsString = flag.ToString();

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);*/

        }
    }
}
