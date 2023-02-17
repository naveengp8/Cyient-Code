namespace IntToRoman_Sol1
{
    public class TensRomanExpression : IExpression
    {
        public void Interpret(Context context)
        {
            while ((context.Input - 90) >= 0)
            {
                context.Output += "XC";

                context.Input -= 90;
            }

            while ((context.Input - 50) >= 0)
            {
                context.Output += "L";

                context.Input -= 50;
            }

            while ((context.Input - 40) >= 0)
            {
                context.Output += "XL";

                context.Input -= 40;
            }

            while ((context.Input - 30) >= 0)
            {
                context.Output += "XXX";

                context.Input -= 30;
            }

            while ((context.Input - 20) >= 0)
            {
                context.Output += "XX";

                context.Input -= 20;
            }

            while ((context.Input - 10) >= 0)
            {
                context.Output += "X";

                context.Input -= 10;
            }
        }
    }
}
