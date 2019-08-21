using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunRussianRoullete
{
    // coding for a class
    public class gameclass
    {
        public int Shootgun = 2;
        public int chabspin = 6;
        public int Spingunload;
        public int spingun;


        public int AwaybulleteMissed()
            // coding for a spin and shoot logic 
        {
            int scorecal = 0;
            if (chabspin > 0 && spingun == 1 && Shootgun == 2)
            {

                scorecal = 10;


            }
            if (chabspin > 0 && spingun == 1 && Shootgun == 1)
            {

                scorecal = 5;

            }

            else if (chabspin > 0 && spingun != 1)
            {
                scorecal = 0;
                chabspin = chabspin - 1;
                if (spingun == 6)
                {
                    spingun = 1;
                }
                else
                {
                    spingun++;
                }




            }
            return scorecal;
        }

       // internal int AwaybulleteMissed()
        //{
         //   throw new NotImplementedException();
    //}
    }
}
