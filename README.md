[![NuGet Version](https://img.shields.io/nuget/v/UrlEncoder.svg)](https://www.nuget.org/packages/UrlEncoder/)
[![Github Action Status](https://img.shields.io/github/actions/workflow/status/markusblasek/dotnettool.urlencoder/dotnet.yml)](https://github.com/markusblasek/dotnettool.urlencoder/actions/workflows/dotnet.yml)
[![NuGet Downloads](https://img.shields.io/nuget/dt/UrlEncoder.svg)](https://www.nuget.org/packages/UrlEncoder/)

# UrlEncoder

URL encodes an string and decodes an url encoded string.

## License

The MIT License. See the [license](https://github.com/markusblasek/dotnettool.urlencoder/blob/main/LICENSE) file for details.

## Install
`$ dotnet tool install --global UrlEncoder --version 1.2.0`

### Install from local nuget
`$ dotnet tool install --global --add-source "#path_to_folder#" urlencoder --version 1.2.0`

## Usage
```bash
dotnet urlencoder encode --input "1+2"
dotnet urlencoder decode --input "1%2B2"

dotnet tool run urlencoder -- encode --input "1+2"
dotnet tool run urlencoder -- decode --input "1%2B2"

echo "1+2" | dotnet urlencoder encode --stdin
echo "1%2B2" | dotnet urlencoder decode --stdin
```