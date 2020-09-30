using System;
using System.Collections.Generic;
using System.Text;

namespace _003_ClassRoom.Classes.Pupils
{
    class BadPupil : Pupil
    {
        //readscore = 3
        // write score = 3
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
            Console.WriteLine("Bad!");
        }

        public override void Relax()
        {
            base.Relax();
        }
    }
}
