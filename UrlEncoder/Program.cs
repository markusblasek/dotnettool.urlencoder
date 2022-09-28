using System.Net;
using System.Text;
using CommandLine;

namespace UrlEncoder;

public static class Program
{
    static int Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        return Parser.Default.ParseArguments<EncodeCommandLineArgument, DecodeCommandLineArgument>(args)
            .MapResult(
                (EncodeCommandLineArgument options) => Encode(options),
                (DecodeCommandLineArgument options) => Decode(options),
                _ => 255);
    }

    private static int Encode(EncodeCommandLineArgument args)
    {
        var input = GetValueToEncode(args);
        var urlEncodedValue = WebUtility.UrlEncode(input);
        Console.WriteLine(urlEncodedValue);
        return 0;
    }

    private static int Decode(DecodeCommandLineArgument args)
    {
        var input = GetValueToDecode(args);
        var urlDecodedValue = WebUtility.UrlDecode(input);
        Console.WriteLine(urlDecodedValue);
        return 0;
    }

    private static string? GetValueToEncode(EncodeCommandLineArgument args)
    {
        return args.ReadFromStdIn ? ReadFromStdIn() : args.Input;
    }

    private static string? GetValueToDecode(DecodeCommandLineArgument args)
    {
        return args.ReadFromStdIn ? ReadFromStdIn() : args.Input;
    }

    private static string? ReadFromStdIn()
    {
        return Console.In.ReadLine();
    }
}