FROM mcr.microsoft.com/mssql/server:2019-latest AS build
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Pwd12345

WORKDIR /tmp

COPY CreateDatabase.sql . 
COPY PostDeployment.sql . 
COPY spFood_All.sql . 
COPY spOrders_Delete.sql . 
COPY spOrders_GetById.sql . 
COPY spOrders_Insert.sql . 
COPY spOrders_UpdateName.sql . 


RUN /opt/mssql/bin/sqlservr --accept-eula & sleep 10 \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Pwd12345" -i /tmp/CreateDatabase.sql \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Pwd12345" -i /tmp/PostDeployment.sql \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Pwd12345" -i /tmp/spFood_All.sql \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Pwd12345" -i /tmp/spOrders_Delete.sql \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Pwd12345" -i /tmp/spOrders_GetById.sql \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Pwd12345" -i /tmp/spOrders_Insert.sql \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Pwd12345" -i /tmp/spOrders_UpdateName.sql \
    && pkill sqlservr

FROM mcr.microsoft.com/mssql/server:2019-latest AS release
ENV ACCEPT_EULA=Y
COPY --from=build /var/opt/mssql/data /var/opt/mssql/data