using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningChallenge
{
    public static class GameController
    {
        public static OptionsEnum ComputerChoice()
        {
            Random num = new Random();
            return (OptionsEnum)num.Next(1, 4);
        }

        public static ResultEnum Result(OptionsEnum userChoice, OptionsEnum computerChoice)
        {
            switch (computerChoice)
            {
                case OptionsEnum.Rock:
                    switch (userChoice)
                    { 
                        case OptionsEnum.Rock:
                            return ResultEnum.Draw;
                        case OptionsEnum.Paper:
                            return ResultEnum.Win;
                        default:
                            return ResultEnum.Lose;

                    }
                case OptionsEnum.Paper:
                    switch (userChoice)
                    {
                        case OptionsEnum.Rock:
                            return ResultEnum.Lose;
                        case OptionsEnum.Paper:
                            return ResultEnum.Draw;
                        default:
                            return ResultEnum.Win;

                    }
                default:
                    switch (userChoice)
                    {
                        case OptionsEnum.Rock:
                            return ResultEnum.Win;
                        case OptionsEnum.Paper:
                            return ResultEnum.Lose;
                        default:
                            return ResultEnum.Draw;

                    }

            }
        }
    }
}
