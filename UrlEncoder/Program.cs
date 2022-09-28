using System.Net;
using CommandLine;

namespace UrlEncoder;

public static class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<EncodeCommandLineArgument, DecodeCommandLineArgument>(args)
            .MapResult(
                (EncodeCommandLineArgument options) => Encode(options),
                (DecodeCommandLineArgument options) => Decode(options),
                _ => 255);
    }

    private static int Encode(EncodeCommandLineArgument args)
    {
        var urlEncodedValue = WebUtility.UrlEncode(args.Input);
        Console.WriteLine(urlEncodedValue);
        return 0;
    }

    private static int Decode(DecodeCommandLineArgument args)
    {
        var urlDecodedValue = WebUtility.UrlDecode(args.Input);
        Console.WriteLine(urlDecodedValue);
        return 0;
    }
}