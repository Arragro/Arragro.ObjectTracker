FROM microsoft/dotnet:2.1-sdk AS installer-env

COPY . /src/dotnet-function-app
COPY ../Arragro.ObjectHistory.Core /src/Arragro.ObjectHistory.Core
RUN cd /src/dotnet-function-app && \
    mkdir -p /home/site/wwwroot && \
    dotnet publish *.csproj --output /home/site/wwwroot

FROM mcr.microsoft.com/azure-functions/dotnet:2.0
ENV AzureWebJobsScriptRoot=/home/site/wwwroot
ENV Values:AzureWebJobsStorage=DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://192.168.69.160:10000/devstoreaccount1;TableEndpoint=http://192.168.69.160:10002/devstoreaccount1;QueueEndpoint=http://192.168.69.160:10001/devstoreaccount1;
ENV Values:AzureWebJobsDashboard==DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://192.168.69.160:10000/devstoreaccount1;TableEndpoint=http://192.168.69.160:10002/devstoreaccount1;QueueEndpoint=http://192.168.69.160:10001/devstoreaccount1;
ENV ObjectHistorySettings:ApplicationName=ApplicationName
ENV ObjectHistorySettings:StorageConnectionString==DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://192.168.69.160:10000/devstoreaccount1;TableEndpoint=http://192.168.69.160:10002/devstoreaccount1;QueueEndpoint=http://192.168.69.160:10001/devstoreaccount1;
ENV ObjectHistorySettings:ObjectContainerName=trackedobjects
ENV ObjectHistorySettings:MessageQueueName=objectprocessor
ENV ObjectHistorySettings:ObjectHistoryTable=ObjectHistory
ENV ObjectHistorySettings:GlobalHistoryTable=GlobalHistory

COPY --from=installer-env ["/home/site/wwwroot", "/home/site/wwwroot"]