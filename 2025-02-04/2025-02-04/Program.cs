using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

            /*
             * 15 Page
             * 단항 연산자   : 피연산자 하나에 적용됩니다. EX) + - ! ~ 등
             * 항이 하나일때 사용하는 연산자 이다. EX) +5, -4 등
             * 5를 무조건 +5로 출력하고 싶다면, Fomat 검색하기
             * +는 굳이 안사용하고, -는 사용함
             */

            /*
            int number = 5;
            bool flag = true;

            Console.WriteLine(+number);                     //양수 출력
            //Console.WriteLine($"{+number}");
            //Console.WriteLine("{0}", +number);
            
            Console.WriteLine(-number);                     //음수 출력
            //Console.WriteLine($"{-number}");
            //Console.WriteLine("{0}", -number);

            Console.WriteLine(flag);                                //논리
            //Console.WriteLine($"{flag}");
            //Console.WriteLine("{0}", flag);

            Console.WriteLine(!flag);                               //논리 부정
            //Console.WriteLine($"{!flag}");
            //Console.WriteLine("{0}", !flag);
            */

            /*
             *  ~ 비트 반전
             *  // 10 -> 1010 
             *  // 5 -> 0101        1 바이트 0000 0000/ 
             */

            /*
            int num = 10;  // ->   0000 0000     0000 0000  0000 0000    0000 1010
            int result = ~num;  // ->  1111 1111     1111 1111   1111 1111   1111 0101

            Console.WriteLine(num);                     //양수 출력
            //Console.WriteLine($"{num}");
            //Console.WriteLine("{0}", num);

            Console.WriteLine(result);                     //비트 반전
            //Console.WriteLine($"{result}");
            //Console.WriteLine("{0}",result);
            */

            /*
             * 16 Page
             * 변환 연산자 : ()를 사용해 데이터 형식을 명시적으로 변환합니다.
             * 캐스팅 이라고 함
             *  #실수에서 정수로 변환 시 소수점이 사라진다. #
             */

            /*
            double pi = 3.14;
            int integerPi = (int)pi;            //실수형을 정수형으로 변환

            Console.WriteLine(pi);
            //Console.WriteLine($"{pi}");
            //Console.WriteLine("{0}",pi);

            Console.WriteLine(integerPi);       //출력값 : 3
            //Console.WriteLine($"{integerPi}");
            //Console.WriteLine("{0}", integerPi);

            int kor = 90;
            int eng = 75;
            int math = 58;

            int sum = 0;  float avr = 0; float avrFloat1 = 0; float avrFloat2 = 0;

            sum = kor + eng + math;
            avr = sum / 3;
            // 나눴을 때, 소수점 표시하고 싶으면, 아래 두가지 처럼 하면 된다.
            // 1. sum값을 Float형으로 변환해서 나누기
            //2. sum값을 3(실수형)으로 나누기
            avrFloat1 = (float)sum / 3;
            avrFloat2 = sum / 3f;


            Console.WriteLine("합계 : " + sum);
            //Console.WriteLine($"합계 : {sum}");
            //Console.WriteLine("합계 : {0}",sum);

            Console.WriteLine("평균 : " + avr);
            //Console.WriteLine($"평균 : {avr}");
            //Console.WriteLine("평균 : {0}",avr);

            Console.WriteLine("평균 : " + avrFloat1);
            //Console.WriteLine($"평균 : {avrFloat1}");
            //Console.WriteLine("평균 : {0}", avrFloat1);

            Console.WriteLine("평균 : " + avrFloat2);
            //Console.WriteLine($"평균 : {avrFloat2}");
            //Console.WriteLine("평균 : {0}", avrFloat2);
            */


            /*
             * 16 Page
             * 산술 연산자 : +, -, *, /, %로 덧셈, 뺄셈, 곱셈, 나눗셈, 나머지 연산을 수행합니다.
             */

            /*
            int a = 10, b = 3;
            Console.WriteLine(a + b);   //덧셈
            Console.WriteLine(a - b);   //뺄셈
            Console.WriteLine(a * b);   //곱셈
            Console.WriteLine(a / b);   //나눗셈
            Console.WriteLine(a % b);   //나머지
            */


            /*
             * 17 Page
             * 문자열 연결 연산자
             * +를 사용해 문자열을 연결할 수 있습니다.
             */

            /*
            string firstName = "Alice", lastName = "Smith";
            Console.WriteLine(firstName + " " + lastName);
            */

            /*
             * 17 Page
             * 할당 연산자
             * 값을 변수에 저장한다. =, +=, -=, *=, /=, %= 등이 포함됩니다.
             */

            /*
            int a, b, c, d, e;
            a = b = c = d = e = 10;

            a += 5;     // a = a+5
            Console.WriteLine(a);

            b -= 5;     // b = b-5
            Console.WriteLine(b);

            c *= 5;     // c = c * 5
            Console.WriteLine(c);

            d /= 5;     // d = d / 5
            Console.WriteLine(d);

            e %= 5;     // e = e % 5
            Console.WriteLine(e);
            */

            /*
             *  문제 1. 학점 평균 계산 프로그램
             *  국어, 영어, 수학 점수를 사용자로부터 입력받아 총점과 평균을 구하는 프로그램을 작성하세요.
             */

            /*
            int kor, eng, math, sum;
            kor = eng = math = sum =0;
            float avg;
            string resultAvg;

            Console.Write("국어 점수를 입력하세요 : ");
            kor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요 : ");
            eng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요 : ");
            math = int.Parse(Console.ReadLine());

            sum = kor + eng + math;
            avg = sum / 3f;
            resultAvg = avg.ToString("0.00");

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + resultAvg);
            */


            /*
             * 문제 2. 비트 반전(~) 연산자 활용 프로그램
             */

            /*
            int num1, num2 = 0;
            Console.Write("정수를 입력하세요 : ");
            num1 = int.Parse(Console.ReadLine());

            num2 = ~num1;

            Console.WriteLine("입력받은 정수 값 : " + num1);
            Console.WriteLine("반전 후 정수 값 : " + num2);
            */

            /*
             * 17 Page
             * 증감 연산자
             * ++와 --를 사용해 값을 1씩 증가하거나 감소시킨다.
             * Console.WriteLine(++i) vs Console.WriteLine(i++) 차이점
             *
             *   ++i 설명.
             *  i += 1;
             *   Console.WriteLine(i);
             *
             *   i++설명.
             *  Console.WriteLine(i)
             * i += 1;
             */

            /*
             int b = 3;
             //전위 ++b , 후위 b++

             //b++은 해당 칸에선 계산이 안되고, 그 다음 b가 나오면 그때 ++가 된다. --도 마찬가지.

             Console.WriteLine(b--);
             Console.WriteLine(++b);
            */

            /*
             * 18 Page
             * 관계형 연산자
             * 두 값을 비교하여 관계를 평가합니다. (==, !=, <, >, <=, >=)
             */

            /*
            int x = 5, y = 10;
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);
            */

            /*
             * 18 Page
             * 논리 연산자
             * 논리값을 결합하거나 반전합니다. (|| , && , !)
             */

            /*
            bool a = true, b = false;
            // 1 = true, 0 = false;
            Console.WriteLine(a && b);
            // AND  :   1   :   0   t
            //                  1   :   0   f
            //                  0   :   1   f
            //                  0   :   0   f
            Console.WriteLine(a || b);
            //OR        :    1   :   1   t
            //                     1   :   0   t
            //                     0   :   1    t
            //                     0    :   0   f
            Console.WriteLine(!a);
            //NOT       
            //!ture -> false
            //!false -> true
            */

            /*
             * 19 Page
             * 비트 연산자와 시프트 연산자로 비트 단위 연산하기
             * 비트 단위로 AND , OR, XOR, NOT를 수행합니다.
             */

            /*
            //비트 연산자
            int x = 5; // 0101
            int y = 3; // 0011

            Console.WriteLine(x % y);   //AND : 0001   둘이 비교 했을때, 둘 다 1이면 1, 나머진 0
            Console.WriteLine(x | y);   //OR : 0111         둘이 비교 했을때, 둘 중에 하나라도 1이면 1
            Console.WriteLine(x ^ y);   //XOR : 0110    둘이 비교 했을때, 같은게 있으면 0 , 서로 다르면 1
            Console.WriteLine(~x);   //NOT : -6             Not 반대.

            //시프트 연산자
            int value = 4; //0100
            Console.WriteLine(value << 1);          //비트 왼쪽으로 이동 1000           8
            Console.WriteLine(value >> 1);          //비트 오른쪽으로 이동 0010      2
            */

            /*
             * 19 Page
             * 기타 연산자
             * ? : 조건문을 간단히 표현
             * is : 객체가 특정 형식인지 확인.
             * ?? : null 병합 연산자.
             */

            /*
            int a = 10, b = 20;
            int max = (a > b) ? a : b;              // 꿀팁. (a > b) ? a : b;
                                                                          // a가 b보다 크니? 크면 a 값을 넣고, 크지않으면 b 값을 넣어.
            Console.WriteLine(max);
            */


            /*
             * 문제
             */


            /*
            int key = 1;
            //string str = (key == 1) ? "문이열렸습니다." : "문이 닫혔습니다.";
            //Console.WriteLine(str);
           
            if(key == 1)
            {
                Console.WriteLine("문이 열렸습니다.");
            }
            else
            {
                Console.WriteLine("문이 닫혔습니다.");
            }
            */

            /*
             * 20 Page
             * 연산자 우선순위
             * 연산자는 우선순위에 따라 계산됩니다.
             * 괄호를 사용하여 우선순위를 명시적으로 지정할 수 있습니다.
             */

            /*
            int result = 10 + 2 * 5;            // 곱셈이 덧셈보다 우선
            Console.WriteLine(result);  //출력값 20

            int adjustedResult = (10 + 2) * 5;          //괄호가 우선순위 이므로, 괄호 먼저 처리
            Console.WriteLine(adjustedResult);  //출력값 60
            */

            /*
             * 21 Page
             * 제어문
             *  if문과 가지치기
             */
            /*
            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else
            {
                Console.WriteLine("B 학점");
            }
            */

            /*
             * 강사님이 하신거
             */
            /*
            string gameID = "멋사검존";

            if (gameID == "멋사검존")       //if (String.Compare(gameID,"멋사검존")==0 ) String.Compare 메소드를 이용한 것. ==와 동일
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
           else
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }
            */

            /*
                int score = 60;

                if(score >=90)
                {
                    Console.WriteLine("A 학점");
                }
                else if(score >= 80)
                {
                    Console.WriteLine("B 학점");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("C 학점");
                }
                else
                {
                    Console.WriteLine("F 학점");
                } 
            */

            /*
             * 
             * 궁금해서 내가 해본거
             * 
             */
            /*
                        int score = 0;
                        Console.WriteLine("점수를 입력하세요");

                        score = int.Parse(Console.ReadLine());
                        if (score <= 100 && score >= 0)
                            {
                                if (score >= 90)
                                {
                                    Console.WriteLine("A 학점");
                                }
                                else if (score >= 80)
                                {
                                    Console.WriteLine("B 학점");
                                }
                                else if (score >= 70)
                                {
                                    Console.WriteLine("C 학점");
                                }
                                else
                                {
                                    Console.WriteLine("D 학점");
                                }
                            }
                            else
                            {
                                Console.WriteLine("0점에서 100점 사이의 값을 입력해주세요.");
                            }
                        */

            /*
             * 
             *  IF문 문제
             * 
             */
            /*
            int money = 0;
            string chrName = "멋사검존";
            string swardName = "";
            string swardAtt = "";
            string att = "100";

            Console.WriteLine("가지고 있는 소지금을 입력하세요. : ");
            money = int.Parse(Console.ReadLine());

            if(money >= 0 && money <= 100)
            {
                Console.WriteLine("무한의 대검 구매완료!\n");
                swardName = "무한의 대검";
                swardAtt = "+1";
            }
            else if(money > 100 && money <= 200)
            {
                Console.WriteLine("카타나 구매 구매완료!\n");
                swardName = "카타나";
                swardAtt = "+2";
            }
            else if (money > 200 && money <= 300)
            {
                Console.WriteLine("진은검 구매 구매완료!\n");
                swardName = "진은검";
                swardAtt = "+3";
            }
            else if (money > 300 && money <= 400)
            {
                Console.WriteLine("집판검 구매 구매완료!\n");
                swardName = "집판검";
                swardAtt = "+4";
            }
            else if (money > 400 && money <= 500)
            {
                Console.WriteLine("엑스칼리버 구매완료!\n");
                swardName = "엑스칼리버";
                swardAtt = "+5";
            }
            else if (money > 500 && money <= 600)
            {
                Console.WriteLine("유령검 구매완료!\n");
                swardName = "유령검";
                swardAtt = "+6";
            }
            else if (money > 600)
            {
                Console.WriteLine("전설의 검 구매완료!\n");
                swardName = "전설의 검";
                swardAtt = "+7";
            }

            Console.WriteLine(" 캐릭터 : " + chrName);
            Console.WriteLine(" 무기 : {0}", swardName);
            Console.WriteLine($" 공격력 : {att} {swardAtt}");
            */

            /*
             * 16시 문제
             */

            // 문제 1. 세 정수의 최대 값 구하기
            /*
            int num1, num2, num3 = 0;

            Console.WriteLine("문제 1. 세 정수의 최대 값 구하기");
            Console.WriteLine("서로 다른 정수 하나를 입력해주세요. (첫번 째 정수)");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("서로 다른 정수 하나를 입력해주세요. (두번 째 정수) # 입력 했던 정수 : {0}",num1);
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("서로 다른 정수 하나를 입력해주세요. (세번 째 정수) # 입력 했던 정수 : {0},{1}",num1,num2);
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================");
            Console.WriteLine("입력한 정수들 : {0},{1},{2}", num1, num2, num3);

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("최대값 : " + num1);
            }
            else if(num1 > num2 && num1 < num3)
            {
                Console.WriteLine("최대값 : " + num3);
            }
            else if (num1 < num2 && num1 < num3)
            {
                if(num2 < num3)
                {
                    Console.WriteLine("최대값 : " + num3);
                    }
                else
                {
                    Console.WriteLine("최대값 : " + num2);
                    }
            }
            else if(num1 < num2 && num1 > num3)
            {
                Console.WriteLine("최대값 : " + num2);
            }

            //문제 2. 점수에 따른 학점 평가

            Console.WriteLine("=================\n문제 2. 점수에 따른 학점 평가");
            int score = 0;
            Console.WriteLine("점수를 입력하세요. : ");
            score = int.Parse(Console.ReadLine());
            
            if(score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if(score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if(score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else if(score >= 60)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }

            //문제 3. 간단한 사칙연산
            int number1, number2 = 0;
            string sign = "";
            int add, minus, multiply, div = 0;
            Console.WriteLine("=================\n문제 3. 간단한 사칙연산");
            Console.WriteLine("숫자 하나를 입력해주세요. (첫번 째 숫자) ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자 하나를 입력해주세요. (두번 째  숫자) # 입력 했던 정수 : {0}", number1);
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자 기호를 입력 해주세요 EX) +, -, *,/", number1);
            sign = Console.ReadLine();

            if(sign == "+")
            {
                add = number1 + number2;
                Console.WriteLine("결과 : "+add);
            }
            else if(sign == "-")
            {
                minus = number1 - number2;
                Console.WriteLine("결과 : " + minus);
            }
            else if(sign == "*")
            {
                multiply = number1 * number2;
                Console.WriteLine("결과 : " + multiply);
            }
            else if(sign == "/") 
            {
                if (number1 == 0 || number2 == 0)
                {
                    Console.WriteLine("0이 들어갈 경우, 나눗셈은 안됩니다.");
                }
                else { 
                    div = number1 / number2;
                    Console.WriteLine("결과 : " + div);
                }
            }
            */




        }
    }
}

