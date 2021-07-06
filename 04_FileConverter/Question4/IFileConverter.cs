using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Question4
{
    interface IFileConverter
    {
        string InputFileFormat { get; }
        string OutputFileFormat { get; }
        Object Convert(Object input);
    }

}
