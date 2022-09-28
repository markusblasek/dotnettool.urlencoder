using CommandLine;

namespace UrlEncoder
{
    [Verb("decode", false, new[] { "d", "de", "dec" }, HelpText = "Decode an url encoded value")]
    class DecodeCommandLineArgument
    {
        [Option('i', "input", Required = true, HelpText = "Value to decode")]
        public string? Input { get; set; }
    }
}
