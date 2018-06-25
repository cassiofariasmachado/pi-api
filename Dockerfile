FROM microsoft/dotnet:2.0.0-runtime-stretch-arm32v7

ENV ASPNETCORE_URLS=http://+:80
WORKDIR /root/
EXPOSE 80
COPY src/Pi.Api/bin/publish .

ENTRYPOINT ["dotnet", "Pi.Api.dll"]