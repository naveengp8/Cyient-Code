namespace IntToRoman_Sol1
{
    public class OnesRomanExpression : IExpression
    {
        public void Interpret(Context context)
        {
            while ((context.Input - 9) >= 0)
            {
                context.Output += "IX";

                context.Input -= 9;
            }

            while ((context.Input - 5) >= 0)
            {
                context.Output += "V";

                context.Input -= 5;
            }

            while ((context.Input - 4) >= 0)
            {
                context.Output += "IV";

                context.Input -= 4;
            }

            while ((context.Input - 3) >= 0)
            {
                context.Output += "III";

                context.Input -= 3;
            }

            while ((context.Input - 2) >= 0)
            {
                context.Output += "II";

                context.Input -= 2;
            }

            while ((context.Input - 1) >= 0)
            {
                context.Output += "I";

                context.Input -= 1;
            }

        }

    }
}
