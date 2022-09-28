using CommandLine;

namespace UrlEncoder
{
    public interface IReadFromStdInOption
    {
        [Option('s', "stdin", HelpText = "Reads the input value from stdin")]
        public bool ReadFromStdIn { get; set; }
    }
}
