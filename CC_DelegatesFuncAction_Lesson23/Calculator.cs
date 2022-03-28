using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CC_DelegatesFuncAction_Lesson23
{
    public class Calculator
    {
        public MethodReturnIntAcceptTwoInts calcOpeartion;
        public PrintMessageDelegate onGetResult;
        public static string calcType;


        public Calculator()
        {
            //CalcOpeartion += AddTwoNumbers;
            //CalcOpeartion += SubTwoNumbers;
            //CalcOpeartion += DivTwoNumbers;
            //CalcOpeartion += MulptTwoNumbers;
            CalcTwoNumbers(SubTwoNumbers);
        }

        public MethodReturnIntAcceptTwoInts GetCalcMethod(string oper)
        {
            switch (oper)
            {
                case "+":
                    return AddTwoNumbers;
                case "-":
                    return SubTwoNumbers;
                case "/":
                    return DivTwoNumbers;
                case "*":
                    return MulptTwoNumbers;
                default:
                    return null;
            }
        }

        public int CalcTwoNumbers(MethodReturnIntAcceptTwoInts calcOper)
        {
            return calcOper.Invoke(100,13);
        }

        public int Stam(int n1, int n2)
        {
            return -1;
        }

        private int AddTwoNumbers(int n1, int n2)
        {
            int result = n1 + n2;

            if(onGetResult != null)
                onGetResult?.Invoke($"{n1} + {n2} = {result}.");

            return result;
        }


        private int SubTwoNumbers(int n1, int n2)
        {
            int result = n1 - n2;

            if (onGetResult != null)
                onGetResult?.Invoke($"{n1} - {n2} = {result}.");

            return result;
        }

        private int DivTwoNumbers(int n1, int n2)
        {
            int result = n1 / n2;

            if (onGetResult != null)
                onGetResult?.Invoke($"{n1} / {n2} = {result}.");

            return result;
        }

        private int MulptTwoNumbers(int n1, int n2)
        {
            int result = n1 * n2;

            if (onGetResult != null)
                onGetResult?.Invoke($"{n1} * {n2} = {result}.");

            return result;
        }
    }
}
