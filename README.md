# UrlEncoder

URL encodes an string and decodes an url encoded string.

## License

The MIT License. See the [license](https://github.com/markusblasek/dotnettool.urlencoder/blob/main/LICENSE) file for details.

## Install
`$ dotnet tool install --global urlencoder --version 1.0.0`

## Usage
```bash
dotnet urlencoder encode --input "äü "
dotnet urlencoder decode --input "%C3%A4%C3%BC+"

dotnet tool run urlencoder -- encode --input "äü "
dotnet tool run urlencoder -- decode --input "%C3%A4%C3%BC+"
```