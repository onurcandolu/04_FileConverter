using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Question4
{
    public class FileConversionManager : IFileConverter
    {
        private string _InputFileFormat;
        private string _OutputFileFormat;
        public FileConversionManager(String InputType,String OutputType)
        {
            _InputFileFormat = InputType;
            _OutputFileFormat = OutputType;
        }
        public string InputFileFormat{ get => _InputFileFormat; }

        public string OutputFileFormat { get => _OutputFileFormat; }

       
        public Object Convert(Object MyFileInfo)
        {
            var newFileInfo = (FileInfo)MyFileInfo;
            if(this._InputFileFormat== newFileInfo.Extension)
                newFileInfo.MoveTo(Path.ChangeExtension(newFileInfo.FullName, this._OutputFileFormat));
            else
            {
                Console.WriteLine("This file Extention not equal to extention that you want.");
                return null;
            }
            return newFileInfo;
        }

    }
}
