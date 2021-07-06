using System;
using System.IO;

namespace Question4
{
    class Program
    {
        public static IFileConverter converter;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input Format: (hind : .jpg .cs .png )");
            var Inputformat = Console.ReadLine();

            Console.WriteLine("Enter Output Format: (hind : .jpg .cs .png )");
            var Outputformat = Console.ReadLine();


            converter = new FileConversionManager(Inputformat, Outputformat);
            string MyFile = "C:\\Users\\onurcan.ArkV\\Desktop\\deneme.jpg";


            FileInfo MyFileInfo = new FileInfo(MyFile);
            if (!MyFileInfo.Exists)
                Console.WriteLine("Wrong File Path");
            else
            {
                FileInfo Info = (FileInfo)converter.Convert(MyFileInfo);
               if(Info != null) Console.WriteLine("I converted your file extention "+converter.InputFileFormat+" to "+ converter.OutputFileFormat+ " \n New file path is "+ Info.FullName);
            }

        }

        public static object Convert(object input, string inputFileFormat, string outputFileFormat)
        {
            Console.WriteLine(converter.OutputFileFormat);
            return input;
        }

    }
}
