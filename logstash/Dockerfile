FROM docker.elastic.co/logstash/logstash:7.13.2

RUN rm -f /usr/share/logstash/pipeline/logstash.conf

USER root 

COPY mssql-jdbc-11.2.3.jre8.jar /usr/share/logstash/logstash-core/lib/jars/mssql-jdbc-11.2.3.jre8.jar
