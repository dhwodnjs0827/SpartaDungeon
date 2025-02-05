using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public static class SelectHelper
    {
        public static int GetSelectedNum(int maxNum)
        {
            bool isWrongInput = false;
            int selectNum;
            do
            {
                selectNum = int.Parse(Console.ReadLine());

                if (selectNum >= 0 && selectNum <= maxNum)
                {
                    isWrongInput = false;
                }
                else
                {
                    Console.Write("잘못된 입력입니다.\r\n\r\n원하시는 행동을 입력해주세요.\r\n>> ");
                    isWrongInput = true;
                }
            } while (isWrongInput);

            return selectNum;
        }
    }
}
