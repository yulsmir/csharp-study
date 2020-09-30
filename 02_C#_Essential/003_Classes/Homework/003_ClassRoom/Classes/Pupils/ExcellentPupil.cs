using System;
using System.Collections.Generic;
using System.Text;

namespace _003_ClassRoom.Classes.Pupils
{
    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Excellent!");
        }

        public override void Relax()
        {
            base.Relax();
        }
    }
}
