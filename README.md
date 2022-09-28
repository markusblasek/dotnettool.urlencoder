# UrlEncoder

URL encodes an string and decodes an url encoded string.

## License

The MIT License. See the [license](https://github.com/markusblasek/dotnettool.urlencoder/blob/main/LICENSE) file for details.

## Install
`$ dotnet tool install --global UrlEncoder --version 1.1.0-rc.0`

### Install from local nuget
`$ dotnet tool install --global --add-source "#path_to_folder#" urlencoder --version 1.1.0-rc.0`

## Usage
```bash
dotnet urlencoder encode --input "1+2"
dotnet urlencoder decode --input "1%2B2"

dotnet tool run urlencoder -- encode --input "1+2"
dotnet tool run urlencoder -- decode --input "1%2B2"

echo "1+2" | dotnet urlencoder encode --stdin
echo "1%2B2" | dotnet urlencoder decode --stdin
```