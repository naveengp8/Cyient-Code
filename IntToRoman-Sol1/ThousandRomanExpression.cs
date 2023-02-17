namespace IntToRoman_Sol1
{
    public class ThousandRomanExpression : IExpression
    {
        public void Interpret(Context context)
        {
            while ((context.Input - 3000) >= 0)
            {
                context.Output += "MMM";

                context.Input -= 3000;
            }

            while ((context.Input - 2000) >= 0)
            {
                context.Output += "MM";

                context.Input -= 2000;
            }

            while ((context.Input - 1000) >= 0)
            {
                context.Output += "M";

                context.Input -= 1000;
            }
        }
    }
}
