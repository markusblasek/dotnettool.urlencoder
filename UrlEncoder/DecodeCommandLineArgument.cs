using CommandLine;

namespace UrlEncoder
{
    [Verb("decode", false, new[] { "d", "de", "dec" }, HelpText = "Decode an url encoded value")]
    public class DecodeCommandLineArgument : IReadFromStdInOption
    {
        [Option('i', "input", HelpText = "Value to decode")]
        public string? Input { get; set; }

        public bool ReadFromStdIn { get; set; }
    }
}
