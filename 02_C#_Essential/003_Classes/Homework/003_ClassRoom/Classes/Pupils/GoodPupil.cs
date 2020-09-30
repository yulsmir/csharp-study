using System;
using System.Collections.Generic;
using System.Text;

namespace _003_ClassRoom.Classes.Pupils
{
    class GoodPupil : Pupil
    {
        //readscore = 4
        // write score = 4
        public override void Read()
        {
            base.Read();
        }

        public override void Write()
        {
            base.Write();
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine("Good!");
        }

        public override void Relax()
        {
            base.Relax();
        }
    }
}
