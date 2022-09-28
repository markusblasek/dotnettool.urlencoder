﻿using CommandLine;

namespace UrlEncoder
{
    [Verb("encode", true, new[] { "e", "en", "enc" }, HelpText = "URL encode a value")]
    class EncodeCommandLineArgument
    {
        [Option('i', "input", Required = true, HelpText = "Value to encode")]
        public string? Input { get; set; }
    }
}