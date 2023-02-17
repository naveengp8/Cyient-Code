﻿namespace IntToRoman_Sol1
{
    public class HundredsRomanExpression : IExpression
    {
        public void Interpret(Context context)
        {
            while ((context.Input - 900) >= 0)
            {
                context.Output += "CM";

                context.Input -= 900;
            }

            while ((context.Input - 500) >= 0)
            {
                context.Output += "D";

                context.Input -= 500;
            }

            while ((context.Input - 400) >= 0)
            {
                context.Output += "CD";

                context.Input -= 400;
            }

            while ((context.Input - 300) >= 0)
            {
                context.Output += "CCC";

                context.Input -= 300;
            }

            while ((context.Input - 200) >= 0)
            {
                context.Output += "CC";

                context.Input -= 200;
            }

            while ((context.Input - 100) >= 0)
            {
                context.Output += "C";

                context.Input -= 100;
            }
        }
    }

}
