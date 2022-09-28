using CommandLine;

namespace UrlEncoder
{
    [Verb("encode", true, new[] { "e", "en", "enc" }, HelpText = "URL encode a value")]
    public class EncodeCommandLineArgument : IReadFromStdInOption
    {
        [Option('i', "input", HelpText = "Value to encode")]
        public string? Input { get; set; }

        public bool ReadFromStdIn { get; set; }
    }
}
