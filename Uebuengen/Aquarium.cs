using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
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
            appearheight = r.Next(0, height - 2);
            appearbroad = r.Next(1, broad - 1 - fish.appearancefishleft.Length);
            if (appearanceleftright%2==0)
            {
                foreach (char sign in fish.appearancefishleft)
                {
                    aquarium[appearheight, appearbroad] = Convert.ToString(sign);
                    appearbroad += 1;
                }
                allfishes[Arrayposition] = fish;
                Arrayposition += 1;
                fish.appearbroad = appearbroad - fish.appearancefishleft.Length -1;
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
            for (int Index = 0; Index < height; Index++)
            {
                allfishes[Index].schwimmtiefe();
                if(allfishes[Index].appearbroad == 0)
                {
                    allfishes[Index].appearbroad = 1;
                    allfishes[Index].leftright = "right";
                }
                else if(allfishes[Index].appearbroad > (broad- allfishes[Index].appearancefishleft.Length)-2)
                {
                    allfishes[Index].appearbroad = (broad- allfishes[Index].appearancefishleft.Length)-1;
                    allfishes[Index].leftright = "left";
                }
                else
                {
                    if (allfishes[Index].leftright == "left")
                    {
                        foreach (char sign in allfishes[Index].appearancefishleft)
                        {
                            aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad] = Convert.ToString(sign);
                            allfishes[Index].appearbroad += 1;
                        }
                        allfishes[Index].appearbroad -= (allfishes[Index].appearancefishleft.Length + 1);
                    }
                    else
                    {
                        foreach (char sign in allfishes[Index].appearancefishright)
                        {

                            aquarium[allfishes[Index].appearheight, allfishes[Index].appearbroad] = Convert.ToString(sign);
                            allfishes[Index].appearbroad += 1;
                        }
                        allfishes[Index].appearbroad -= (allfishes[Index].appearancefishleft.Length - 3);
                    }
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
