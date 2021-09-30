using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquariumproject
{
    /// <summary>
    /// This class contains all methods for the creation of the aquarium and the fishes.
    /// </summary>
    class Aquarium
    {
        //This is to set fix broad and height as required by the first task.
        /// <summary>
        /// This determines the broad of the aquarium.
        /// </summary>
        private int _broad = 30;

        /// <summary>
        ///  This determines the height of the aquarium.
        /// </summary>
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
        /// <summary>
        /// This property contains the appearheight of a fish in the aquarium.
        /// </summary>
        public int appearheight { get; set; }
        /// <summary>
        /// This property contains the appearbroad of a fish in the aquarium.
        /// </summary>
        public int appearbroad { get; set; }
        /// <summary>
        /// This multiarray contains the whole aquarium.
        /// </summary>
        public string[,] aquarium;
        //The method fillinfish needs this integer.
        int Arrayposition = 0;
        //This is an array to save every created fish
        universal_fish[] allfishes;
        /// <summary>
        /// This method puts the strings for the empty aquarium into the multiarray aquarium.
        /// </summary>
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
        /// <summary>
        /// This method decides through a random wich fishes are created and puts them into the method fillinfish.
        /// </summary>
        public void fillinfishes()
        {
            allfishes = new universal_fish[height];
            Random r = new Random();
            int wichfish;
            for (int Index = 0; Index < height; Index++)
            {
                wichfish = r.Next(0,100);
                if (wichfish <25)
                {
                    swordfish swordfish1 = new swordfish();
                    fillinfish(swordfish1);
                }
                else if (wichfish <50)
                {
                    blowfish blowfish1 = new blowfish();
                    fillinfish(blowfish1);
                }
                else if (wichfish < 75)
                {
                    shark shark1 = new shark();
                    fillinfish(shark1);
                }
                else if (wichfish < 100)
                {
                    carp carp1 = new carp();
                    fillinfish(carp1);
                }
            }
        }
        /// <summary>
        /// This methods puts the fishes into the aquarium and saves them in the array allfishes.
        /// </summary>
        /// <param name="fish"></param>
        public void fillinfish(universal_fish fish)
        {
            //Through maxheight every fish knows how high the aquarium is.
            fish.maxheight = height;
            Random r = new Random();
            //appearanceleftright defines through a random if the fish is spawned looking to the right or the left.
            int appearanceleftright;
            appearanceleftright = r.Next(0, 100);
            string beenden = "beenden";
            //This while condition checks if one fish covers another and produces new coordinates until none fish is covered by another.
            while (beenden == "beenden")
            {
                string beenden1 = "beenden";
                //The coordinates of a fish are set randomly.
                //appearheight has to be bigger than zero, because one other method doesn´t work otherwise.
                appearheight = r.Next(1, height - 2);
                appearbroad = r.Next(1, broad - 1 - fish.appearancefishleft.Length);
                for (int letter = 0; letter < fish.appearancefishleft.Length; letter++)
                {
                    if (beenden1 == "beenden")
                    {
                        //every coordinate of appearbroad of the shape string of the fish has to be empty before spawning.
                        if (aquarium[appearheight, appearbroad + letter] == " ")
                        {   
                            //if all coordinates are empty the while ribbon should end and the fish will be spawned.
                            beenden = "stopp";
                        }
                        else
                        {
                            //if one coordinate is not empty no other has to be checked.
                            beenden1 = "stopp";
                            //if one coordinate is not empty the while ribbon should restart.
                            beenden = "beenden";
                        }
                    }
                }
            }
            //Tis if spawnes the fish swimming to the left direction. Appearanceleftright is set befor by a Random.
                    if (appearanceleftright % 2 == 0)
                    {
                        //the foreach ribbon adds every sign of the fishshape to the aquarium
                        foreach (char sign in fish.appearancefishleft)
                        {
                            aquarium[appearheight, appearbroad] = Convert.ToString(sign);
                            appearbroad += 1;
                        }
                        //The fish has to be added to the fisharray to find it later.
                        allfishes[Arrayposition] = fish;
                        //The next fish has to be added at the next position of the array.
                        Arrayposition += 1;
                        //to put the fish into the aquarium the next time at one step to the left the data needs to be saved for every single fish.
                        fish.appearbroad = appearbroad - fish.appearancefishleft.Length - 1;
                        fish.appearheight = appearheight;
                        fish.leftright = "left";

                    }
                    //This else spawnes the fish swimming to the right direction.
                    else
                    {
                        //the foreach ribbon adds every sign of the fishshape to the aquarium
                        foreach (char sign in fish.appearancefishright)
                        {
                            aquarium[appearheight, appearbroad] = Convert.ToString(sign);
                            appearbroad += 1;
                        }
                        //The fish has to be added to the fisharray to find it later.
                        allfishes[Arrayposition] = fish;
                        //The next fish has to be added at the next position of the array.
                        Arrayposition += 1;
                        //to put the fish into the aquarium the next time at one step to the right the data needs to be saved for every single fish.
                        fish.appearbroad = appearbroad - fish.appearancefishleft.Length + 1;
                        fish.appearheight = appearheight;
                        fish.leftright = "right";
                    }
                }
        /// <summary>
        /// In the method eatingfishes the bigger fishes eat the smaller ones and grow one char for every fish they ate.
        /// </summary>
        public void eatingfishes()
        {
            //This for ribbon goes through every fish of the array named allfishes.
            for (int Index = 0; Index < allfishes.Length; Index++)
            {
                //This if will be implemented by the fishes swimming to the left.
                if (allfishes[Index].leftright == "left")
                {
                    for (int Index2 = 0; Index2 < allfishes.Length; Index2++)
                    {
                        //Hier werden die bereits gefressenen Fishe von dem fressen ausgeschlossen. Sie können somit nicht nochmal gefressen werden.
                        if (allfishes[Index2].appearancefishleft != "")
                        {
                            //Condition for the broad-coordinates of the fishes
                            if (allfishes[Index].appearbroad == allfishes[Index2].appearbroad + allfishes[Index2].appearancefishleft.Length
                                || allfishes[Index].appearbroad - 1 == allfishes[Index2].appearbroad + allfishes[Index2].appearancefishleft.Length)
                            {
                                //only a bigger fish can eat the other one (first condition) and the height-coordinates needs to be the same (second condition).
                                if (allfishes[Index].appearancefishleft.Length > allfishes[Index2].appearancefishleft.Length
                                    && allfishes[Index2].appearheight == allfishes[Index].appearheight)
                                {
                                    //The eaten fishes get the new string "", so one can´t see them in the aquarium output.
                                    allfishes[Index2].appearancefishleft = "";
                                    allfishes[Index2].appearancefishright = "";
                                    //The string for the shape of the fish wich ate is made one sign longer through this code.
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
                //This if will be implemented by the fishes swimming to the right.
                if (allfishes[Index].leftright == "right")
                {
                    for (int Index2 = 0; Index2 < allfishes.Length; Index2++)
                    {
                        //Hier werden die bereits gefressenen Fishe von dem fressen ausgeschlossen. Sie können somit nicht nochmal gefressen werden.
                        if (allfishes[Index2].appearancefishleft != "")
                        {
                            //Condition for the broad-coordinates of the fishes
                            if (allfishes[Index2].appearbroad == allfishes[Index].appearbroad + allfishes[Index].appearancefishleft.Length
                                || allfishes[Index2].appearbroad - 1 == allfishes[Index].appearbroad + allfishes[Index].appearancefishleft.Length)
                            {
                                //only a bigger fish can eat the other one (first condition) and the height-coordinates needs to be the same (second condition).
                                if (allfishes[Index].appearancefishleft.Length > allfishes[Index2].appearancefishleft.Length
                                    && allfishes[Index2].appearheight == allfishes[Index].appearheight)
                                {
                                    //The eaten fishes get the new string "", so one can´t see them in the aquarium output.
                                    allfishes[Index2].appearancefishleft = "";
                                    allfishes[Index2].appearancefishright = "";
                                    //The string for the shape of the fish wich ate is made one sign longer through this code.
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
        }
        public void movefishes()
        { 
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

