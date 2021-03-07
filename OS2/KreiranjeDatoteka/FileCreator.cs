using System;
using System.Collections.Generic;
using System.Text;

namespace OS2
{
    public static class FileCreator
    {
        public static List<IFileManager> CreteListOfFileProcessors()
        {
            List<IFileManager> output = new List<IFileManager>
            {
                new FileManager(FileName.cisti_tekst.ToString()),
                new FileManager(FileName.javni_kljuc.ToString()),
                new FileManager(FileName.kriptirani_tekst_asimetricno.ToString()),
                new FileManager(FileName.kriptirani_tekst_simetricno.ToString()),
                new FileManager(FileName.potpis.ToString()),
                new FileManager(FileName.privatni_kljuc.ToString()),
                new FileManager(FileName.sazetak.ToString()),
                new FileManager(FileName.tajni_kljuc.ToString()),
            };
            return output;
        }

        public static IFileManager CreatePrivatniKljuc()
        {
            return new FileManager(FileName.privatni_kljuc.ToString());
        }

        public static IFileManager CreateJavniKljuc()
        {
            return new FileManager(FileName.javni_kljuc.ToString());
        }

        public static IFileManager CreateTajniKljuc()
        {
            return new FileManager(FileName.tajni_kljuc.ToString());
        }

        public static IFileManager CreateDekriptiraniTekst()
        {
            return new FileManager(FileName.cisti_tekst.ToString());
        }

        public static IFileManager CreateKriptiraniTekstAsimetricno()
        {
            return new FileManager(FileName.kriptirani_tekst_asimetricno.ToString());
        }

        public static IFileManager CreateKriptiraniTekstSimetricno()
        {
            return new FileManager(FileName.kriptirani_tekst_simetricno.ToString());
        }

        public static IFileManager CreateSazetak()
        {
            return new FileManager(FileName.sazetak.ToString());
        }

        public static IFileManager CreateDigitalniPotpis()
        {
            return new FileManager(FileName.potpis.ToString());
        }
    }
}
