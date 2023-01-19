FROM mcr.microsoft.com/mssql/server:2019-GA-ubuntu-16.04
ENV SA_PASSWORD "qweQWE123"
ENV ACCEPT_EULA "Y"

USER root 

COPY AdventureWorks2019.bak  /var/opt/mssql/backup/AdventureWorks2019.bak

RUN chown -R mssql:root /var/opt/mssql/backup/AdventureWorks2019.bak

#RUN Chown=mssql:root
USER mssql

RUN /opt/mssql/bin/sqlservr --accept-eula & (echo "awaiting mssql bootup for 15 seconds" && sleep 15 && echo "restoring.."  && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'qweQWE123' -Q "RESTORE DATABASE AdventureWorks2017 FROM DISK = '/var/opt/mssql/backup/AdventureWorks2019.bak' WITH MOVE 'AdventureWorks2017' TO '/var/opt/mssql/data/AdventureWorks2019.mdf', MOVE 'AdventureWorks2017_Log' TO '/var/opt/mssql/data/AdventureWorks2019.ldf'")
