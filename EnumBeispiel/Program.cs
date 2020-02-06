using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumBeispiel {
    class Program {
        static void Main ( string [] args ) {
            Teilnehmer x = new Teilnehmer ();
            x.ID = 4711;
            x.Name = "Horst";
            x.Tugend = Tugend.GARNICHT;

            Teilnehmer y = new Teilnehmer () { ID = 4712, Name = "Dietrich", Tugend = Tugend.PÜNKTLICH };

            List<Teilnehmer> teilnehmers = new List<Teilnehmer>();
            teilnehmers.Add (x);
            teilnehmers.Add ( y );
            teilnehmers.Add (new Teilnehmer () { ID=4713, Name="August",Tugend=Tugend.PÜNKTLICH} );
            teilnehmers.Add ( new Teilnehmer () { ID = 4714, Name = "Han", Tugend = Tugend.ZUSPÄT } );

            // Ausgabe Container

            foreach ( Teilnehmer teilnehmer in teilnehmers ) {
                Console.WriteLine ($"Teinehmername: {teilnehmer.Name} ID: {teilnehmer.ID} Tugendhaftigkeit: {teilnehmer.Tugend}");
            }

            foreach ( Teilnehmer teilnehmer in teilnehmers ) {
                teilnehmer.Rechtum = Reichtum.SEHRREICH;
                teilnehmer.Tag = Tag.DONNERSTAG;
            }

            foreach ( Teilnehmer teilnehmer in teilnehmers ) {
                Console.WriteLine ( $"Teinehmername: {teilnehmer.Name} ID: {teilnehmer.ID} Tugendhaftigkeit: {teilnehmer.Tugend} Tag: {teilnehmer.Tag}" );
            }

            foreach ( Teilnehmer teilnehmer in teilnehmers ) {
                Console.WriteLine ( $"Teinehmername: {teilnehmer.Name} ID: {teilnehmer.ID} Tugendhaftigkeit: {(int) teilnehmer.Tugend} Tag: {(int) teilnehmer.Tag}" );
            }

            //Console.WriteLine (x.ToString());



            Console.ReadLine ();
        }
    }


}
