﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodegenCS
{
    /// <summary>
    /// CodegenTextWriter with added properties that describe Outputfile location (RelativePath)
    /// </summary>
    public class CodegenOutputFile : CodegenTextWriter
    {
        /// <summary>
        /// Relative path of the output file (relative to the outputFolder)
        /// </summary>
        public string RelativePath;

        /// <summary>
        /// Creates a new OutputFile, with a relative path
        /// </summary>
        /// <param name="relativePath"></param>
        public CodegenOutputFile(string relativePath) : base()
        {
            this.RelativePath = relativePath;
        }
    }

    /// <summary>
    /// CodegenTextWriter with added properties that describe Outputfile location (RelativePath) <br />
    /// and type of output (regarding .NET Project - if file is Compiled, NotCompiled, etc)
    /// </summary>
    public class CodegenOutputFile<FT> : CodegenOutputFile
        where FT : struct, IComparable, IConvertible, IFormattable // FT should be enum. 
    {

        /// <summary>
        /// Type of file
        /// </summary>
        public FT FileType { get; set; }

        /// <summary>
        /// Creates a new OutputFile, with a relative path
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="fileType"></param>
        public CodegenOutputFile(string relativePath, FT fileType) : base(relativePath)
        {
            this.FileType = fileType;
        }
    }

}
