// using ~ 이 안에 있는 기능들 좀 쓰겠다  using System
// namespace using으로 선언 한거 안에 묶어서 정리해둔 기능들 좀 쓰겠다 Console.Wirte(); 폴더 같은 개념

namespace Day1
{///
    internal class Program
    {
        /// <summary>
        /// 공격
        /// </summary>
        /// <param name="dmage">데미지</param>
        static public void attack(int dmage) { }

        //2024-07-09
        static void Main(string[] args)
        {
           //  attack(5); ///주석 활용

            Console.WriteLine("내 이름은 {0}, 나이는 {1}살 {2}다", "김선우", 30, "남자");
            Console.Write("나는 다음 내용을 배울 \"준비\" 되었다!");

            /*     
                 컨트롤 k c 주석 달기
                 컨트롤 k u 주석 풀기
                 컨트롤 k f 들여쓰기

                 컨트롤 k 코드 정리
                 alt 드래그 가능
            */
          
        }
    }
}

// 도구 > 옵션 > 글꼴 및 색 > 글꼴 콘솔라스
// 도구 > 옵션 > 텍스트 편집기 > 일반 > 중괄호 쌍 색 지정