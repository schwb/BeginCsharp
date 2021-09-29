using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquariumproject
{
    class Aquarium
    {
        private int _broad = 30;

        private int _height = 10;

        public int height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public int broad
        {
            get
            {
                return _broad;
            }
            set
            {
                _broad = value;
            }
        }
        public int appearheight { get; set; }
        public int appearbroad { get; set; }
        public int appearanceleftright { get; set; }
        public string[,] aquarium;
        public void filltheaquarium()
        {
            aquarium = new string[height, broad];

            for (int Index1 = 0; Index1 < height; Index1++)
            {
                for (int Index2 = 0; Index2 < broad; Index2++)
                {
                    if (Index2 == 0 || Index2 == broad - 1)
                    {
                        if (Index1 == height - 1)
                        {
                            aquarium[Index1, Index2] = "+";
                        }
                        else
                        {
                            aquarium[Index1, Index2] = "|";
                        }
                    }
                    else if (Index1 == height - 1)
                    {
                        aquarium[Index1, Index2] = "_";
                    }
                    else
                    {
                        aquarium[Index1, Index2] = " ";
                    }
                }
            }
        }
        int Arrayposition = 0;
        universal_fish[] allfishes;
        public void fillinfishes()
        {
            allfishes = new universal_fish[height];
            Random r = new Random();
            int wichfish;
            for (int Index = 0; Index < height; Index++)
            {
                wichfish = r.Next(0, 3);
                if (wichfish == 0)
                {
                    swordfish swordfish1 = new swordfish();
                    fillinfish(swordfish1);
                }
                else if (wichfish == 1)
                {
                    blowfish blowfish1 = new blowfish();
                    fillinfish(blowfish1);
                }
                else if (wichfish == 2)
                {
                    shark shark1 = new shark();
                    fillinfish(shark1);
                }
                else
                {
                    carp carp1 = new carp();
                    fillinfish(carp1);
                }
            }
        }
        public void fillinfish(universal_fish fish)
        {
            fish.maxheight = height;
            Random r = new Random();
            appearanceleftright = r.Next(0, 100);
            appearheight = r.Next(1, height - 2);
            appearbroad = r.Next(1, broad - 1 - fish.appearancefishleft.Length);
            if (appearanceleftright % 2 == 0)
            {
                foreach (char sign in fish.appearancefishleft)
                {
                    aquarium[appearheight, appearbroad] = Convert.ToString(sign);
                    appearbroad += 1;
                }
                allfishes[Arrayposition] = fish;
                Arrayposition += 1;
                fish.appearbroad = appearbroad - fish.appearancefishleft.Length - 1;
                fish.appearheight = appearheight;
                fish.leftright = "left";

            }
            else
            {
                foreach (char sign in fish.appearancefishright)
                {
                    aquarium[appearheight, appearbroad] = Convert.ToString(sign);
                    appearbroad += 1;
                }
                allfishes[Arrayposition] = fish;
                Arrayposition += 1;
                fish.appearbroad = appearbroad - fish.appearancefishleft.Length + 1;
                fish.appearheight = appearheight;
                fish.leftright = "right";
            }
        }
        public void movefishes()
        {
            for (int Index = 0; Index < allfishes.Length; Index++)
            {
                if (allfishes[Index].leftright == "left")
                {
                    for (int Index2 = 0; Index2 < allfishes.Length; Index2++)
                    {
                        if (allfishes[Index2].leftright == "right" && allfishes[Index2].appearancefishleft != "")
                        {
                            if (allfishes[Index].appearbroad == allfishes[Index2].appearbroad + allfishes[Index2].appearancefishleft.Length)
                            {
                                if (allfishes[Index].appearancefishleft.Length > allfishes[Index2].appearancefishleft.Length
                                    && allfishes[Index2].appearheight == allfishes[Index].appearheight)
                                {
                                    allfishes[Index2].appearancefishleft = "";
                                    allfishes[Index2].appearancefishright = "";
                                    string linkeworthälfte1 = Convert.ToString(allfishes[Index].appearancefishleft[0]);
                                    string rechteworthälfte1 = Convert.ToString(allfishes[Index].appearancefishleft);
                                    allfishes[Index].appearancefishleft = $"{linkeworthälfte1}{rechteworthälfte1}";
                                    string linkeworthälfte2 = Convert.ToString(allfishes[Index].appearancefishright);
                                    string rechteworthälfte2 =
                                        Convert.ToString(allfishes[Index].appearancefishright[allfishes[Index].appearancefishright.Length - 1]);
                                    allfishes[Index].appearancefishright = $"{linkeworthälfte2}{rechteworthälfte2}";
                                }
                            }
                        }
                    }
                }
                if (allfishes[Index].leftright == "right")
                {
                    for (int Index2 = 0; Index2 < allfishes.Length; Index2++)
                    {
                        if (allfishes[Index2].leftright == "left" && allfishes[Index2].appearancefishleft != "")
                        {
                            if (allfishes[Index2].appearbroad == allfishes[Index].appearbroad + allfishes[Index].appearancefishleft.Length)
                            {
                                if (allfishes[Index].appearancefishleft.Length > allfishes[Index2].appearancefishleft.Length
                                    && allfishes[Index2].appearheight == allfishes[Index].appearheight)
                                {
                                    allfishes[Index2].appearancefishleft = "";
                                    allfishes[Index2].appearancefishright = "";
                                    string linkeworthälfte1 = Convert.ToString(allfishes[Index].appearancefishleft[0]);
                                    string rechteworthälfte1 = Convert.ToString(allfishes[Index].appearancefishleft);
                                    allfishes[Index].appearancefishleft = $"{linkeworthälfte1}{rechteworthälfte1}";
                                    string linkeworthälfte2 = Convert.ToString(allfishes[Index].appearancefishright);
                                    string rechteworthälfte2 =
                                        Convert.ToString(allfishes[Index].appearancefishright[allfishes[Index].appearancefishright.Length - 1]);
                                    allfishes[Index].appearancefishright = $"{linkeworthälfte2}{rechteworthälfte2}";
                                }
                            }
                        }
                    }
                }
            }
            for (int Index = 0; Index < allfishes.Length; Index++)
            {
                allfishes[Index].schwimmtiefe();
                if (allfishes[Index].appearbroad == 0)
                {
                    allfishes[Index].appearbroad = 1;
                    allfishes[Index].leftright = "right";
                }
                else if (allfishes[Index].appearbroad > broad - allfishes[Index].appearancefishleft.Length - 2)
                {
                    allfishes[Index].appearbroad = broad - allfishes[Index].appearancefishleft.Length - 2;
                    allfishes[Index].leftright = "left";
                }
                else
                {
                    if (allfishes[Index].leftright == "left")
                    {
                        if (aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad] == " ")
                        {
                            foreach (char sign in allfishes[Index].appearancefishleft)
                            {
                                aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad] = Convert.ToString(sign);
                                allfishes[Index].appearbroad += 1;
                            }
                            allfishes[Index].appearbroad -= allfishes[Index].appearancefishleft.Length + 1;
                        }
                        else if (allfishes[Index].appearheight + 1! > height - 3 &&
                            aquarium[allfishes[Index].appearheight + 1, allfishes[Index].appearbroad] == " " &&
                            aquarium[allfishes[Index].appearheight + 1, allfishes[Index].appearbroad + 3] == " " &&
                            aquarium[allfishes[Index].appearheight + 1, allfishes[Index].appearbroad + 6] == " ")
                        {
                            allfishes[Index].appearheight += 1;
                            foreach (char sign in allfishes[Index].appearancefishleft)
                            {
                                aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad] = Convert.ToString(sign);
                                allfishes[Index].appearbroad += 1;
                            }
                            allfishes[Index].appearbroad -= allfishes[Index].appearancefishleft.Length + 1;
                        }
                        else if (allfishes[Index].appearheight! < 2 &&
                            aquarium[allfishes[Index].appearheight - 1, allfishes[Index].appearbroad] == " " &&
                           aquarium[allfishes[Index].appearheight - 1, allfishes[Index].appearbroad + 3] == " " &&
                           aquarium[allfishes[Index].appearheight - 1, allfishes[Index].appearbroad + 6] == " ")
                        {
                            allfishes[Index].appearheight -= 1;
                            foreach (char sign in allfishes[Index].appearancefishleft)
                            {
                                aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad] = Convert.ToString(sign);
                                allfishes[Index].appearbroad += 1;
                            }
                            allfishes[Index].appearbroad -= allfishes[Index].appearancefishleft.Length + 1;
                        }
                    }
                    else
                    {
                        if (aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad + (allfishes[Index].appearancefishleft.Length - 1)] == " ")
                        {
                            foreach (char sign in allfishes[Index].appearancefishright)
                            {
                                aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad] = Convert.ToString(sign);
                                allfishes[Index].appearbroad += 1;
                            }
                            allfishes[Index].appearbroad -= allfishes[Index].appearancefishleft.Length - 3;
                        }
                        else if (allfishes[Index].appearheight + 1! > height - 3 &&
                            aquarium[allfishes[Index].appearheight + 1, allfishes[Index].appearbroad] == " " &&
                            aquarium[allfishes[Index].appearheight + 1, allfishes[Index].appearbroad + 3] == " " &&
                            aquarium[allfishes[Index].appearheight + 1, allfishes[Index].appearbroad + 6] == " ")
                        {
                            allfishes[Index].appearheight += 1;
                            foreach (char sign in allfishes[Index].appearancefishright)
                            {
                                aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad] = Convert.ToString(sign);
                                allfishes[Index].appearbroad += 1;
                            }
                            allfishes[Index].appearbroad -= allfishes[Index].appearancefishleft.Length - 3;
                        }
                        else if (allfishes[Index].appearheight! < 2 &&
                            aquarium[allfishes[Index].appearheight - 1, allfishes[Index].appearbroad] == " " &&
                           aquarium[allfishes[Index].appearheight - 1, allfishes[Index].appearbroad + 3] == " " &&
                           aquarium[allfishes[Index].appearheight - 1, allfishes[Index].appearbroad + 6] == " ")
                        {
                            allfishes[Index].appearheight -= 1;
                            foreach (char sign in allfishes[Index].appearancefishright)
                            {
                                aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad] = Convert.ToString(sign);
                                allfishes[Index].appearbroad += 1;
                            }
                            allfishes[Index].appearbroad -= allfishes[Index].appearancefishleft.Length - 3;
                        }
                    }
                }
            }
        }
        public void fillindinosour(dinosour fish)
        {
            bool Bedingung = false;
            while (Bedingung == false)
            {
                Random r = new Random();
                appearheight = r.Next(1, height - 2);
                appearbroad = r.Next(1, broad - fish.appearancefishright1.Length - 2);
                if (aquarium[appearheight, appearbroad] == " " && aquarium[appearheight - 1, appearbroad] == " "
                    && aquarium[appearheight, appearbroad + 3] == " " && aquarium[appearheight - 1, appearbroad + 3] == " "
                    && aquarium[appearheight, appearbroad + 6] == " " && aquarium[appearheight - 1, appearbroad + 6] == " "
                    && aquarium[appearheight, appearbroad + 9] == " " && aquarium[appearheight - 1, appearbroad + 9] == " "
                    && aquarium[appearheight, appearbroad + 12] == " " && aquarium[appearheight - 1, appearbroad + 12] == " "
                    && aquarium[appearheight, appearbroad + 15] == " " && aquarium[appearheight - 1, appearbroad + 15] == " "
                    && aquarium[appearheight, appearbroad + 18] == " " && aquarium[appearheight - 1, appearbroad + 18] == " "
                    && aquarium[appearheight, appearbroad + 21] == " " && aquarium[appearheight - 1, appearbroad + 21] == " "
                    && aquarium[appearheight, appearbroad + 24] == " " && aquarium[appearheight - 1, appearbroad + 24] == " ")
                {
                    foreach (char sign in fish.appearancefishright1)
                    {
                        aquarium[appearheight, appearbroad] = Convert.ToString(sign);
                        appearbroad += 1;
                    }
                    appearbroad = 1;
                    foreach (char sign in fish.appearancefishright2)
                    {
                        aquarium[appearheight - 1, appearbroad] = Convert.ToString(sign);
                        appearbroad += 1;
                    }
                    fish.appearbroad = appearbroad - fish.appearancefishright2.Length + 1;
                    fish.appearheight = appearheight + 1;
                    fish.leftright = "right";
                    Bedingung = true;
                }
            }
        }
        public void movedinosour(dinosour fish)
        {


            if (fish.leftright == "left")
            {
                for (int Index2 = 0; Index2 < height; Index2++)
                {
                    if (allfishes[Index2].appearancefishleft != "")
                    {
                        if (fish.appearbroad == allfishes[Index2].appearbroad + allfishes[Index2].appearancefishleft.Length
                            || fish.appearbroad - 1 == allfishes[Index2].appearbroad + allfishes[Index2].appearancefishleft.Length
                            || fish.appearbroad - 2 == allfishes[Index2].appearbroad + allfishes[Index2].appearancefishleft.Length)
                        {
                            if (fish.appearheight == allfishes[Index2].appearheight || fish.appearheight - 1 == allfishes[Index2].appearheight)
                            {
                                allfishes[Index2].appearancefishleft = "";
                                allfishes[Index2].appearancefishright = "";
                                fish.appearancefishleft2 = fish.appearancelefteating;
                                fish.appearancefishleft1 = "          ";
                            }
                        }
                    }
                }
            }
            else if (fish.leftright == "right")
            {
                for (int Index2 = 0; Index2 < height; Index2++)
                {
                    if (allfishes[Index2].appearancefishleft != "")
                    {
                        if (allfishes[Index2].appearbroad == fish.appearbroad + fish.appearancefishright1.Length
                            || allfishes[Index2].appearbroad - 1 == fish.appearbroad + fish.appearancefishright1.Length
                            || allfishes[Index2].appearbroad - 2 == fish.appearbroad + fish.appearancefishright1.Length)
                        {
                            if (fish.appearheight == allfishes[Index2].appearheight || fish.appearheight - 1 == allfishes[Index2].appearheight)
                            {
                                allfishes[Index2].appearancefishleft = "";
                                allfishes[Index2].appearancefishright = "";
                                fish.appearancefishright2 = "                ";
                                fish.appearancefishright1 = fish.appearancerighteating;
                            }
                        }
                    }
                }
            }
            if (fish.leftright == "right")
            {
                fish.schwimmtiefe();
                if (appearbroad > height + 23)
                {
                    fish.leftright = "left";
                }
                else
                {
                    foreach (char sign in fish.appearancefishright1)
                    {
                        aquarium[appearheight, appearbroad] = Convert.ToString(sign);
                        appearbroad += 1;
                    }
                    appearbroad = appearbroad - fish.appearancefishright1.Length;
                    foreach (char sign in fish.appearancefishright2)
                    {
                        aquarium[appearheight - 1, appearbroad] = Convert.ToString(sign);
                        appearbroad += 1;
                    }
                    appearbroad = appearbroad - fish.appearancefishright2.Length + 1;
                    fish.appearancefishright2 = fish.appearancefishright4;
                    fish.appearancefishright1 = fish.appearancefishright3;
                }
            }
            else if (fish.leftright == "left")
            {
                fish.schwimmtiefe();
                if (appearbroad < 2)
                {
                    fish.leftright = "right";
                }
                else
                {
                    foreach (char sign in fish.appearancefishleft1)
                    {
                        aquarium[appearheight, appearbroad] = Convert.ToString(sign);
                        appearbroad += 1;
                    }
                    appearbroad = appearbroad - fish.appearancefishleft1.Length;
                    foreach (char sign in fish.appearancefishleft2)
                    {
                        aquarium[appearheight - 1, appearbroad] = Convert.ToString(sign);
                        appearbroad += 1;
                    }
                    appearbroad = appearbroad - fish.appearancefishleft2.Length - 1;
                    fish.appearancefishleft2 = fish.appearancefishleft4;
                    fish.appearancefishleft1 = fish.appearancefishleft3;
                }
            }
        }
        public void output()
        {
            for (int Index1 = 0; Index1 < height; Index1++)
            {
                for (int Index2 = 0; Index2 < broad; Index2++)
                {
                    if (Index2 == broad - 1)
                    {
                        Console.Write(aquarium[Index1, Index2]);
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Write(aquarium[Index1, Index2]);
                    }
                }
            }
        }
    }
}

