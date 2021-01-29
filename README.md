# Studies_dotnet-trace
This is a simple project created with the intention of using [dotnet-trace](https://docs.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-trace) to analyse its performance.

This code reads an image and converts it to a .txt containing the RGB information of the image.

dotnet-trace install:
`dotnet tool install --global dotnet-trace`

Listing all .Net processes:
`dotnet trace ps`

Starting collection:
`dotnet trace collect -p {Process-PID}`

Converting output analysis file to different format <Chromium|NetTrace|Speedscope>:
`dotnet trace convert --format {desired format}`
(if no input file is specified, it will default to trace.nettrace)
