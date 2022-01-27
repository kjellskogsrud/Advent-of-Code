// <copyright file="PuzzelInput.cs" company="Kjell Skogsrud">
// Copyright (c) Kjell Skogsrud. BSD 3-Clause License
// </copyright>

using System.Collections.Generic;
using System.IO;

namespace AoCSupport
{
    /// <summary>
    /// Represents the puzzelInput, and can return it in variouse formats.
    /// </summary>
    public class PuzzelInput
    {
        private string inputPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="PuzzelInput"/> class.
        /// </summary>
        /// <param name="path">The path to the puzzel input file.</param>
        public PuzzelInput(string path)
        {
            this.inputPath = path;
        }

        /// <summary>
        /// Gets the content of puzzelInput as a list of string.
        /// </summary>
        /// <returns>A List/<string/> object.</returns>
        public List<string> GetInputAsListOfString()
        {
            return new List<string>(File.ReadAllLines(this.inputPath));
        }
    }
}
