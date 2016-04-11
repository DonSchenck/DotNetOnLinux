FROM rhel7:latest
MAINTAINER Burr Sutter <burr.sutter@gmail.com>

RUN yum install -y tar

COPY dotnet-rpms-2016-04-07.tar .
RUN tar -xf dotnet-rpms-2016-04-07.tar -C /

WORKDIR /dotnet-rpms

RUN yum install -y ./rh-dotnet-core10-*
